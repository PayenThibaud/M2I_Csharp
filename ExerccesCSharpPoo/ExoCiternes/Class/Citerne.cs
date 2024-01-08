using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoCiternes.Class
{
    internal class Citerne
    {
        private double _eau;

        public double Eau
        {
            get => _eau;
            set
            {
                TotalEau -= _eau;
                _eau = value;
                //TotalSalaires += value;
                TotalEau += _eau;
            }
        }

        public static double TotalEau { get; private set; } = 0;

        public string Nom { get; set; } = "0";
        public double Poid { get; set; } = 5;
        public double Capacite { get; set; } = 20;


        public static decimal TotalSalaires { get; private set; } = 0;


        public Citerne(string nom, double poid, double capacite, double eau)
        {
            Nom = nom; 
            Poid = poid;
            Capacite = capacite;
            Eau = eau;
        }

        public void AfficherPoidTotal()
        {
            Console.WriteLine($"Poids total de la citerne {Nom} : {Eau + Poid}");
        }

        public void RemplirCiterne(double remplir)
        {
            Eau = Eau + remplir;
            if (Eau > Capacite)
            {
                Double exces = Eau - Capacite;
                Eau = Capacite;
                Console.WriteLine($"Quantité d'eau dans la citerne {Nom} après ajout de {remplir} litres: {Eau}/{Capacite}");
                Console.WriteLine($"Excès d'eau récupérer : {exces}");
            }
            else
            {
                Console.WriteLine($"Quantité d'eau dans la citerne {Nom} après ajout de {remplir} litres: {Eau}/{Capacite}");
            }
        }

        public void RetraitCiterne(double retrait)
        {
            if (Eau - retrait < 0)
            {
                Double retraitreussis = Eau;
                Eau = 0;
                Console.WriteLine($"Quantité d'eau dans la citerne {Nom} après retrait de {retrait} litres: {Eau}/{Capacite}");
                Console.WriteLine($"Quantité d'eau récupérer : {retraitreussis}");
            }
            else
            {
                Eau = Eau - retrait;
                Console.WriteLine($"Quantité d'eau dans la citerne {Nom} après retrait de {retrait} litres: {Eau}/{Capacite}");
                Console.WriteLine($"Quantité d'eau récupérer : {retrait}");
            }
        }

        public static void TotalEauDesCiternes()
        {
            Console.WriteLine($"Quantite d'eau dans toutes les citernes : {TotalEau}");
        }
    }
}