Console.WriteLine("--- Dans quelle catégorie mon enfant est-il... ? ---");
Console.Write("Entrez la longueur du segment AB : ");
string nombreAB = Console.ReadLine();
Console.Write("Entrez la longueur du segment BC : ");
string nombreBC = Console.ReadLine();
Console.Write("Entrez la longueur du segment CA : ");
string nombreCA = Console.ReadLine();

if (double.TryParse(nombreAB, out double AB) &&
    double.TryParse(nombreBC, out double BC) &&
    double.TryParse(nombreCA, out double CA))
{
    if (AB == BC && BC == CA)
    {
        Console.WriteLine("Le Triangle est équilatérale");
    }
    else
    {
        if (AB == CA)
        {
            Console.WriteLine("Le Triangle est isocèle en A, mais n'est pas équilatérale");
        }
        else
        {
            if (AB == BC)
            {
                Console.WriteLine("Le Triangle est isocèle en B, mais n'est pas équilatérale");
            }
            else
            {
                if (CA == BC)
                {
                    Console.WriteLine("Le Triangle est isocèle en C, mais n'est pas équilatérale");
                }
                else
                {
                    Console.WriteLine("Le Triangle n'est pas isocèle ni équilatérale");
                }
            }
        }
    }
}
else
{
    Console.WriteLine("Rentrez des longueurs valides !");
}
