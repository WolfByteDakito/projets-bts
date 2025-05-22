# TP : Gestion des Horaires d'Ouverture d'un Magasin en Mode Console

## Contexte
Vous devez développer un script PHP en mode console pour gérer et manipuler les horaires d'ouverture et de fermeture d'un magasin. L’objectif est de permettre d’afficher les horaireset de vérifier si le magasin est ouvert à un moment donné.

## Objectifs
- Manipuler les tableaux à deux dimensions.
- Travailler avec des structures conditionnelles et des boucles.
- Créer des sorties claires et organisées en mode console.

## Énoncé
1. **Déclaration des horaires**  
   Déclarez un tableau `$horaires` contenant les heures d'ouverture et de fermeture du magasin pour chaque jour de la semaine :  
   - **Lundi** : Ouvert de 9h00 à 12h30, puis de 14h00 à 18h00.  
   - **Mardi** : Ouvert de 9h00 à 12h30, puis de 14h00 à 18h00.  
   - **Mercredi** : Fermé toute la journée.  
   - **Jeudi** : Ouvert de 10h00 à 13h00, puis de 15h00 à 19h00.  
   - **Vendredi** : Ouvert de 9h00 à 12h30, puis de 14h00 à 18h00.  
   - **Samedi** : Ouvert de 10h00 à 13h00, puis de 14h00 à 17h00.  
   - **Dimanche** : Fermé toute la journée.  
   
   Le tableau doit être structuré pour contenir deux créneaux horaires par jour. Utilisez `"Fermé"` si le magasin ne fonctionne pas.

2. **Affichage des horaires**  
   Créez le code qui parcourt le tableau `$horaires` et affiche dans la console les horaires sous une forme lisible :  

# Horaires d'ouverture du magasin

| Jour       | Matin       | Après-midi |
|------------|-------------|------------|
| Lundi      | 9h-12h30    | 14h-18h    |
| Mardi      | 9h-12h30    | 14h-18h    |
| Mercredi   | Fermé       | Fermé      |
| Jeudi      | 10h-13h     | 15h-19h    |
| Vendredi   | 9h-12h30    | 14h-18h    |
| Samedi     | 10h-13h     | 14h-17h    |
| Dimanche   | Fermé       | Fermé      |


3. **Vérification d'ouverture**  
- Demandez à l’utilisateur d’entrer un **jour de la semaine** (exemple : `Jeudi`) et une **heure** (exemple : `15:20 ou 16:00`).  
- Vérifiez si le magasin est ouvert ou fermé à ce moment-là en parcourant le tableau `$horaires`.  
- Affichez un message dans la console :  
  - Si le magasin est ouvert : `Le magasin est ouvert le jeudi à 15h20.`  
  - Si le magasin est fermé : `Le magasin est fermé le jeudi à 15h20.`

4. **Résumé des jours fermés**  
Identifiez les jours où le magasin est fermé toute la journée et affichez-les :  
Exemple attendu :  
`Le magasin est fermé toute la journée le mercredi et le dimanche.`


## Livrables
- Le fichier PHP contenant le script.
- Exemple d’exécution montrant :  
    - L’affichage complet des horaires.  
    - Une vérification d’ouverture pour plusieurs jours et heures.  
    - Un résumé des jours fermés


