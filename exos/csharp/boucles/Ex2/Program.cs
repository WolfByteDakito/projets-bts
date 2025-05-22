Console.WriteLine("Saisir un nombre entier :");
int a = int.Parse(Console.ReadLine());
int b = 0;

while (a > 0)
{
    int multiplication = a*b;
    Console.WriteLine("La table de multiplication de " + a + ":" + a + " x " + b++ + " = " + multiplication);
}

Console.WriteLine("\n");