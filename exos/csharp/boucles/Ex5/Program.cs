// Déclaration d’un unsigned short
ushort valeur = 856;

// Obtenir la taille en octets, puis la convertir en bits
int tailleOctets = sizeof(ushort);
int tailleBits = tailleOctets * 8;

// Affichage de l'entier sous forme binaire
Console.Write("Valeur en binaire : ");
for (int i = tailleBits - 1; i >= 0; i--)
{
    int bit = (valeur >> i) & 1;
    Console.Write(bit);
}

Console.WriteLine();