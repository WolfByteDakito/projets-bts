x = 5
y = 7
z = 1

# Utilisation de conditions pour déterminer le maximum
if x >= y and x >= z:
    max_nombre = x
elif y >= x and y >= z:
    max_nombre = y
else:
    max_nombre = z

print(max_nombre)