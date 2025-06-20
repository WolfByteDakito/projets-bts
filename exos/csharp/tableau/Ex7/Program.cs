// Sollicitez l'utilisateur pour qu'il entre une valeur x, puis fournissez-lui la liste des indices i pour lesquels T[i] est égal à x 
using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrer une valeur entière : ");
        int x = int.Parse(Console.ReadLine());
        int[] t = new int[10]; // Exemple de taille de tableau

        // Remplissage du tableau
        for (int i = 0; i < t.Length; i++)
        {
            Console.Write(i + " : ");
            t[i] = int.Parse(Console.ReadLine());
        }

        // Recherche des indices où T[i] est égal à x
        var indices = t.Select((value, index) => new { value, index })
                       .Where(pair => pair.value == x)
                       .Select(pair => pair.index)
                       .ToList();

        if (indices.Count > 0)
        {
            Console.WriteLine("La valeur " + x + " est présente aux indices : " + string.Join(", ", indices));
        }
        else
        {
            Console.WriteLine("La valeur " + x + " n'est pas présente dans le tableau.");
        }
    }
}