
Imports System.IO ' Path, File
Imports System.Text ' StringBuilder

Public Class Form1

    Dim m_bOuvertureComptesBrut As Boolean = False

    Private Sub cmdConv_Click(sender As Object, e As EventArgs) Handles cmdConv.Click

        Dim sCheminBrut$ = Path.Combine(Application.StartupPath, "ComptesBrut.txt")
        If Not File.Exists(sCheminBrut) Then EcrireFichier(sCheminBrut, "", Encoding.UTF8)
        If Not m_bOuvertureComptesBrut Then
            Me.cmdConv.Text = "Convertir"
            m_bOuvertureComptesBrut = True
            OuvrirFichier(sCheminBrut)
            Exit Sub
        End If
        Dim sCheminLigneALigne$ = Path.Combine(Application.StartupPath, "ComptesLigneALigne.txt")
        Dim asLignes = File.ReadAllLines(sCheminBrut, encoding:=Encoding.UTF8)

        ' Le signe € est un caractère unicode, il faut le sauver en UTF8, sinon on peut conserver l'encodage ASCII
        Const bAjouterSigneEuro = False

        Dim iNbLignesCompte% = 0
        Dim bLigneEnCours = False
        Dim sDate$ = ""
        Dim sDateDeValeur$ = ""
        Dim sMontant$ = ""
        Dim sLibelle$ = ""
        Dim bLibelleEnCours = False
        Dim sb As New StringBuilder
        For Each sLigne In asLignes
            If sLigne.StartsWith("Date de l'opération") Then
                iNbLignesCompte += 1
                bLigneEnCours = True
            ElseIf bLigneEnCours Then

                If sLigne.EndsWith("€") Then
                    bLigneEnCours = False

                    sMontant = sLigne
                    If Not bAjouterSigneEuro Then sMontant = sMontant.Replace("€", "").Replace("−", "-").TrimEnd

                    Dim sBilan$ = sDate & vbTab & sLibelle & vbTab & sMontant
                    If sDateDeValeur <> sDate Then sBilan &= vbTab & "-> " & sDateDeValeur ' "Date de valeur : "
                    sb.AppendLine(sBilan)
                    sDate = ""
                    sDateDeValeur = ""
                    sMontant = ""
                    sLibelle = ""

                ElseIf bLibelleEnCours And Not String.IsNullOrEmpty(sLigne) And sLigne <> "Montant" Then
                    sLibelle = sLigne
                End If

            End If

            If bLigneEnCours Then
                Dim iPosDate% = sLigne.IndexOf("Date de l'opération")
                If iPosDate > -1 Then sDate = sLigne.Substring(iPosDate + 19, 8) : sDate = sCorrigerDate(sDate)
                Dim iPosDateV% = sLigne.IndexOf("Date de valeur")
                If iPosDateV > -1 Then sDateDeValeur = sLigne.Substring(iPosDate + 15, 8) : sDateDeValeur = sCorrigerDate(sDateDeValeur)

                If sLigne = "Libellé :" Then
                    bLibelleEnCours = True
                End If

            End If

        Next

        If iNbLignesCompte = 0 Then
            MessageBox.Show("Aucune ligne de compte trouvée !", "ConvAxaBanque",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim encodage As Encoding = Encoding.ASCII
        If bAjouterSigneEuro Then encodage = Encoding.UTF8
        EcrireFichier(sCheminLigneALigne, sb.ToString(), encodage)

        OuvrirFichier(sCheminLigneALigne)

    End Sub

    Private Function sCorrigerDate(sDate As String) As String
        Dim iPosDernierSlash% = sDate.LastIndexOf("/")
        Dim sAnnee$ = sDate.Substring(iPosDernierSlash + 1, 2)
        Dim sDateCorrigee$ = sDate.Substring(0, iPosDernierSlash + 1) & "20" & sAnnee
        Return sDateCorrigee
    End Function

    Private Sub EcrireFichier(sChemin$, sTexte$, encodage As Encoding)
        Using sw As New IO.StreamWriter(sChemin, append:=False, encoding:=encodage)
            sw.Write(sTexte)
        End Using
    End Sub

    Private Sub OuvrirFichier(sChemin$)
        Process.Start(New ProcessStartInfo(sChemin) With {.UseShellExecute = True})
    End Sub

End Class
