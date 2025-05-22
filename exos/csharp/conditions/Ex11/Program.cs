Console.WriteLine("Saisir trois valeurs : ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if ( a == b && b == c ) {
    Console.WriteLine("Il y a qu'une seule valeur unique");
} else if (a == b || a == c || b == c) {
    Console.WriteLine("Il y a deux valeurs uniques");
} else {
    Console.WriteLine("Il y a trois valeurs uniques");
}