<?php

$largeur = readline("Saisir une largeur : ");
$hauteur = readline("Saisir une hauteur : ");

for ($i = 1; $i <= $hauteur; $i++) {

    for ($j = 1; $j <= $largeur; $j++) {
        echo "*";
    }
    echo PHP_EOL;
}
