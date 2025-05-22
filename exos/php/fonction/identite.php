<?php

$prenom = readline("Saisir un prenom : ");
$nom = readline("Saisir un nom : ");

function identite(string $first, string $second): string
{
    $prenom = ucfirst($first);
    $nom = strtoupper($second);
    return $prenom . " " . $nom;
}

echo " Votre identité est " . identite($prenom, $nom);
