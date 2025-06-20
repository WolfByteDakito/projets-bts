//Enter des valeurs dans un tableau
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrer une valeur entière : ");
        int n = int.Parse(Console.ReadLine());
        int[] t = new int[n];

        // Remplissage du tableau
        for (int i = 0; i < t.Length; i++)
        {
            Console.Write(i + " : ");
            t[i] = int.Parse(Console.ReadLine());
        }
        // Inverser le sens du tableau
        Array.Reverse(t);
        // Affichage du tableau inversé
        Console.WriteLine("Tableau inversé : " + string.Join(", ", t));
    }
}