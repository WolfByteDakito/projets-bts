Console.WriteLine("Saisir une longueur (int32) en cm² : ");
int longueur = int.Parse(Console.ReadLine());
Console.WriteLine("Saisir une largeur (int32) en cm² : ");
int largeur = int.Parse(Console.ReadLine());

int surface = longueur * largeur;

Console.WriteLine("La surface de ce rectangle est de " + surface + " cm²");