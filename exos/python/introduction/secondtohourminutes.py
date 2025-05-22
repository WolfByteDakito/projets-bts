#Exercice 6 : Écrire un programme qui demande à l'utilisateur de saisir une durée en secondes, puis convertit cette durée en heures, minutes et secondes.
# Demander à l'utilisateur de saisir une durée en secondes
secondes = int(input("Entrez le nombre de secondes : "))
# Convertir la durée en heures, minutes et secondes
heures = secondes // 3600
minutes = (secondes % 3600) // 60
secondes_restantes = secondes % 60
# Afficher le résultat
print("La durée totale est : ", heures, "heures,", minutes, "minutes et", secondes_restantes, "secondes.")