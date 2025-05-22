Console.WriteLine("Saisir des valeurs (A,B,C,D,E,F): ");
string? A = Console.ReadLine();
string? B = Console.ReadLine();
string? C = Console.ReadLine();
string? D = Console.ReadLine();
string? E = Console.ReadLine();
string? F = Console.ReadLine();
string? G;
string? H;

string? before = A + B + C + D + E + F;

Console.WriteLine("Valeurs avant la permutation : " + before);

G = A; // G prend pour valeur 1 
H = B; // H prend pour valeur 2 
A = C; // A prend pour valeur 3 
B = D; // B prend pour valeur 4
D = G; // D prend pour valeur 1
G = F; // G prend pour valeur 6 
F = H; // F prend pour valeur 2
H = E; // H prend pour valeur 5
C = H; // C prend pour valeur 5
E = G; // E prend pour valeur 6

string? after = A + B + C + D + E + F;

Console.WriteLine("Valeurs après la permutation : " + after);
