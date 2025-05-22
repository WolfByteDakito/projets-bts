<?php

$notes = [

    "Alexis" => 12,
    "Thomas" => 15,
    "Emilien" => 4

];

$notes["Alexis"] = 18;
$notes["Emilien"] = 1;

$notes["Julie"] = 20;


foreach ($notes as $key => $value) {
    echo "$key total : $value ";
};
