// Concevez un programme qui demande à l'utilisateur de saisir une chaîne de caractères "t", ainsi que deux indices "i" et "j". Le programme doit ensuite créer une nouvelle chaîne "t'" qui contient la sous-chaîne de "t" allant de l'indice "i" à l'indice "j".
string t;
int i, j;
Console.WriteLine("Veuillez saisir une chaîne de caractères :");
t = Console.ReadLine();
Console.WriteLine("Veuillez saisir l'indice de début (i) :");
i = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez saisir l'indice de fin (j) :");
j = int.Parse(Console.ReadLine());
if (i < 0 || j >= t.Length || i > j)
{
    Console.WriteLine("Indices invalides. Assurez-vous que 0 <= i <= j < longueur de la chaîne.");
}
else
{
    string tPrime = t.Substring(i, j - i + 1);
    Console.WriteLine($"La sous-chaîne de t de l'indice {i} à l'indice {j} est : '{tPrime}'");
}

