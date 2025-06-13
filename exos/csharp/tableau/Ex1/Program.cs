int[] t = new int[11];
for (int i = 1; i < t.Length; i++)
{
    Console.Write(i + " : ");
    t[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Les nombres saisis sont :");
foreach (int liste in t)
{
    Console.WriteLine(liste);
}