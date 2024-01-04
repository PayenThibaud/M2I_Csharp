double[] t1 = { };


Console.WriteLine("--- Tableaux des notes ---");
Console.WriteLine("");
Console.Write("Combiens de notes comportera le tableaux : ");


int nombreDeNote;
while (!int.TryParse(Console.ReadLine(), out nombreDeNote))
    Console.WriteLine("Saisie invalide ! Recommence");

t1 = new double[(int)nombreDeNote];

for (int i = 0; i <= nombreDeNote - 1; i++)
{
    Console.Write($"\t- Merci de saisir la note {i + 1} (sur /20) : ");
    double nombre;
    while (!double.TryParse(Console.ReadLine(), out nombre) || nombre > 20 || nombre < 0)
        Console.Write($"Saisie invalide ! Recommence \n \t- Merci de saisir la note {i + 1} (sur /20) : ");
    t1[i] = nombre;
}
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("--- Liste des notes ---");
Console.ResetColor();

for (int i = 0; i <= nombreDeNote - 1; i++)
{
    Console.WriteLine($"La note {i + 1} est de : {t1[i]}");
}
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"La note max est de : {t1.Max()}");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"La note mini est de : {t1.Min()}");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"La moyenne est de : {Math.Round((t1.Sum()/nombreDeNote),2)}");

Console.ResetColor();




