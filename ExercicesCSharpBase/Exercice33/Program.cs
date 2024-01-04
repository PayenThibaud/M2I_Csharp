double valeur = 0;

Console.WriteLine("Insertion des valeurs du tableau : ");
Console.WriteLine("");
Console.Write("combien de valeur voulez vous saisir ? ");

int nombreDeValeur;
while (!int.TryParse(Console.ReadLine(), out nombreDeValeur))
    Console.WriteLine($"Saisie invalide ! Recommence \ncombien de valeur voulez vous saisir ? ");
double[] t1 = new double[nombreDeValeur];

for (int i = 0; i <= nombreDeValeur - 1; i++)
{
    Console.Write($"\t- Saisir la valeur {i} : ");
    while (!double.TryParse(Console.ReadLine(), out valeur) || valeur > 100 || valeur < 0)
        Console.Write($"Saisie invalide ! Recommence \n \t- Saisir la valeur {i} : ");
    t1[i] = valeur;
}

Console.WriteLine("Affichage du tableau : ");

for (int i = 0; i < nombreDeValeur; i++)
{
    string tab = string.Concat(Enumerable.Repeat("\t", i));
    Console.WriteLine($"{tab} {t1[i]}");
}