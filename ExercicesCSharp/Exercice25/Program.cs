double bon = 0;
double nul = 20;
double moyenne = 0;
int error = 0;

Console.WriteLine("--- Gestion des notes ---");
Console.WriteLine("");
Console.Write("combien de note à saisir ? ");
string nbnote = Console.ReadLine();
Console.WriteLine("");
if (double.TryParse(nbnote, out double nbNote))
{
    for (int i = 1; i <= nbNote; i++)
    {
        Console.Write($"\t- Merci de saisir la note {i} (sur /20) : ");
        string nb = Console.ReadLine();

        if (double.TryParse(nb, out double nombre))
        {
            if (nombre <= 20 && nombre >= 0)
            {

                if (bon < nombre)
                {
                    bon = nombre;
                }

                if (nul > nombre)
                {
                    nul = nombre;
                }

                moyenne = moyenne + nombre;

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Données entrées invalides");
                error++;
                break;
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Données entrées invalides");
            error++;
            break;
        }
    }
    moyenne = Math.Round(moyenne / nbNote, 2);

    if (error == 1)
    {
        Console.WriteLine("Vous avez mis une note impossible !");
    }
    else
    {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("La meilleure note est " + bon);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("La moins bonne note est " + nul); 
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("La moyenne des notes est " + moyenne); 
    }
}
else
{
    Console.WriteLine("Données entrées invalides");
}