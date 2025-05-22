<?php

$horaires = [
    "Lundi" => ["9:00", "12:30", "14:00", "18:00"],
    "Mardi" => ["9:00", "12:30", "14:00", "18:00"],
    "Mercredi" => ["Fermé"],
    "Jeudi" => ["10:00", "13:00", "15:00", "19:00"],
    "Vendredi" => ["9:00", "12:30", "14:00", "18:00"],
    "Samedi" => ["10:00", "13:00", "15:00", "19:00"],
    "Dimanche" => ["Fermé"]
];

foreach ($horaires as $valeur => $ligne) {

    if ($valeur == "Mercredi" || $valeur == "Dimanche") {
        echo $valeur . " : Fermé ";
    } else {
        echo $valeur . " : Ouvert de $ligne[0] à $ligne[1] et de $ligne[2] à $ligne[3]";
    }
    echo PHP_EOL;
};

$jourWeek = readline("Saisir un jour de la semaine : ");
$hours = readline("Saisir une heure (XX:XX) : ");

foreach ($horaires as $jour => $heure) {
    if ($jour == "Mercredi" || $jour == "Dimanche") {
        echo "Le magasin est fermé toute la journée le mercredi et le dimanche";
        break;
    } elseif ($hours) {
    }
}
