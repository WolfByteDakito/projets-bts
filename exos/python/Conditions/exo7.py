photocopies = int(input("Saisir le nombre de photocopies souhaité : "))

if photocopies <= 20 :
    prix = photocopies * 10
    euro = prix % 100 
    print("Pour ", photocopies, "photocopies, il faudra payer ", euro, " €")
else : 
    centimesBase = 200 
    soustraction = photocopies - 20 
    prix1 = soustraction * 8
    totalprix = prix1 + centimesBase
    euro1 = totalprix % 100 
    print("Pour ", photocopies, "photocopies, il faudra payer ", euro1, " €")