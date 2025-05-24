// PARTIE A - Saisie des deux nombres
Console.Write("Entrez un premier nombre entier (i) : ");
int i = int.Parse(Console.ReadLine());

Console.Write("Entrez un second nombre entier (j) : ");
int j = int.Parse(Console.ReadLine());

// Comparaison
if (i > j)
{
    Console.WriteLine("Le nombre le plus grand est : " + i);
}
else if (j > i)
{
    Console.WriteLine("Le nombre le plus grand est : " + j);
}
else
{
    Console.WriteLine("Les deux nombres sont égaux.");
}

// PARTIE B - Affichage des valeurs entre i et j
if (i < j)
{
    Console.WriteLine("Valeurs entre " + i + " et " + j + " :");

    for (int k = i + 1; k < j; k++) // on exclut i et j eux-mêmes
    {
        Console.Write(k + " ");
    }

    Console.WriteLine(); // saut de ligne

    // PARTIE C - Affichage des valeurs paires dans l’intervalle
    Console.WriteLine("Valeurs paires entre " + i + " et " + j + " :");

    for (int k = i + 1; k < j; k++)
    {
        if (k % 2 == 0)
        {
            Console.Write(k + " ");
        }
    }

    Console.WriteLine();
}