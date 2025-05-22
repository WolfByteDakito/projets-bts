<?php


$fondRouge = "\033[41m";
$texteRouge = "\033[31m";
$fondVert = "\033[42m";
$texteVert = "\033[32m";
$normal = "\033[0m";

$km = readline("Saisir la distance du trajet (kms) : ");
$times = readline("Saisir la durée du trajet (h:mm) : ");
$positionSeparateur = strpos($times, ":");  // RENVOI 1 --> 1:30 
$heures = substr($times, 0, $positionSeparateur); // RENVOI LE 1 --> 1:30 
$minutes = substr($times, $positionSeparateur + 1, 2); // RENOVI 30 --> 1:30

if ($minutes < 60) {
    $dureeMinutes = $heures * 60 + $minutes;
    $vitesse = ceil(($km / $dureeMinutes) * 60);
    echo "La vitesse moyenne du trajet est de $vitesse km/h";

    echo PHP_EOL;

    if ($vitesse <= 90) {
        echo $fondVert . "Vous êtes en dessous-des 90 km/h" . $normal;
    } else {
        echo $fondRouge . "Vous êtes au dessus-des 90 km/h" . $normal;
    }
} else {
    echo $texteRouge . "ERREUR : la durée $times est invalide 
   !" . $normal;
}




///////////////////// CORRECTION ////////////////////////



// $distance = readline("Saisir la distance du trajet (kms) : ");
// $dureeTrajet = readline("Saisir la durée du trajet (h:mm) : ");

// $positionSeparateur = strpos($dureeTrajet,":");
// $heures = substr($dureeTrajet,0,$positionSeparateur);
// $minutes = substr($dureeTrajet,$positionSeparateur+1,2);
