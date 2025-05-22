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

// Demander à l'utilisateur de saisir un id étudiant
$idEtudiant = readline("Saisir un id etudiant : ");

// Récupérer un etudiant connaissant son id (id_etudiant)
$requeteSQL = "SELECT * FROM etudiants WHERE id_etudiant = :id";
// Préparer la requête PDO 
$requetePDO = $connexionBDD->prepare($requeteSQL);
// Donner une valeur au paramètre :id 
$requetePDO->bindValue("id", $idEtudiant);
// Exécuter la requête 
$requetePDO->execute();
// Récupérer le résultat de la requête dans un tableau associatif 
$requetePDO->setFetchMode(PDO::FETCH_ASSOC);
$etudiant = $requetePDO->fetch(); // fetch() un seul résultat fetchAll() plusieurs résultats 
// Tester si l'étudiant existe ou pas 
if ($etudiant) {
    // Le tableau n'est pas vide
    echo $etudiant["prenom_etudiant"] . " " . $etudiant["nom_etudiant"];
} else {
    echo "Etudiant non trouvé !";
}
