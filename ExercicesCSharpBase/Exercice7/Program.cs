Console.WriteLine("--- Calcul de la longueur de l'hypothènuse ---");
Console.Write("Entrez la longueur du premier coté (en cm) : ");
double nombre1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entrez la longueur du deuxième coté (en cm) : ");
double nombre2 = Convert.ToDouble(Console.ReadLine());

nombre1 = Math.Pow(nombre1, 2);
nombre2 = Math.Pow(nombre2, 2);
double Hypo = nombre1 + nombre2;
Hypo = Math.Sqrt(Hypo);
Console.WriteLine("La longueur de l'hypothénuse est : " + Hypo + " cm");
