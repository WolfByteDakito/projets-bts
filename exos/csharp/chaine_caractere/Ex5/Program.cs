using System;
using System.Text;

public class ReplaceCharactersInStringBuilder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Remplacement de caractères dans StringBuilder sans Replace() ---");

        Console.Write("Veuillez entrer une chaîne de caractères pour votre StringBuilder (t) : ");
        StringBuilder t = new StringBuilder(Console.ReadLine());

        char a, b;

        // Demander et valider le caractère 'a'
        while (true)
        {
            Console.Write("Veuillez entrer le caractère de remplacement (a) : ");
            string inputA = Console.ReadLine();
            if (inputA.Length == 1)
            {
                a = inputA[0];
                break;
            }
            Console.WriteLine("Entrée invalide. Veuillez saisir un seul caractère.");
        }

        // Demander et valider le caractère 'b' (doit être distinct de 'a')
        while (true)
        {
            Console.Write("Veuillez entrer le caractère à remplacer (b) : ");
            string inputB = Console.ReadLine();
            if (inputB.Length == 1)
            {
                b = inputB[0];
                if (a != b)
                {
                    break;
                }
                Console.WriteLine("Le caractère à remplacer (b) doit être distinct du caractère de remplacement (a).");
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez saisir un seul caractère.");
            }
        }

        Console.WriteLine($"StringBuilder original : {t}");

        // Parcourir le StringBuilder et remplacer les caractères manuellement
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == b)
            {
                t[i] = a; // Modifie directement le caractère à l'indice i
            }
        }

        Console.WriteLine($"StringBuilder modifié : {t}");
    }
}