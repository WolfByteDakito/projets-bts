Console.Write("Saisir le jour : ");
int jour = int.Parse(Console.ReadLine());

Console.Write("Saisir le mois : ");
int mois = int.Parse(Console.ReadLine());

Console.Write("Saisir l'année : ");
int annee = int.Parse(Console.ReadLine());

// Vérification de la validité des valeurs
if (mois < 1 || mois > 12 || jour < 1 || jour > 31)
{
    Console.WriteLine("Date invalide.");
    return;
}

int nbJours = 31; // Valeur par défaut

// Détermination du nombre de jours dans le mois
if (mois == 4 || mois == 6 || mois == 9 || mois == 11)
{
    nbJours = 30;
}
else if (mois == 2)
{
    // Vérification année bissextile
    if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
    {
        nbJours = 29;
    }
    else
    {
        nbJours = 28;
    }
}

// Vérifie si le jour est valide pour ce mois
if (jour > nbJours)
{
    Console.WriteLine("Jour invalide pour ce mois.");
    return;
}

// Calcul du jour suivant
jour++;
if (jour > nbJours)
{
    jour = 1;
    mois++;
    if (mois > 12)
    {
        mois = 1;
        annee++;
    }
}

Console.WriteLine("Le jour suivant est : " + jour + "/" + mois + "/" + annee);