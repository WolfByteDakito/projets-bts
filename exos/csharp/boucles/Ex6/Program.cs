using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entrez une valeur de type unsigned short : ");
        ushort valeur = ushort.Parse(Console.ReadLine());

        // Taille en bits
        int tailleBits = sizeof(ushort) * 8;

        // Affichage initial
        Console.Write("Binaire original : ");
        AfficherBinaire(valeur, tailleBits);

        // Inversion des bits
        ushort valeurInversee = InverserBits(valeur, tailleBits);

        // Affichage résultat inversé
        Console.Write("Binaire inversé  : ");
        AfficherBinaire(valeurInversee, tailleBits);
    }

    static void AfficherBinaire(ushort valeur, int tailleBits)
    {
        for (int i = tailleBits - 1; i >= 0; i--)
        {
            int bit = (valeur >> i) & 1;
            Console.Write(bit);
        }
        Console.WriteLine();
    }

    static ushort InverserBits(ushort valeur, int tailleBits)
    {
        ushort resultat = 0;

        for (int i = 0; i < tailleBits; i++)
        {
            int bit = (valeur >> i) & 1;
            resultat = (ushort)((resultat << 1) | bit);
        }

        return resultat;
    }
}

