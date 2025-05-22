Console.WriteLine("Saisissez votre âge : ");
int a = int.Parse(Console.ReadLine());

if (a < 18) {
    Console.WriteLine("Vous êtes mineur");
} else {
    Console.WriteLine("Vous êtes majeur");
}
