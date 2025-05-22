Console.WriteLine("Saisir deux valeurs : ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a == b) {
    Console.WriteLine("Il y a qu'une seule valeur unique.");
} else {
    Console.WriteLine("Il y a deux valeurs uniques");
}