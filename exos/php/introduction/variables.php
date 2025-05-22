<?php

// Créer une variable nommée prenom initalisée avec la valeur "Alexis"
$prenom = "Alexis";
echo $prenom;
echo PHP_EOL;
// echo $PRENOM php sensible à la casse (minuscule/MAJUSCULE)
$prenom = "Mael";
echo "je suis " . $prenom;
echo PHP_EOL;
$age = "18";
echo "j'ai $age ans";
echo PHP_EOL;
$age = "22";
// '\' pour les simples côtes
echo 'J\'ai $age ans'; 
echo PHP_EOL;

// Saisie utilisateur 

$prenom = readline("Veuillez saisir votre prénom : ");
echo PHP_EOL;
echo "La valeur saisie est $prenom";
echo PHP_EOL;


// afficher la valeur de $prenom en majuscule 

echo strtoupper($prenom);
echo PHP_EOL;
$prenomMinuscule = strtolower($prenom);
echo PHP_EOL;
echo "Bonjour je m'appelle $prenomMinuscule";
echo PHP_EOL;

// afficher le nombre de caractères du prénom

$longueur = strlen($prenom);
echo $longueur;



