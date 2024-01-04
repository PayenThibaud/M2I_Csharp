Console.WriteLine("--- Accroissement de population ---");
Console.WriteLine("2015 : 96 809 habitants, et chaque année + 0.89% ");
Console.Write("Combien d'habitant veux tu ? je te dirais l'année pour l'atteindre ");
string nombre = Console.ReadLine();
int an = 2015;
double pop = 0;

if (double.TryParse(nombre, out double nb))
{
    for (double i = 96809; i <= nb; i = i * 1.0089)
    {
        an++;
        pop = i;
    }
    pop = Math.Round(pop * 1.0089);
    Console.WriteLine("");
    Console.WriteLine("Il faudra attendre l'année " + an);
    Console.WriteLine("et il y aura " + pop + " d'habitants");
    Console.WriteLine("il aura fallu attendre " + (an -2015) + " ans");
}
else
{
    Console.WriteLine("Données entré invalide");
}
