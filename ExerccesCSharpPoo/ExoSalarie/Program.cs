using ExoSalarie.Class;
using System.Runtime.InteropServices;


double NouveauSalaire = 0;

Salarie[] tableSalarie = new Salarie[]
        {
            new Salarie("MatriculeA", "ServiceB", "CategorieE", "testA", 1000),
            new Salarie("MatriculeB", "ServiceB", "CategorieE", "testB", 2000),
            new Salarie("MatriculeC", "ServiceB", "CategorieE", "testC", 3000),
            new Salarie("MatriculeD", "ServiceB", "CategorieE", "testD", 4000),
            new Salarie(nom: "John" ),
            new Salarie( )
        };


bool quitter = false;
while (!quitter)
{
    string choice;
    Console.WriteLine("--- IHM ---");
    Console.WriteLine("");
    Console.WriteLine("1 - - - Affichez les salaire des employé ");
    Console.WriteLine("2 - - - Changer le salaire d'un employé ");
    Console.WriteLine("3 - - - Affichez le salaire total, le nombre d'employé et le salaire moyen ");
    Console.WriteLine("4 - - - Remise à zero des alariés et salaire total ");
    Console.WriteLine("0 - - - Quitter ");
    Console.WriteLine("");
    Console.Write("Faites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            foreach (Salarie a in tableSalarie)
            {
                a.AfficherSalaire();
            }
            break;
        case "2":
            foreach (Salarie a in tableSalarie)
            {
                a.AfficherSalaire();
                Console.Write($"Veuillez saisir le nouveau salaire de l'employé {a.Nom} : ? ");

                while (!double.TryParse(Console.ReadLine(), out NouveauSalaire))
                    Console.WriteLine("Saisie invalide ! Recommence");
                a.ChangerSalaire(NouveauSalaire);
                Console.WriteLine("");
            }
            break;
        case "3":
            Salarie.AfficherNombreDeSalarie();
            Salarie.AfficherSalaireTotal();
            Salarie.AfficherMoyenneSalaire();
            break;
        case "4":




            break;
        case "0":
            quitter = true;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur de saisie, recommencez !");
            Console.WriteLine("");
            Console.ResetColor();
            break;
    }
}