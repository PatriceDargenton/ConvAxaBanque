Convertisseur AxaBanque
---

Version 1.01 du 15/01/2022

Au début de l'année 2022, AxaBanque a changé son site web, et désormais, lorsque l'on fait un copié-collé du contenu des lignes de compte depuis la page web de leur site, on n'a plus chaque ligne de compte sur une seule ligne de texte, mais par exemple ceci :

```
ligne 1.
Date de l'opération21/12/202121/12/21
Date de valeur22/12/202122/12/21
Libellé :
CARTE 21/12 Netflix.com XXXXXXXXXXXXXXXX
Solde : −13,49€−13,49 €
ligne 2.
Date de l'opération17/12/202117/12/21
Date de valeur20/12/202120/12/21
Libellé :
RETRAIT DAB 17/12 LCL LYON XXXXXXXXXXXXXXXXXXX / 3
Solde : −80,00€−80,00 €
```

Ce convertisseur permet de retrouver le format habituel ligne à ligne :

```
21/12/2021	CARTE 21/12 Netflix.com XXXXXXXXXXXXXXXX	-13,49 	-> 22/12/2021
17/12/2021	RETRAIT DAB 17/12 LCL LYON XXXXXXXXXXXXXXXXXXX / 3	-80,00 	-> 20/12/2021
```

Temps de développement : 1h + 1h pour peaufiner et publier.