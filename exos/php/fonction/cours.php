<?php

// Fonction qui a pour tâche de dire "Bonjour !"
function direBonjour(): void
{
    echo "Bonjour !";
    echo PHP_EOL;
}

// Appel de la fonction direBonjour

direBonjour();

function direBonjourPrenom(string $prenom): void // $prenom Variable locale 
{
    echo "Bonjour $prenom";
    echo PHP_EOL;
}

direBonjourPrenom("Alexis");
direBonjourPrenom("Axel");

$prenom = "Lolita"; // $prenom Variable globale 
direBonjourPrenom("Samy");

$nom = "MOTTNER";
function direSalut(): void
{
    global $nom; // Ne jamais utiliser de variables global dans une fonction
    echo "Salut $nom"; // Accès à une variable globale 
    echo PHP_EOL;
}
direSalut();

// Additionner 2 nombres entiers 
function additionner(int $a, int $b): int
{
    $result = $a + $b; // $result est une variable locale 
    return $result;
}
// Appel de la fonction Additionner  
$somme = additionner(2, 3);
echo "La somme de 2 + 3 = $somme";
echo PHP_EOL;

function saluer(string $prenom): string
{
    $salut = "Salut $prenom" . PHP_EOL;
    return $salut;
}
echo saluer("Hugo");

echo "La somme est égale à additionner(2,3)"; // Interpolation impossible
echo PHP_EOL;
echo "La somme est égale à " . additionner(2, 6); // Concaténation possible  
echo PHP_EOL;

function incrémenter(int $nombre): int
{
    $nombre += 1;       // /\ Copie de valeur 
    return $nombre;     // |
}                       // |
$compteur = 1;          // |
$compteur = incrémenter($compteur);
echo $compteur;
