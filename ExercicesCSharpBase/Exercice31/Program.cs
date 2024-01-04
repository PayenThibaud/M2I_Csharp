double bon = 0;
double nul = 20;
double moyenne = 0;
int i = 0;
while (i >= 0)
{
    Console.WriteLine("--- Gestion des notes avec menu ---");
    Console.WriteLine("");
    Console.WriteLine("\t a) Saisir les notes");
    Console.WriteLine("\t b) La plus grande note");
    Console.WriteLine("\t c) La plus petite note");
    Console.WriteLine("\t d) La moyenne des notes");
    Console.WriteLine("\t e) Quitter");
    Console.WriteLine("");
    Console.Write("Faites votre choix : ");
    Console.WriteLine("");

    string rep = Console.ReadLine().ToLower();
    while (rep != "a" && rep != "b" && rep != "c" && rep != "d" && rep != "e")
    {
        Console.WriteLine("Saisie invalide ! Recommence");
        rep = Console.ReadLine().ToLower();
    }

    if (rep == "a")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- Saisir les notes ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.Write("combien de note à saisir ? ");
        double nombreDeNote;
        while (!double.TryParse(Console.ReadLine(), out nombreDeNote))
            Console.WriteLine("Saisie invalide ! Recommence");

        for (int j = 1; j <= nombreDeNote; j++)
        {
            Console.Write($"\t- Merci de saisir la note {j} (sur /20) : ");
            double nombre;
            while (!double.TryParse(Console.ReadLine(), out nombre) || nombre > 20 || nombre < 0)
                Console.Write($"Saisie invalide ! Recommence \n \t- Merci de saisir la note {j} (sur /20) : ");

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
        moyenne = moyenne / nombreDeNote;

        Console.WriteLine("");
    }

    if (rep == "b")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- La plus grande note ---");
        Console.WriteLine("");
        Console.WriteLine("La note la plus grande est :" + bon);
        Console.WriteLine("");
        Console.ResetColor();
    }

    if (rep == "c")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("--- La plus petite note ---");
        Console.WriteLine("");
        Console.WriteLine("La note la plus petite est :" + nul);
        Console.WriteLine("");
        Console.ResetColor();
    }

    if (rep == "d")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("--- La moyenne des notes ---");
        Console.WriteLine("");
        Console.WriteLine("La moyenne est de :" + moyenne);
        Console.WriteLine("");
        Console.ResetColor();
    }

    if (rep == "e")
    {
        break;
    }
}
