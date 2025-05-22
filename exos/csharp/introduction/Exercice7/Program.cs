Console.WriteLine("Saisir une valeur (int32) : ");
string? A = Console.ReadLine();
string? B = Console.ReadLine();

int nbr1 = Convert.ToInt32(A);
int nbr2 = Convert.ToInt32(B);

int somme = nbr1 + nbr2;
int diviseur = nbr1;

int quotient = somme / diviseur;

Console.WriteLine("La somme de " + nbr1 + " + " + nbr2 + " est : " + somme);
Console.WriteLine("Le quotient est de " + quotient);