<?php

$nombre = readline("Saisir un nombre aléatoire :");

for ($i = 0; $i <= $nombre; $i += 1) {
    if ($i % 2 == 0) {
        echo $i . " ";
    }
}
