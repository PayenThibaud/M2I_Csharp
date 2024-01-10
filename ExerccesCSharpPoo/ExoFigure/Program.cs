using ExoFigure.Class;

double cote = 0;

double longueur = 0;
double largeur = 0;

double hauteur = 0;
double Base = 0;

double x = 0;
double y = 0;

bool quitter = false;
while (!quitter)
{
    string choice;
    Console.WriteLine("--- IHM ---");
    Console.WriteLine("");
    Console.WriteLine("1 - - - Carré ");
    Console.WriteLine("2 - - - Rectangle ");
    Console.WriteLine("3 - - - Triangle ");
    Console.WriteLine("0 - - - Quitter ");
    Console.WriteLine("");
    Console.Write("Faites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            Console.Write($"Veuillez saisir l'ordonnée X du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir l'abscisse y du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Saisie invalide ! Recommence");

            Point origineCarre = new Point(x, y);
            Console.WriteLine("");
            Console.Write($"Veuillez saisir la longueur des cotes du carre : ");

            while (!double.TryParse(Console.ReadLine(), out cote))
                Console.WriteLine("Saisie invalide ! Recommence");

            Carre monCarre = new Carre(cote, origineCarre);
            Console.WriteLine("");
            monCarre.AfficherCoordonneesPoints();

            Console.WriteLine("");
            Console.WriteLine("Test de la methode Deplacement");
            Console.WriteLine("");
            Console.Write($"Veuillez saisir la nouvelle ordonnée X du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la nouvelle abscisse y du point d'origine : ");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Saisie invalide ! Recommence");

            monCarre.Deplacement(x, y);
            Console.WriteLine("");
            monCarre.AfficherCoordonneesPoints();
            Console.WriteLine("");


            break;
        case "2":
            Console.Write($"Veuillez saisir l'ordonnée X du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir l'abscisse y du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Saisie invalide ! Recommence");

            Point origineRectangle = new Point(x, y);

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la longueur des cotes du rectangle : ");

            while (!double.TryParse(Console.ReadLine(), out longueur))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la longueur des cotes du rectangle : ");

            while (!double.TryParse(Console.ReadLine(), out largeur))
                Console.WriteLine("Saisie invalide ! Recommence");

            Rectangle monRectangle = new Rectangle(longueur, largeur, origineRectangle);
            Console.WriteLine("");
            monRectangle.AfficherCoordonneesPoints();

            Console.WriteLine("");
            Console.WriteLine("Test de la methode Deplacement");
            Console.WriteLine("");
            Console.Write($"Veuillez saisir la nouvelle ordonnée X du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la nouvelle abscisse y du point d'origine : ");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Saisie invalide ! Recommence");

            monRectangle.Deplacement(x, y);
            Console.WriteLine("");
            monRectangle.AfficherCoordonneesPoints();
            Console.WriteLine("");

            break;
        case "3":
            Console.Write($"Veuillez saisir l'ordonnée X du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir l'abscisse y du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Saisie invalide ! Recommence");

            Point origineTriangle = new Point(x, y);

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la base du triangle : ");

            while (!double.TryParse(Console.ReadLine(), out Base))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la hauteur du triangle : ");

            while (!double.TryParse(Console.ReadLine(), out hauteur))
                Console.WriteLine("Saisie invalide ! Recommence");

            Triangle monTriangle = new Triangle(Base, hauteur, origineTriangle);
            Console.WriteLine("");
            monTriangle.AfficherCoordonneesPoints();

            Console.WriteLine("");
            Console.WriteLine("Test de la methode Deplacement");
            Console.WriteLine("");
            Console.Write($"Veuillez saisir la nouvelle ordonnée X du point d'origine : ");

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine("");
            Console.Write($"Veuillez saisir la nouvelle abscisse y du point d'origine : ");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Saisie invalide ! Recommence");

            monTriangle.Deplacement(x, y);
            Console.WriteLine("");
            monTriangle.AfficherCoordonneesPoints();
            Console.WriteLine("");
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