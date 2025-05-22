<?php

$numerateur = readline("Saisir un nombre entier : ");
$denominateur = readline("Saisir un nombre entier : ");

if ($denominateur == 0) {
    echo "Error : Division by zero!";
} else {
    $division = round($numerateur / $denominateur, 2);
    echo "Le résultat de la division de $numerateur par $denominateur est $division";
}
