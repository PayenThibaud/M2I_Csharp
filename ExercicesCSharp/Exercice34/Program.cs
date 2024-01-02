double valeur = 0;

Console.WriteLine("--- est pair ... ? est impair ... ? --- ");
Console.WriteLine("Combiens de nombre contiendra le tableau ?");

int nombreDeValeur;
while (!int.TryParse(Console.ReadLine(), out nombreDeValeur))
    Console.WriteLine($"Saisie invalide ! Recommence \ncombien de valeur voulez vous saisir ? ");
double[] t1 = new double[nombreDeValeur];

Console.Write("Affectation automatique des valeurs...");


for (int i = 0; i <= nombreDeValeur - 1; i++)
{
    Random aleatoire = new Random();
    int nbMystere = aleatoire.Next(1, 51);
    t1[i] = nbMystere;
}

Console.WriteLine("Affichage du tableau : ");

for (int i = 0; i < nombreDeValeur; i++)
{
    if (t1[i] % 2 == 0)
    {
        Console.WriteLine($"\t Le nombre {t1[i]} est pair");
    }
    else
    {
        Console.WriteLine($"\t Le nombre {t1[i]} est impair");
    }
}