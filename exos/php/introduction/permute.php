<?php

$nombre1 = readline("Saisir un nombre (nombre1) : ");
$nombre2 = readline("Saisir un nombre (nombre2) : ");

$temp = $nombre1;
$nombre1 = $nombre2;
$nombre2 = $temp;

echo "nombre1 est égale à $nombre1, nombre2 est égale à $nombre2";