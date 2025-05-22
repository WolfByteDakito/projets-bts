Console.WriteLine("Saisir les valeurs de M (poids d'un camion) et k (poid d'un carton) (float) : ");
float M = float.Parse(Console.ReadLine());
float k = float.Parse(Console.ReadLine());

float div = M / k;
int convert = Convert.ToInt32(div);

Console.WriteLine("Le nombre de carton sera de " + convert);

