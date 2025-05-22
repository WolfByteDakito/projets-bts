<?php

$livres = ["Le Petit Prince", "1984", "Les Misérables", "Le Rouge et le Noir", "Harry Potter"];


foreach ($livres as $titre) {
    if (strlen($titre) > 10) {
        echo "$titre";
    }
}
