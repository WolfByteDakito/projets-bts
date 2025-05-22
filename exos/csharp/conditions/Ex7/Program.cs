Console.WriteLine("Saisir le montant des dommages : ");
double dommages = double.Parse(Console.ReadLine());
double franchise = dommages * 0.10; // 10% des dommages
double rembourse = dommages - franchise;

if (franchise > 4000) {
    double franchises = 4000;
    double remboursement = dommages - franchises;
    Console.WriteLine("La valeur du montant remboursé est : " + remboursement + " €");
    Console.WriteLine("La valeur de la franchise est de " + franchises + " €");
} else {
    Console.WriteLine("La valeur du montant remboursé est : " + rembourse + " €");
    Console.WriteLine("La valeur de la franchise est de " + franchise + " €");
}

