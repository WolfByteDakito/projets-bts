<?php

$phrase = readline("Saisir une phrase ");
$mot = readline("Saisir un mot : ");
strtolower($phrase);
$nombre_occurence = substr_count($lower, $mot);
echo "le mot '$mot' apparait $nombre_occurence fois dans la phrase";