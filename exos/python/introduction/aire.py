# Exercice 2 : Écrire un programme qui demande à l'utilisateur de saisir la longueur et la largeur d'un rectangle, puis calcule et affiche son aire.
# Demander à l'utilisateur de saisir la longueur et la largeur du rectangle 
longueur = input("Entrez la longueur du rectangle : ")
largeur = input("Entrez la largeur du rectangle : ")
# Calculer l'aire du rectangle
aire = float(longueur) * float(largeur)
#Afficher l'aire
print("L'aire du rectangle est : ", aire)
# Calculer son perimètre
perimetre = 2 * (float(longueur) + float(largeur))
#Afficher le périmètre
print("Le périmètre du rectangle est : ", perimetre)