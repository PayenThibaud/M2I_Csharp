Console.WriteLine("--- Quelle boisson souhaitez-vous ? ---");
Console.WriteLine("Liste de boissons disponibles : ");
Console.WriteLine("\t 1)Eau Plate");
Console.WriteLine("\t 2)Eau Gazeuse");
Console.WriteLine("\t 3)Coca-Cola");
Console.WriteLine("\t 4)Fanta");
Console.WriteLine("\t 5)Sprite");
Console.WriteLine("\t 6)Orangina");
Console.WriteLine("\t 7)7up");
Console.Write("Faites votre choix (1 à 7) : ");
string nombre = Console.ReadLine();
string commande = "vide";

if (int.TryParse(nombre, out int nb))
{
    if (nb >7 || nb <1)
    {
        Console.WriteLine("Rentrez des données valide !");
    }
    else
    {
        switch (nb)
        {
            case 1:
                commande = "Eau Plate";
                break;
            case 2:
                commande = "Eau Gazeuse";
                break;
            case 3:
                commande = "Coca-Cola";
                break;
            case 4:
                commande = "Fanta";
                break;
            case 5:
                commande = "Sprite";
                break;
            case 6:
                commande = "Orangina";
                break;
            case 7:
                commande = "7up";
                break;
        }
        Console.WriteLine("Votre " + commande + " est servi...");
    }
}
else
{
    Console.WriteLine("Rentrez des données valide !");
}