Console.WriteLine("--- Extraction de sous-chaîne avec StringBuilder.Insert() ---");

Console.Write("Veuillez saisir une chaîne de caractères (t) : ");
string t = Console.ReadLine();

int i, j;

// Demander et valider l'indice de début
while (true)
{
    Console.Write("Veuillez saisir l'indice de début (i) : ");
    if (int.TryParse(Console.ReadLine(), out i) && i >= 0 && i < t.Length)
    {
        break;
    }
    Console.WriteLine("Indice de début invalide. Il doit être un nombre entier non négatif et inférieur à la longueur de la chaîne.");
}

// Demander et valider l'indice de fin
while (true)
{
    Console.Write("Veuillez saisir l'indice de fin (j) : ");
    if (int.TryParse(Console.ReadLine(), out j) && j >= 0 && j < t.Length && j >= i)
    {
        break;
    }
    Console.WriteLine("Indice de fin invalide. Il doit être un nombre entier non négatif, inférieur à la longueur de la chaîne et supérieur ou égal à l'indice de début.");
}

StringBuilder tPrimeBuilder = new StringBuilder();

// Construire la nouvelle chaîne t' en insérant chaque caractère de la sous-chaîne
for (int k = i; k <= j; k++)
{
    tPrimeBuilder.Insert(tPrimeBuilder.Length, t[k]);
}

string tPrime = tPrimeBuilder.ToString();
Console.WriteLine($"La nouvelle chaîne (t') est : {tPrime}");
    

