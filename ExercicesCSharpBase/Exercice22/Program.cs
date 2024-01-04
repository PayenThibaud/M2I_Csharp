Console.WriteLine("--- Menus et sous-menus ---");
Console.WriteLine("Table des matières : ");
Console.Write("Tu veux combien de table ? ");
string nombre = Console.ReadLine();

if (double.TryParse(nombre, out double nb))
{
    for (int i = 1; i <= nb; i++)
    {
        Console.WriteLine("");
        Console.WriteLine("Table de " + i);
        for (int b = 1; b <= 10; b++)
        {
            int result = i * b;
            Console.WriteLine("\t- " + i + " x " + b + " = " + result );
        }
    }
}
else
{
    Console.WriteLine("Données entré invalide");
}
