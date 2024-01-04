Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---");
Console.Write("Entrez la longueur d'un coté du carré (en cm) : ");
double nombre = Convert.ToDouble(Console.ReadLine());

double perimetre = nombre * 4;
double aire = nombre * nombre;
Console.WriteLine("Le périmètre du carré est : " + perimetre + " cm");
Console.WriteLine("La somme de ces deux nombre est : " + aire + " cm2");