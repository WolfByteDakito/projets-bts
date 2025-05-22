#Exercice 5 : Écrire un programme qui demande à l'utilisateur de saisir une durée en heures, minutes et secondes, puis convertit cette durée en secondes.
# Demander à l'utilisateur de saisir une durée en heures, minutes et secondes
heures = int(input("Entrez le nombre d'heures : "))
minutes = int(input("Entrez le nombre de minutes : "))
secondes = int(input("Entrez le nombre de secondes : "))
# Convertir la durée en secondes
total_secondes = heures * 3600 + minutes * 60 + secondes
# Afficher le résultat
print("La durée totale en secondes est : ", total_secondes)
