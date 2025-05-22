<?php
$nombrePairImpair = readline("Saisir un nombre : ");


function nombrePairImpair(int $nbr): int
{
    if ($nbr % 2 == 0) {
        echo "$nbr est pair";
    } else {
        echo "$nbr est impair";
    }
    return $nbr;
}

nombrePairImpair($nombrePairImpair);
