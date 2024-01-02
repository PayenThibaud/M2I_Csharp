int nombreDeValeur =0;
string[] t1 = {};
int i = 0;
while (i >= 0)
{
    Console.WriteLine("--- Ma liste de contacts ---");
    Console.WriteLine("");
    Console.WriteLine("\t a) Saisir des contacts");
    Console.WriteLine("\t b) Affichez mes contacts");
    Console.WriteLine("\t c) Quitter");
    Console.WriteLine("");
    Console.Write("Faites votre choix : ");
    Console.WriteLine("");

    string rep = Console.ReadLine().ToLower();
    while (rep != "a" && rep != "b" && rep != "c")
    {
        Console.WriteLine("Saisie invalide ! Recommence");
        rep = Console.ReadLine().ToLower();
    }

    if (rep == "a")
    {
        Console.Clear();
        Console.WriteLine("--- Gestion des contacts --- ");
        Console.WriteLine("Merci de saisir le nombre de contact ?");

        while (!int.TryParse(Console.ReadLine(), out nombreDeValeur))
            Console.WriteLine($"Saisie invalide ! Recommence \ncombien de valeur voulez vous saisir ? ");
        t1 = new string[nombreDeValeur];

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- Saisir les contacts ---");
        Console.ResetColor();

        for (int j = 0; j <= nombreDeValeur-1; j++)
        {
            Console.Write($"Nom et prénom du contact N°{j+1} : ");
            t1[j] = Console.ReadLine();
        }


        Console.WriteLine("");
    }

    if (rep == "b")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- Affichage des contacts ---");
        Console.ResetColor();
        for (int j = 0; j <= nombreDeValeur - 1; j++)
        {
            Console.WriteLine($"\t -Contact N°{j+1} : {t1[j]}");
        }
        Console.WriteLine("");
    }

    if (rep == "c")
    {
        break;
    }
}