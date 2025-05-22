<?php

$prenom = readline("Saisir un prénom : ");
$nom = readline("Saisir un nom : ");

$InitialeP = substr($prenom, 0,1);
$InitialeN = substr($nom, 0,1);  

$prenom = strtoupper($InitialeP);
$nom = strtoupper($InitialeN);

echo "$prenom$nom" ;

