Convertisseur AxaBanque
---

Version 1.02 du 30/12/2023

Au début de l'année 2022, AxaBanque a changé son site web, et désormais, lorsque l'on fait un copié-collé du contenu des lignes de compte depuis la page web de leur site, on n'a plus chaque ligne de compte sur une seule ligne de texte, mais par exemple ceci :

```
Plus tôt dans la semaine
Date de l'opération21/12/23
Date de valeur22/12/23
Libellé :
CARTE 21/12 Netflix.com XXXXXXXXXXXXXXXX

Montant
−13,49€

La semaine dernière

Date de l'opération17/12/23
Date de valeur20/12/23
Libellé :
RETRAIT DAB 17/12 LCL LYON XXXXXXXXXXXXXXXXXXX / 3

Montant
−80,00€
```

Ce convertisseur permet de retrouver le format habituel ligne à ligne :

```
21/12/2023	CARTE 21/12 Netflix.com XXXXXXXXXXXXXXXX	-13,49	-> 22/12/2023
17/12/2023	RETRAIT DAB 17/12 LCL LYON XXXXXXXXXXXXXXXXXXX / 3	-80,00	-> 20/12/2023
```

Temps de développement : 1h + 1h pour peaufiner et publier.