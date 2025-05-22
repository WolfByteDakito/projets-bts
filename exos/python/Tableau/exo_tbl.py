N=int(input("Saisissez la taille du tableau : "))
T=[]
for i in range(N):
    T.append(int(input()))
print(T)

for i in range(N):
    T[i]*2
    T.append(i)
print(T)
