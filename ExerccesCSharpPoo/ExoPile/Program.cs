using ExoPile.Class;
using System.Drawing;

Pile<int> maPileInt = new Pile<int>(100);
Pile<string> maPileString = new Pile<string>(100);
Pile<Personne> maPilePersonne = new Pile<Personne>(100);

string EmpileString;
int EmpileInt;
string EmpileNom;
string EmpilePrenom;
int EmpileAge;

int index;

bool quitter = false;
while (!quitter)
{
    string choice;
    Console.WriteLine("--- IHM ---");
    Console.WriteLine("");
    Console.WriteLine("1 - - - Empiler ");
    Console.WriteLine("2 - - - Dépiler ");
    Console.WriteLine("3 - - - Récuperer à X ");
    Console.WriteLine("0 - - - Quitter ");
    Console.WriteLine("");
    Console.Write("Faites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":


                string choix;
                Console.WriteLine("1 - - - int ");
                Console.WriteLine("2 - - - string ");
                Console.WriteLine("3 - - - personne ");
                Console.WriteLine("");
                Console.Write("Faites votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();

                switch (choix)
                {
                    case "1":
                    Console.Write($"Veuillez saisir la valeur à Empiler : ");

                    while (!int.TryParse(Console.ReadLine(), out EmpileInt))
                        Console.WriteLine("Saisie invalide ! Recommence");
                    Console.WriteLine("");

                    maPileInt.Empiler(EmpileInt);

                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste des int : ");
                    maPileInt.AfficheElements();
                    Console.WriteLine("");


                    break;
                    case "2":
                    Console.Write($"Veuillez saisir la valeur à Empiler : ");

                    EmpileString = Console.ReadLine();
                    Console.WriteLine("");

                    maPileString.Empiler(EmpileString);

                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste des string : ");
                    maPileString.AfficheElements();
                    Console.WriteLine("");


                    break;
                    case "3":
                    Console.WriteLine($"Vous allez Empiler une Personne dans la Liste personne ");
                    Console.Write($"Veuillez saisir le nom : ");

                    EmpileNom = Console.ReadLine();
                    Console.WriteLine("");

                    Console.Write($"Veuillez saisir le prenom : ");

                    EmpilePrenom = Console.ReadLine();
                    Console.WriteLine("");

                    Console.Write($"Veuillez saisir le age : ");

                    while (!int.TryParse(Console.ReadLine(), out EmpileAge))
                        Console.WriteLine("Saisie invalide ! Recommence");
                    Console.WriteLine("");

                    Personne EmpilePersonne = new Personne(EmpileNom, EmpilePrenom, EmpileAge);
                    
                    maPilePersonne.Empiler(EmpilePersonne);

                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste des Personnes : ");
                    maPilePersonne.AfficheElements();
                    Console.WriteLine("");
                        break;
                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur de saisie, recommencez !");
                    Console.WriteLine("");
                    Console.ResetColor();
                    break;
                }

                break;
        case "2":

            string choixDepile;
            Console.WriteLine("1 - - - int ");
            Console.WriteLine("2 - - - string ");
            Console.WriteLine("3 - - - personne ");
            Console.WriteLine("");
            Console.Write("Faites votre choix : ");
            choixDepile = Console.ReadLine();
            Console.Clear();

            switch (choixDepile)
            {
                case "1":
                    Console.WriteLine($"Vous avez dépilé la valeur : {maPileInt.Depiler()} ");
                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste actuelle : ");
                    maPileInt.AfficheElements();
                    Console.WriteLine("");


                    break;
                case "2":
                    Console.WriteLine($"Vous avez dépilé la valeur : {maPileString.Depiler()} ");
                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste actuelle : ");
                    maPileInt.AfficheElements();
                    Console.WriteLine("");

                    break;
                case "3":
                    Console.WriteLine($"Vous avez dépilé la valeur : {maPilePersonne.Depiler()} ");
                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste actuelle : ");
                    maPileInt.AfficheElements();
                    Console.WriteLine("");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur de saisie, recommencez !");
                    Console.WriteLine("");
                    Console.ResetColor();
                    break;
            }


            break;
        case "3":


            string choixRecup;
            Console.WriteLine("1 - - - int ");
            Console.WriteLine("2 - - - string ");
            Console.WriteLine("3 - - - personne ");
            Console.WriteLine("");
            Console.Write("Faites votre choix : ");
            choixRecup = Console.ReadLine();
            Console.Clear();

            switch (choixRecup)
            {
                case "1":
                    Console.Write($"Veuillez saisir l'index que vous voulez récupérer : ");

                    while (!int.TryParse(Console.ReadLine(), out index))
                        Console.WriteLine("Saisie invalide ! Recommence");
                    Console.WriteLine("");

                    Console.WriteLine($"Vous avez récuperer : {maPileInt.Recuperer(index)} ");
                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste actuelle : ");
                    maPileInt.AfficheElements();
                    Console.WriteLine("");


                    break;
                case "2":
                    Console.Write($"Veuillez saisir l'index que vous voulez récupérer : ");

                    while (!int.TryParse(Console.ReadLine(), out index))
                        Console.WriteLine("Saisie invalide ! Recommence");
                    Console.WriteLine("");

                    Console.WriteLine($"Vous avez récuperer : {maPileString.Recuperer(index)} ");
                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste actuelle : ");
                    maPileString.AfficheElements();
                    Console.WriteLine("");

                    break;
                case "3":
                    Console.Write($"Veuillez saisir l'index que vous voulez récupérer : ");

                    while (!int.TryParse(Console.ReadLine(), out index))
                        Console.WriteLine("Saisie invalide ! Recommence");
                    Console.WriteLine("");

                    Console.WriteLine($"Vous avez récuperer : {maPilePersonne.Recuperer(index)} ");
                    Console.WriteLine("");
                    Console.WriteLine("Voici la liste actuelle : ");
                    maPilePersonne.AfficheElements();
                    Console.WriteLine("");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erreur de saisie, recommencez !");
                    Console.WriteLine("");
                    Console.ResetColor();
                    break;
            }


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