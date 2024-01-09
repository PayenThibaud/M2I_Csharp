using SalarieHeritage.Class;


decimal NouveauSalaire = 0;

Salarie[] tableSalarie = new Salarie[]
        {
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
    Console.WriteLine("4 - - - Créer un salarié ");
    Console.WriteLine("5 - - - Créer un commercial ");
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

                while (!decimal.TryParse(Console.ReadLine(), out NouveauSalaire))
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
            Console.Write("Matricule : ");
            string matriculeS = Console.ReadLine();
            Console.Write("Nom : ");
            string nomS = Console.ReadLine();
            Console.Write("Service : ");
            string serviceS = Console.ReadLine();
            Console.Write("Catégorie : ");
            string categorieS = Console.ReadLine();
            Console.Write("Salaire : ");
            while (!decimal.TryParse(Console.ReadLine(), out NouveauSalaire))
            {
                Console.WriteLine("Saisie invalide ! Veuillez saisir un montant valide pour le salaire.");
                Console.Write("Salaire : ");
            }

            Salarie nouveauSalarie = Salarie.CreerSalarie(matriculeS, nomS, serviceS, categorieS, NouveauSalaire);

            Array.Resize(ref tableSalarie, tableSalarie.Length + 1);
            tableSalarie[tableSalarie.Length - 1] = nouveauSalarie;

            Console.WriteLine("Nouveau salarié créé avec succès!");

            break;
        case "5":
            Console.Write("Matricule : ");
            string matriculeCommercial = Console.ReadLine();
            Console.Write("Nom : ");
            string nomCommercial = Console.ReadLine();
            Console.Write("Service : ");
            string serviceCommercial = Console.ReadLine();
            Console.Write("Catégorie : ");
            string categorieCommercial = Console.ReadLine();
            Console.Write("Salaire : ");
            while (!decimal.TryParse(Console.ReadLine(), out NouveauSalaire))
            {
                Console.WriteLine("Saisie invalide ! Veuillez saisir un montant valide pour le salaire.");
                Console.Write("Salaire : ");
            }

            Console.Write("Chiffre d'affaires : ");
            double chiffreDaffaire = double.Parse(Console.ReadLine());

            Console.Write("Commission : ");
            double commission = double.Parse(Console.ReadLine());

            // Création d'un nouveau commercial
            Commercial nouveauCommercial = Commercial.CreerCommercial(matriculeCommercial, nomCommercial, serviceCommercial, categorieCommercial, NouveauSalaire, chiffreDaffaire, commission);

            Array.Resize(ref tableSalarie, tableSalarie.Length + 1);
            tableSalarie[tableSalarie.Length - 1] = nouveauCommercial;

            Console.WriteLine("Nouveau commercial créé avec succès!");
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