<?php

$livres = ["Le Petit Prince", "1984", "Les Misérables", "Le Rouge et le Noir", "Harry Potter"];


$numero = 1;


foreach ($livres as $titre) {
    echo "$numero. $titre\n";
    $numero++;
}
