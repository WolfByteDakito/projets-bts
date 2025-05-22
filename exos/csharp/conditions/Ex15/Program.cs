Console.WriteLine("Quelle pièce souhaitez-vous déplacer ?");
    Console.WriteLine("0 = Cavalier");
    Console.WriteLine("1 = Tour");
    Console.WriteLine("2 = Fou");
    Console.WriteLine("3 = Dame");
    Console.WriteLine("4 = Roi");
    int piece = int.Parse(Console.ReadLine());

    Console.WriteLine("Saisir les coordonnées de départ (i entre 1 et 8, j entre 1 et 8) :");
    int i = int.Parse(Console.ReadLine());
    int j = int.Parse(Console.ReadLine());

    Console.WriteLine("Saisir les coordonnées d’arrivée (i' entre 1 et 8, j' entre 1 et 8) :");
    int iprime = int.Parse(Console.ReadLine());
    int jprime = int.Parse(Console.ReadLine());

    // Vérifie si les coordonnées sont valides
    if (i < 1 || i > 8 || j < 1 || j > 8 || iprime < 1 || iprime > 8 || jprime < 1 || jprime > 8)
    {
        Console.WriteLine("Les coordonnées doivent être comprises entre 1 et 8.");
        return;
    }

    int Icalc = Math.Abs(i - iprime);
    int Jcalc = Math.Abs(j - jprime);

    switch (piece)
    {
        case 0: // Cavalier
            if ((Icalc == 2 && Jcalc == 1) || (Icalc == 1 && Jcalc == 2))
            {
                Console.WriteLine($"Déplacement valide du cavalier de ({i}, {j}) vers ({iprime}, {jprime})");
            }
            else
            {
                Console.WriteLine("Ce coup n'est pas valide pour un cavalier.");
            }
            break;

        case 1: // Tour
            if (i == iprime || j == jprime)
            {
                Console.WriteLine($"Déplacement valide de la tour de ({i}, {j}) vers ({iprime}, {jprime})");
            }
            else
            {
                Console.WriteLine("Ce coup n'est pas valide pour une tour.");
            }
            break;

        case 2: // Fou
            if (Icalc == Jcalc)
            {
                Console.WriteLine($"Déplacement valide du fou de ({i}, {j}) vers ({iprime}, {jprime})");
            }
            else
            {
                Console.WriteLine("Ce coup n'est pas valide pour un fou.");
            }
            break;

        case 3: // Dame
            if (i == iprime || j == jprime || Icalc == Jcalc)
            {
                Console.WriteLine($"Déplacement valide de la dame de ({i}, {j}) vers ({iprime}, {jprime})");
            }
            else
            {
                Console.WriteLine("Ce coup n'est pas valide pour une dame.");
            }
            break;

        case 4: // Roi
            if (Icalc <= 1 && Jcalc <= 1)
            {
                Console.WriteLine($"Déplacement valide du roi de ({i}, {j}) vers ({iprime}, {jprime})");
            }
            else
            {
                Console.WriteLine("Ce coup n'est pas valide pour un roi.");
            }
            break;

        default:
            Console.WriteLine("Pièce inconnue. Veuillez entrer un nombre entre 0 et 4.");
            break;
    };