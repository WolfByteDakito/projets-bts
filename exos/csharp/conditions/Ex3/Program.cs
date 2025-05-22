Console.WriteLine("Saisir les poids de M et k en kilos : ");
float M = float.Parse(Console.ReadLine());
float k = float.Parse(Console.ReadLine());

float div = M / k;
int convert = Convert.ToInt32(div);

Console.WriteLine("Le total de carton sera de : " + convert );