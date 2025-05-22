x = int(input("Saisir X : "))
y = int(input("Saisir Y : "))
z = int(input("Saisir Z : "))

if x < y and y < z : 
    print("1 ", x,y,z)
elif y > z and x < z :
    print("3 ", x,z,y)
elif y < z and x > z :
    print("4 ", y,z,x)
else :
    print("2 ", z,y,x)