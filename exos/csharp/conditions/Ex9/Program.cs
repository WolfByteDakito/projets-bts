Console.WriteLine("Saisir trois valeurs : ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a < b && a < c) {
    Console.WriteLine("La plus petite valeur est " + a);    
} else if (b < a && b < c) {
    Console.WriteLine("La plus petite valeur est " + b); 
} else {
    Console.WriteLine("La plus petite valeur est " + c); 
}