using ExoHotel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.LINQ
{
    internal static class GenerateurChambre
    {
        public static List<Chambre> GenererChambres()
        {
            int nombreDeChambres;

            Console.Write("Combien de chambres souhaitez-vous ? ");
            while (!int.TryParse(Console.ReadLine(), out nombreDeChambres) || nombreDeChambres <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saisie incorrecte !");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.Write("Combien de chambre nous allons construire dans votre hotel ? : ");
                Console.ResetColor();
            }

            var chambres = Enumerable.Range(1, nombreDeChambres)
                .Select(numero => new Chambre(numero, StatutChambre.LIBRE, 2, 100.0m))
                .ToList();

            Console.WriteLine($"Génération de {nombreDeChambres} chambres réussie.");
            return chambres;
        }
    }


}


