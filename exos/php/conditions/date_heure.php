<?php

$dates = date("d/m/Y");
$times = date("G\hi");
echo "Aujourd'hui nous sommes le $dates\n";
echo "Il est actuellement $times\n";

if (date('H') < 13) {
    echo "Bonne matinée";
} else {
    echo "Bonne après-midi";
}

// "\" Interprète pas //