
string[] Tmois = { "Janvier", "Février", "Mars", "Avril", "Mail", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
int i = -1;

foreach (string donnee in Tmois)
{
    i++;
    string espace = string.Concat(Enumerable.Repeat("\t", i));
    Console.WriteLine($"{espace} {donnee}");
}