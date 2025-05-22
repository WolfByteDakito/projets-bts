annee = int(input("Saisir une année : "))

if annee % 4 == 0 or annee % 100 != 0 :
    print(annee, " C'est une année bissextile")
else : 
    print(annee, "Ce n'est pas une année bissextile")