<?php

function convertirCelsiusFahrenheit(int $nombre): int
{
    $calcul = $nombre * 1.8 + 32;
    return $calcul;
}

echo convertirCelsiusFahrenheit(20);
echo PHP_EOL;

function genererNumeroAdhérent($numero)
{
    $numeroFormate = str_pad($numero, 6, '0', STR_PAD_LEFT);
    return   "AD-" . $numeroFormate;
}

echo genererNumeroAdhérent(587423);
