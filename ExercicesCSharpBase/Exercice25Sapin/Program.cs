//// Affichage en tableau dynamique

int largeurTables = 1;

Console.WriteLine("Combien de branche ?");
int nbLigne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hauteur du tronc ?");
int nbTronc = Convert.ToInt32(Console.ReadLine());

// En arc en ciel

List<ConsoleColor> colors = new List<ConsoleColor>()
{
    ConsoleColor.Red,
    ConsoleColor.Magenta,
    ConsoleColor.Blue,
    ConsoleColor.Cyan,
    ConsoleColor.Green,
    ConsoleColor.Yellow
};


Console.ForegroundColor = ConsoleColor.White;

for (int i = 1; i <= nbLigne; i++)
{
    if (i == 1)
    {
        largeurTables = 1;
    }
    else
    {
        largeurTables += 2;
    }
    string espace = string.Concat(Enumerable.Repeat(" ", nbLigne - i + 2));
    Console.ForegroundColor = colors[i % colors.Count];
    Console.Write(espace);
    for (int j = 1; j <= largeurTables; j++)
    {
        Console.ForegroundColor = colors[(i + j) % colors.Count];
        if (i == 1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("A");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkRed;

}

for (int i = 1; i <= nbTronc; i++)
{
    string espace = string.Concat(Enumerable.Repeat(" ", nbLigne ));
    Console.WriteLine(espace + "| |");
}

Console.ForegroundColor = ConsoleColor.White;