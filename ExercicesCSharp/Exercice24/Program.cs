Console.WriteLine("--- Les suites chaînées de nombre ---");
Console.Write("Merci de saisir un nombre : ");
string nombre = Console.ReadLine();
int somme = 0;
string cumule = "";

if (double.TryParse(nombre, out double nb))
{
    Console.WriteLine("La suite des nombres est :");

    for (int i = 1; i <= nb; i++)
    {
        somme = 0;
        cumule = "";
        for (int j = i; j <= nb-1; j++)
        {
            somme = somme + j;
            if (cumule == "")
            {
                cumule = cumule + j;
            }
            else
            {
                cumule = cumule + " + " + j;
            }
            if (somme == nb)
                Console.WriteLine(somme +" = " + cumule);
        }
    }
}
else
{
    Console.WriteLine("Données entrées invalides");
}
 