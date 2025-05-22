<?php

$livres = ["Le Petit Prince", "1984", "Les Misérables", "Le Rouge et le Noir", "Harry Potter"];

$motARemplacer = readline("Entrez le mot à remplacer : ");
$motDeRemplacement = readline("Entrez le mot de remplacement : ");

foreach ($livres as $titre) {

    $titreModifie = str_ireplace($motARemplacer, $motDeRemplacement, $titre);
    echo "$titreModifie";
}
