#Exercice 4 : Écrire un programme qui demande à l'utilisateur de saisir une série de notes. 
# Le programme va demander 3 notes pour calculer la moyenne.
notes = int(input("Entrez la première note : "))
notes1 = int(input("Entrez la première note : "))
notes2 = int(input("Entrez la première note : "))
#calculer la moyenne
moyenne = (notes + notes1 + notes2) / 3
#afficher la moyenne
print("La moyenne des notes est : ", moyenne)