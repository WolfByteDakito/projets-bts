<?php

// Récupérer la liste des étudiants dans la BDD db_etudiants
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
// Exprimer la requête SQL
$requeteSQL = "SELECT * FROM etudiants";
// Préparer la requête
// PDO va transformer cette requête
$requetePDO = $connexionBDD->prepare($requeteSQL);
// PDO va exécuter la requête :
// - PDO va envoyer la requête à MYSQL 
// - MYSQL va exécuter la requête reçue
// - MYSQL va renvoyer à PDO le résultat de la requête
$requetePDO->execute();
// PDO a récuperé le resultat de la requête
// Le résultat est sous une forme "brute" : non exploitable en PHP
// Demander à PDO de nous retourner le résultat sous la forme d'un tableau
// Chaque enregistrement sous la forme d'un tableau associatif
$requetePDO->setFetchMode(PDO::FETCH_ASSOC);
$etudiant = $requetePDO->fetchAll();
// $etudiant est un tableau contenant le résultat de la requête
print_r($etudiant);
