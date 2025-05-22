<?php

$livres = ["Le Petit Prince", "1984", "Les Misérables", "Le Rouge et le Noir", "Harry Potter"];

$motCle = readline("Entrez un mot-clé à rechercher : ");

foreach ($livres as $titre) {
    if (stripos($titre, $motCle) !== false) {
        echo "$titre";
    }
}
