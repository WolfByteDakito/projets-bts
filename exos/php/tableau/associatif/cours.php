<?php
//declaration d'un tableau associatif
$personne = [
    "dupond" => 29,
    "martin" => 24,
    "durand" => 42
];

//afficher l'age de martin
echo $personne["martin"]; // 24

//afficher les ages ( valeurs des elemetns )
foreach ($personne as $age) {
    echo $age . ' '; // 29.24.42
}
echo PHP_EOL;
//afficher le nom (cle) et l'age (veleur) de chque personne
foreach ($personne as $nom => $age) {
    echo "$nom a $age ans ! " . PHP_EOL;
}

//afficher le nom (cle) de chaque personne
$noms = array_keys($personne);
//$nom est un tbaleau indexe qui contient les nom de chaque personne
foreach ($noms as $nom) {
    echo $nom . ' ';
}
echo PHP_EOL;

//ajouter une nouvelle personne
$personne["emilien"] = 18;
echo PHP_EOL;
echo $personne["emilien"];

//calculer et afficher la moyenne des ages
$somme = 0;
foreach ($personne as $age) {
    $somme += $age;
    $moyenne = $somme / count($personne);
    echo $moyenne;
}

//tester si le tableau n'est pas vide
if (count($perosnne) > 0) {
    $moyenne = $somme / count($perosnne);
    echo $moyenne;
}

//afficher les noms des personnes en majuscules
$noms = array_keys($personne);
//$nom est un tbaleau indexe qui contient les nom de chaque personne
foreach ($noms as $nom) {
    echo $nom . ' ';
}
echo PHP_EOL;
