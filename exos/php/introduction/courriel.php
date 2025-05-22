<?php

$prenom = readline("Saisir un prénom : ");
$nom = readline("Saisir un nom : ");
$mail = "societe.com";

$NbrNom = strlen($nom);

$email = "$prenom.$nom$NbrNom@$mail";

echo "Votre adresse email est $email";
