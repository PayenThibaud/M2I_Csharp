Console.WriteLine("--- Calcul de la TVA ---");
Console.Write("Entrez le prix HT de l'objet (en Euros) : ");
double HT = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez le taux de TVA (en %) : ");
double PTVA = Convert.ToDouble(Console.ReadLine());

double TVA = HT * (PTVA / 100);
double TTC = TVA + HT;
TVA = Math.Round(TVA, 2);
TTC = Math.Round(TTC, 2);

Console.WriteLine("Le montant de la T.V.A est de : " + TVA + " Euros");
Console.WriteLine("Le prix TTC de l'objet est de : " + TTC + " Euros");