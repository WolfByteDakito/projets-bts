<?php

$livres = ["Le Petit Prince", "1984", "Les Misérables", "Le Rouge et le Noir", "Harry Potter"];

$mot = readline("Entrez un mot à compter : ");
$compteur = 0;

foreach ($livres as $titre) {
    $compteur += substr_count(strtolower($titre), strtolower($mot));
}

echo 'Le mot "' . $mot . '" apparaît ' . $compteur . ' fois dans les titres.';
