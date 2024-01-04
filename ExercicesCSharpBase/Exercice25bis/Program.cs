double bon = 0;
double nul = 20;
double moyenne = 0;

Console.WriteLine("--- Gestion des notes ---");
Console.WriteLine("");
Console.Write("combien de note à saisir ? ");
double nombreDeNote;
while (!double.TryParse(Console.ReadLine(), out nombreDeNote))
    Console.WriteLine("Saisie invalide ! Recommence");

for (int i = 1; i <= nombreDeNote; i++)
{
    Console.Write($"\t- Merci de saisir la note {i} (sur /20) : ");
    double nombre;
    while (!double.TryParse(Console.ReadLine(), out nombre) || nombre > 20 || nombre < 0)
        Console.Write($"Saisie invalide ! Recommence \n \t- Merci de saisir la note {i} (sur /20) : ");

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
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("La meilleure note est " + bon);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("La moins bonne note est " + nul);
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("La moyenne des notes est " + moyenne);