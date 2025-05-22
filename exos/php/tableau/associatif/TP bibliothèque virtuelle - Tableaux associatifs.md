
### 📚 TP : Gestion de la Bibliothèque Virtuelle avec des Tableaux Associatifs à Une Dimension

Vous allez travailler avec des tableaux associatifs à une dimension pour gérer des informations sur les livres dans une bibliothèque virtuelle.

#### 🎯 Objectifs

- Manipuler des tableaux associatifs à une dimension.
- Utiliser des boucles `foreach` pour parcourir les tableaux.
- Appliquer des structures conditionnelles pour traiter des données.

#### 📝 Exercice 1 : Création du tableau associatif de livres

Créez un tableau associatif où chaque clé est le titre d'un livre et chaque valeur est une chaîne de caractères contenant l'auteur et l'année de publication, séparés par un caractère `|`.

Par exemple :

```php
$livres = [
    'Le Grand Meaulnes' => 'Alain-Fournier|1913',
    'L’Etranger' => 'Albert Camus|1942',
    '1984' => 'George Orwell|1949',
    'Le Seigneur des Anneaux' => 'J.R.R. Tolkien|1954',
    'Harry Potter à l’école des sorciers' => 'J.K. Rowling|1997'
];
```

Affichez ensuite le tableau complet avec une boucle `foreach`, en décomposant chaque valeur pour afficher le titre, l'auteur et l'année de publication.

#### 👨‍🎨 Exercice 2 : Affichage des auteurs

Parcourez le tableau des livres et affichez uniquement les noms des auteurs, chacun sur une nouvelle ligne.

#### 🔍 Exercice 3 : Vérification de l'existence d'un livre

Écrivez un script qui demande à l'utilisateur de saisir un titre de livre. Si ce titre existe dans le tableau, affichez les détails du livre (auteur et année de publication). Sinon, affichez un message indiquant que le livre n'est pas disponible dans la bibliothèque.

#### 📊 Exercice 4 : Comptage des livres par auteur

Créez un script qui parcourt le tableau et affiche combien de livres chaque auteur a écrits. Le résultat doit être sous la forme :

  -  Alain-Fournier : 1 livre

-  Albert Camus : 1 livre

-  George Orwell : 1 livre

-  J.R.R. Tolkien : 1 livre

-  J.K. Rowling : 1 livre

#### ⏳ Exercice 5 : Affichage des livres publiés avant une certaine année

Demandez à l'utilisateur de saisir une année. Parcourez le tableau et affichez tous les livres publiés avant cette année.

#### 📅 Exercice 6 : Comptage des livres par décennie

Parcourez le tableau des livres et comptez combien de livres ont été publiés dans chaque décennie. Affichez le résultat sous la forme :

- `1910-1919 : 1 livre`
- `1940-1949 : 2 livres`
- `1950-1959 : 1 livre`
- `1990-1999 : 1 livre`

---

### 📎 Annexes

#### 💡 Explication de la fonction `explode`

La fonction `explode()` en PHP est utilisée pour diviser une chaîne de caractères en un tableau, en utilisant un délimiteur spécifié. Par exemple, dans ce TP, les informations sur les livres sont stockées sous la forme d'une chaîne de caractères séparée par un `|`.

Voici un exemple d'utilisation de `explode()` pour récupérer les informations d'un livre :

```php
$details = 'Alain-Fournier|1913';
$elements = explode('|', $details);
// $elements est maintenant un tableau : ['Alain-Fournier', '1913']
```

Vous pouvez ensuite accéder aux informations en utilisant les index du tableau :

```php
$auteur = $elements[0];
$annee = $elements[1];
```

Une autre méthode pour récupérer les données consiste à utiliser `list()` en combinaison avec `explode()` :

```php
$details = 'Alain-Fournier|1913';
list($auteur, $annee) = explode('|', $details);
// $auteur contient 'Alain-Fournier' et $annee contient '1913'
```

Cela permet de rendre le code plus lisible et d'extraire directement les valeurs dans des variables distinctes.


