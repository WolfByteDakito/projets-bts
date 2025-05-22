<?php

$produitA = readline("Saisir le prix du produit A :");
$produitB = readline("Saisir le prix du produit B :");

if ($produitA < $produitB) {
    echo "Le produit A est moins cher";
} elseif ($produitB < $produitA) {
    echo "le produit B est moins cher";
} else {
    echo "Les deux produits ont le même prix";
}
