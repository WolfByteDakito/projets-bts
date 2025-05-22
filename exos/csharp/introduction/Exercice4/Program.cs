Console.WriteLine("Saisir des valeurs (A,B,C,D): ");
string? A = Console.ReadLine();
string? B = Console.ReadLine();
string? C = Console.ReadLine();
string? D = Console.ReadLine();
string? E;


string? before = A + B + C + D;

Console.WriteLine("Valeurs avant la permutation : " + before);

E = A; // E prend pour valeur 1
A = C; // A prend pour valeur 3 
C = E; // C prend pour valeur 1
E = B; // F prend pour valeur 2
B = D; // B prend pour valeur 4
D = E; // D prend pour valeur 2

string? after = A + B + C + D;

Console.WriteLine("Valeurs après la permutation : " + after);