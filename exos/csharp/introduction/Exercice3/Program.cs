// Programme qui échange les deux variables A et B à l'éxecution du programme
Console.WriteLine("Saisir des valeurs (A, B) : ");
string? A =  Console.ReadLine(); // Saisir un prénom "Alexis"
string? B =  Console.ReadLine(); // Saisir un prénom "Théo"
string? C; // Valeur nulle 

C = A; // C prend pour valeur "Alexis"
A = B; // A prend pour valeur "Théo"
B = C; // B prend pour valeur "Alexis"


Console.WriteLine(A + " Variable B " + B  + " Variable A "); // Echange des variables opérationnel