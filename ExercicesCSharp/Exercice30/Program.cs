Console.WriteLine("--- Question à choix multiple ---");
Console.WriteLine("");
Console.WriteLine("Quelle est l'instruction qui permet de sortir d'une boucle en C# ? ");
Console.WriteLine("\t a) quit");
Console.WriteLine("\t b) continue");
Console.WriteLine("\t c) exit");
Console.WriteLine("\t d) break");
Console.WriteLine("");

int i = 0;
while (i >= 0)
{
    Console.Write("Entrez votre réponse: ? ");
    Console.WriteLine("");

    string rep = Console.ReadLine().ToLower();
    while (rep != "a" && rep != "b" && rep != "c" && rep != "d")
    {
        Console.WriteLine("Saisie invalide ! Recommence");
        rep = Console.ReadLine().ToLower();
    }

    if (rep == "a" || rep == "b" || rep == "c")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecte ! ");
        Console.ForegroundColor = ConsoleColor.White;
        while (rep != "Oui" && rep != "Non")
        {
            Console.Write("Un nouvel essai ? Oui / Non : ");
            rep = Console.ReadLine();
        }
        if (rep == "Non")
        {
            break;
        }
    }

    if (rep == "d")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo !!! C'est la bonne réponse ");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }
}
