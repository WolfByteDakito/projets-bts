Console.WriteLine("Entrer une valeur entière : ");
int n = int.Parse(Console.ReadLine());
int[] t = new int[n];
// vérification de la présence de la valeur n dans le tableau
bool found = false;
for (int i = 0; i < t.Length; i++)
{
    Console.Write(i + " : ");
    t[i] = int.Parse(Console.ReadLine());
    if (t[i] == n)
    {
        Console.WriteLine("La valeur " + n + " est présente dans le tableau à l'index " + i);
        found = true;
    }
}

