Console.WriteLine("Saisir une valeur numérique : ");
int valeur = int.Parse(Console.ReadLine());
int absolue = Math.Abs(valeur);

if (absolue < 0) {
    Console.WriteLine("La valeur numérique n'est pas correcte");
} else {
    Console.WriteLine("La valeur absolue est : " + absolue);
}
