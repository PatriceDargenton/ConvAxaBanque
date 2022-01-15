<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmdConv = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdConv
        '
        Me.cmdConv.Location = New System.Drawing.Point(12, 12)
        Me.cmdConv.Name = "cmdConv"
        Me.cmdConv.Size = New System.Drawing.Size(84, 32)
        Me.cmdConv.TabIndex = 0
        Me.cmdConv.Text = "Ouvrir"
        Me.cmdConv.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 101)
        Me.Controls.Add(Me.cmdConv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Convertisseur AxaBanque - v1.01 (15/01/2022)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdConv As Button
End Class
