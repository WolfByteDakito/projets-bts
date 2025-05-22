<?php

// 1. Définir les informations de connexion à la BDD db_etudiants

$hostname = "localhost:3306";
$nomBDD = "db_etudiants";
$login = "root";
$password = "";
// 2. Créer la connexion avec la BDD
// Utiliser PDO
try {
    $connexionBDD = new PDO("mysql:host=$hostname;dbname=$nomBDD;charset=utf8", $login, $password);
} catch (PDOException $erreur) {
    die("Erreur de connexion");
}
echo "Connexion établie!";
echo PHP_EOL;
// Récupérer un etudiant connaissant son id (id_etudiant)
$requeteSQL = "SELECT * FROM etudiants AS E, promotions AS P WHERE E.id_promotions=P.id_promotions";
// Préparer la requête PDO 
$requetePDO = $connexionBDD->prepare($requeteSQL);
// Exécuter la requête 
$requetePDO->execute();
// Récupérer le résultat de la requête dans un tableau associatif 
$requetePDO->setFetchMode(PDO::FETCH_ASSOC);
$etudiant = $requetePDO->fetch(); // fetch() un seul résultat fetchAll() plusieurs résultats 
// Tester si l'étudiant existe ou pas 
if ($etudiant) {
    // Le tableau n'est pas vide
    echo $etudiant["prenom_etudiant"] . " " . $etudiant["nom_etudiant"] . " " . $etudiant["libelle_promotion"];
} else {
    echo "Etudiant non trouvé !";
}
