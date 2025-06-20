// Afficher les éléments d'un tableau dans l'ordre croissant
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

        // Tri du tableau dans l'ordre croissant
        Array.Sort(t);

        // Affichage du tableau trié
        Console.WriteLine("Tableau trié dans l'ordre croissant : " + string.Join(", ", t));
    }
}
