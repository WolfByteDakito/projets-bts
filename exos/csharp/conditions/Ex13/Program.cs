Console.WriteLine("Saisir les coordonnées (i 1 - 8) et (j 1 - 8) :");
int i = int.Parse(Console.ReadLine());
int j = int.Parse(Console.ReadLine());

if (i > 8) {
    Console.WriteLine("(i) ne peut pas être supérieur à 8");
} else if (j > 8) {
    Console.WriteLine("(j) ne peut pas être supérieur à 8");
} else {
    int somme = i + j;
    if (somme%2 == 0) {
        Console.WriteLine("La case est blanche");
    } else {
        Console.WriteLine("La case est noir");
    }
}