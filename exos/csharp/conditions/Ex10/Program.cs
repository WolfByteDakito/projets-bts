Console.WriteLine("Saisir trois valeurs : ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a == b || a == c) {
    Console.WriteLine(a + " est en doublon");
} else if (b == a || b == c) {
    Console.WriteLine(b + " est en doublon");
}  else {
    Console.WriteLine("Il n'y a pas de doublon");
}
