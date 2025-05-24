Console.Write("Saisir une valeur n : ");
    int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) // lignes
{
    for (int j = 0; j < n; j++) // colonnes
    {
        Console.Write("X");
    }
    Console.WriteLine(); // retour à la ligne après chaque ligne
}