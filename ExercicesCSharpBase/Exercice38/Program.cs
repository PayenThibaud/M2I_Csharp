double[] t1 = { };


Console.WriteLine("--- Ou est passé mon numéros ? ---");
Console.Write("combien de valeur voulez vous ? ");


double valeur = 0;


int nombreDeValeur;
while (!int.TryParse(Console.ReadLine(), out nombreDeValeur))
    Console.WriteLine($"Saisie invalide ! Recommence \ncombien de valeur voulez vous ? ");
t1 = new double[nombreDeValeur];

Console.WriteLine("Affectation automatique des valeurs...");


for (int j = 0; j <= nombreDeValeur -1; j++)
{
    Random aleatoire = new Random();
    int nbMystere = aleatoire.Next(1, 51);
    t1[j] = nbMystere;
}

int i = 0;

Console.WriteLine("");
Console.WriteLine("Affichage avant triage :");

foreach (double donnee in t1)
{
    i++;
    string espace = string.Concat(Enumerable.Repeat("    ", i-1));
    Console.WriteLine($"{espace} {donnee}");
}

Console.WriteLine("");
Console.WriteLine("Affichage après triage :");
Array.Sort(t1);

int a = 0;

foreach (double donnee in t1)
{
    a++;
    string espace = string.Concat(Enumerable.Repeat("    ", a - 1));
    Console.WriteLine($"{espace} {donnee}");
}

Console.WriteLine("");
Console.WriteLine("Affichage après triage décroissant :");
Array.Reverse(t1);

int z = 0;

foreach (double donnee in t1)
{
    z++;
    string espace = string.Concat(Enumerable.Repeat("    ", z - 1));
    Console.WriteLine($"{espace} {donnee}");
}