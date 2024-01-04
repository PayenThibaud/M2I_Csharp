Random aleatoire = new Random();
int nbMystere = aleatoire.Next(1, 51);
int a = 1;
int nbTentative = 0;

Console.WriteLine("--- Trouver le nombre mystère ---");
Console.WriteLine("");

int i = 0;
while (i >= 0)
{
    Console.Write("Veuillez saisir un nombre : ? ");
    Console.WriteLine("");

    while (!int.TryParse(Console.ReadLine(), out a) || a > 50 || a < 0)
        Console.WriteLine("Saisie invalide ! Recommence");

    nbTentative++;

    if (a > nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus petit ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    if (a < nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus grand ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    if (a == nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo !!! Vous avez trouvé le nombre mystère ! ");
        Console.WriteLine("Vous avez trouvé en " + nbTentative + " coups.");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    }
}
