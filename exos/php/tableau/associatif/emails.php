<?php

$emails = [

    "alexis"  =>  "@free.fr",
    "lola" =>  "@free.fr",
    "jonathan" =>  "@gmail.com",
    "axel" =>  "@gmail.com",
    "ethann" =>  "@laposte.net"

];

$domaines = readline("Saisir un nom de domaine : ");


foreach ($emails as $name => $domaine) {
    if ($domaines == $domaine) {
        echo $name;
        echo PHP_EOL;
    }
}
