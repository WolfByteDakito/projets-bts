Console.WriteLine("Saisir des valeurs (float) : ");
float valeur1 = float.Parse(Console.ReadLine());
float valeur2 = float.Parse(Console.ReadLine());
float valeur3 = float.Parse(Console.ReadLine());

float moyenne = (valeur1 + valeur2 + valeur3) / 3;

Console.WriteLine("La moyenne est de " + moyenne);