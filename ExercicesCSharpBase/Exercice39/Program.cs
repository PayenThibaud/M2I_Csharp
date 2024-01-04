String[] gagnant = {"John1", "Christ","Mathilde" };
String[] attente = {"Banane","Poire","Fraise" };


bool quitter = false;
while (!quitter)
{
    string choice;
    Console.WriteLine("--- Le grand tirage au sort ---");
    Console.WriteLine("");
    Console.WriteLine("1 - - - Effectuer un tirage ");
    Console.WriteLine("2 - - - Voir la liste des personnes déjà tirées ");
    Console.WriteLine("3 - - - Voir la liste des personnes restantes ");
    Console.WriteLine("0 - - - Quitter ");
    Console.WriteLine("");
    Console.Write("Faites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":

            if (attente.Length != 0)
            {
                Random aleatoire = new Random();
                int nbMystere = aleatoire.Next(0, attente.Length);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"L'heureux gagnant est : {attente[nbMystere]}:");
                Console.WriteLine("");
                Console.ResetColor();

                string[] nouveaugagnant = new string[gagnant.Length + 1];

                for (int i = 0; i < gagnant.Length; i++)
                {
                    nouveaugagnant[i] = gagnant[i];
                }

                nouveaugagnant[gagnant.Length] = attente[nbMystere];

                gagnant = nouveaugagnant;

                if (attente.Length > 1)
                {
                    string[] nouveauAttente = new string[attente.Length - 1];
                    for (int i = 0, j = 0; i < attente.Length; i++)
                    {
                        if (i != nbMystere)
                        {
                            nouveauAttente[j++] = attente[i];
                        }
                    }
                    attente = nouveauAttente;
                }
                else
                {
                    attente = new string[0];
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("réinitialisation des participants");
                Console.WriteLine("");
                Console.ResetColor();
                attente = gagnant;
                gagnant = new string[0];
            }



            break;
        case "2":
            int t = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Liste des personnes déjà été tirés :");
            Console.WriteLine("");
            Console.ResetColor();

            foreach (string donnee in gagnant)
            {
                t++;
                string espace = string.Concat(Enumerable.Repeat("    ", t - 1));
                Console.WriteLine($"{espace} {donnee}");
            }
            Console.WriteLine("");

            break;
        case "3":
            int c = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" N'ont pas encore fait de correction :");
            Console.WriteLine("");
            Console.ResetColor();

            foreach (string donnee in attente)
            {
                c++;
                string espace = string.Concat(Enumerable.Repeat("    ", c - 1));
                Console.WriteLine($"{espace} {donnee}");

            }
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