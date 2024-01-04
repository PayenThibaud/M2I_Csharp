Console.WriteLine("--- Calcul des intérêts ---");
Console.Write("Entrez Capital de départ (en Euros) : ");
double capital = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez le taux d'intérêt (en %) : ");
double interet = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la durée de l'épargne (en années) : ");
double duree = Convert.ToDouble(Console.ReadLine());

double montant = Math.Round((capital * Math.Pow((1 + interet / 100), duree) - capital), 2);
double CapF = montant + capital;

Console.WriteLine("Le montant des intérêts sera de : " + montant + " Euros");
Console.WriteLine("Le capital final sera de : " + CapF + " Euros");