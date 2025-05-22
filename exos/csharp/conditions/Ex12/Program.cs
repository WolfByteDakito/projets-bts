Console.WriteLine("Saisir des nombres entiers (a b) et un opérateur (+, -, * ou /): ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
string? op = Console.ReadLine();

if (op == "+") {
    int somme = a + b;
    Console.WriteLine("somme : " + somme);
} else if (op == "-") {
    int soustraction = a - b;
    Console.WriteLine("soustraction : " + soustraction);
} else if (op == "*") {
    int multiplication = a * b;
    Console.WriteLine("multiplication : " + multiplication);
} else {
    int division = a / b;
    if (division <= 0) {
        Console.WriteLine("Une division ne peut pas être inférieur ou égale à zéro");
    } else {
        Console.WriteLine("division : " + division);
    }
}



