a = int(input("Saisir valeur de A : "))
b = int(input("Saisir valeur de B : "))
c = int(input("Saisir valeur de C : "))

delta = b**2 - 4*a*c

if delta > 0:
    x1 = (-b - delta) / (2 * a)
    x2 = (-b + delta) / (2 * a)
    print("Deux solutions réelles : x1 = {x1}, x2 = {x2}")
elif delta == 0:
    x = -b / (2 * a)
    print("Une solution réelle : x = {x}")
else:
    print("Pas de solution")