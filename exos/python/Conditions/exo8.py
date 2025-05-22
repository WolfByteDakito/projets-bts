heure = int(input("Saisir l'heure : "))
minute = int(input("Saisir minutes : "))

if heure == 24 or minute == 60 : 
    heure = 00
    minute = 0
    somme = minute + 1 
    print("Dans une minute, il sera ", heure,  "heure(s)", somme,".")
else : 
    somme1 = minute + 1
    print("Dans une minute, il sera ", heure,  "heure(s)", somme1,".")