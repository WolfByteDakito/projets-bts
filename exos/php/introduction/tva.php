<?php

$HT = readline("Saisir un prix HT : ");
$TVA = readline("Saisir un taux de TVA (pourcentage) : ");
$TTC = round($TVA + $HT, 2);
echo "Le prix TTC est de : $TTC € ";