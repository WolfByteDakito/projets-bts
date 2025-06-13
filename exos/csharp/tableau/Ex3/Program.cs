Console.WriteLine("Saissisez le nombre valeurs n ");
int n = int.Parse(Console.ReadLine());
int[] t = new int[n];
for (int i = 0; i < t.Length; i++)
{
    Console.Write(i + " : ");
    t[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("La somme des valeurs du tableau est : " + t.Sum());
