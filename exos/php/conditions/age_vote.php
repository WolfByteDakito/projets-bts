<?php

$age = readline("Saisir son âge : ");

if ($age < 18) {
    echo "Vous êtes mineur";
} elseif ($age == 18) {
    echo "Vous êtes majeur";
} else {
    $anneeMajeur = $age - 18;
    echo "Tu es majeur depuis $anneeMajeur";
}
