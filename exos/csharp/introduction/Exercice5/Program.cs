Console.WriteLine("Saisir des valeurs (A,B,C,D,E): ");
string? A = Console.ReadLine();
string? B = Console.ReadLine();
string? C = Console.ReadLine();
string? D = Console.ReadLine();
string? E = Console.ReadLine();
string? F;
string? G;

string? before = A + B + C + D + E;

Console.WriteLine("Valeurs avant la permutation : " + before);

F = A; // F prend pour valeur 1
A = D; // A prend pour valeur 4
D = F; // D prend pour valeur 1
F = E; // F prend pour valeur 5
E = B; // E prend pour valeur 2
G = C; // G prend pour valeur 3
C = F; // C prend pour valeur 5
B = G; // B prend pour valeur 3

string? after = A + B + C + D + E;

Console.WriteLine("Valeurs après la permutation : " + after);