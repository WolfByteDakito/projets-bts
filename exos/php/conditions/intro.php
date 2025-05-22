<?php

// demande à l'utilisateur de saisir un nombre  (positif ou négatif)
// Afficher si le nombre saisie est positif ou négatif

$Nbr = readline("Saisir un nombre : ");

if ($Nbr >= 0) {
    echo "$Nbr est positif";
} else {
    echo "$Nbr est négatif";
}
