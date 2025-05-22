Console.WriteLine("Saisir votre note obtenue : ");
float note = float.Parse(Console.ReadLine());

if (note < 8) {
    Console.WriteLine("ajourné");
} else if (note <= 8 || note <= 10) {
    Console.WriteLine("rattrapage");
} else {
    Console.WriteLine("admis");
}
