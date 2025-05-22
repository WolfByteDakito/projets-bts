Console.WriteLine("Saisir les coordonnées (i 1 - 8) et (j 1 - 8) :");
int i = int.Parse(Console.ReadLine());
int j = int.Parse(Console.ReadLine());

Console.WriteLine("Saisir les coordonnées (i' 1 - 8) et (j' 1 - 8) :");
int iprime = int.Parse(Console.ReadLine());
int jprime = int.Parse(Console.ReadLine());

int Icalc = Math.Abs(i - iprime); // X 
int Jcalc = Math.Abs(j - jprime); // Y 

if (i > 8 && iprime > 8) {
    Console.WriteLine("(i) et (i') ne peut pas être supérieur à 8");
} else if (j > 8 && jprime > 8) {
    Console.WriteLine("(j) et (j') ne peut pas être supérieur à 8");
} else {
    if (Icalc == 2 && Jcalc == 1 || Icalc == 1 && Jcalc == 2) {
        Console.WriteLine("Ce coup est jouable par le cavalier");
    } else {
        Console.WriteLine("Ce coup n'est pas jouable par le cavalier");
    }
}