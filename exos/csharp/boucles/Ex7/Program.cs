// PARTIE A 
Console.WriteLine("Saisir un nombre entier : ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Valeur du nombre entier : " + a);

// PARTIE B 
if (a >= 0)
{
    Console.WriteLine("Le nombre " + a + " est positif.");
} else {
    Console.WriteLine("Le nombre " + a + " est négatif.");
}

// PARTIE C et D
int somme = 0;

if (a > 0)
{
    for (int i = a; i > 0; i--)
    {
        Console.WriteLine(i + " ");
        somme += i;
    }
}
else
{
    for (int i = a; i < 0; i++)
    {
        Console.WriteLine(i + " ");
        somme += i;
    }
}

Console.WriteLine("La somme des nombres affichés est : " + somme);