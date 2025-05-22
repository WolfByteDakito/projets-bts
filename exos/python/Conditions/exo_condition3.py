a = int(input("Saisir la valeur de A : "))
b = int(input("Saisir la valeur de B : "))
c = int(input("Saisir la valeur de C : "))

delta = b**2+4*a*c

if delta < 0:
     print("Pas de solution réelle")
elif delta == 0:
    x = -b / (2*a)
    print(x)
else:
    x1 = (-b - delta**0.5) / (2*a)
    x2 = (-b + delta**0.5) / (2*a)
    print(x1,x2)
               
