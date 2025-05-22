#Exercice 3 : Écrire un programme qui demande à l'utilisateur de saisir son poids en kilogrammes et sa taille en mètres, puis calcule et affiche son indice de masse corporelle (IMC) selon la formule IMC = poids / (taille * taille). 

# Demander à l'utilisateur de saisir son poids en kilogrammes et sa taille en mètres
poids = input("Entrez votre poids en kilogrammes : ")
taille = input("Entrez votre taille en mètres : ")
# Calculer l'IMC
imc = int(poids) / (int(taille) * int(taille))
#Afficher l'IMC
print("Votre indice de masse corporelle (IMC) est : ", imc)
