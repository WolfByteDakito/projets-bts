
Console.WriteLine("--- Remplacement de caractères avec string.Replace() ---");

Console.Write("Veuillez entrer une chaîne de caractères (t) : ");
string t = Console.ReadLine();

char a, b;

// Demander et valider le caractère 'a'
while (true)
{
    Console.Write("Veuillez entrer le caractère de remplacement (a) : ");
    string inputA = Console.ReadLine();
    if (inputA.Length == 1)
    {
        a = inputA[0];
        break;
    }
    Console.WriteLine("Entrée invalide. Veuillez saisir un seul caractère.");
}

// Demander et valider le caractère 'b' (doit être distinct de 'a')
while (true)
{
    Console.Write("Veuillez entrer le caractère à remplacer (b) : ");
    string inputB = Console.ReadLine();
    if (inputB.Length == 1)
    {
        b = inputB[0];
        if (a != b)
        {
            break;
        }
        Console.WriteLine("Le caractère à remplacer (b) doit être distinct du caractère de remplacement (a).");
    }
    else
    {
        Console.WriteLine("Entrée invalide. Veuillez saisir un seul caractère.");
    }
}

// Utiliser la méthode Replace pour remplacer toutes les occurrences de 'b' par 'a'
string newT = t.Replace(b, a);

Console.WriteLine($"La chaîne originale est : {t}");
Console.WriteLine($"La nouvelle chaîne après remplacement est : {newT}");
    

