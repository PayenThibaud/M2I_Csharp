Console.WriteLine("--- Menus et sous-menus ---");
Console.WriteLine("Table des matières : ");
Console.Write("Combien de Chapitre ? ");
string nombreChap = Console.ReadLine();
Console.Write("Combien de Sous-chapitre ? ");
string nombreSous = Console.ReadLine();

if (double.TryParse(nombreChap, out double chap) &&
    double.TryParse(nombreSous, out double sous))
{
    for (int i = 1; i <= chap; i++)
    {
        Console.WriteLine("\tChapitre " + i);
        for (int b = 1; b <= sous; b++)
        {
            Console.WriteLine("\t\t-Partie " + i + "." + b);
        }
    }
}
else
{
    Console.WriteLine("Données entré invalide");
}