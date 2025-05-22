<?php

$contact = [

    "mael" => "07 69 58 47 20",
    "emilien" => "06 63 41 02 45",
    "sophie" => "06 66 66 66 66",
    "paul" => "07 69 30 25 47",
    "maxime" => "04 25 78 98 41"
];

$searchName = readline("Saisir un nom d'utilisateur : ");

if (array_key_exists($searchName, $contact)) {
    echo "Contact : " . $contact[$searchName] . PHP_EOL;
} else {
    echo $searchName . " : CODE ERREUR ### Utilisateur incorrect ###";
}
