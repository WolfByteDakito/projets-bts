a = int(input("Saisir A : "))
b = int(input("Saisir B : "))
c = int(input("Saisir C : "))

if a + b > c and a + c > b and b + c > a:
    print("C'est un triangle valide")
else:
    print("Ce n'est pas un triangle")

