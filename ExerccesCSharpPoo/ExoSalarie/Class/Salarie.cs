using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSalarie.Class
{
    internal class Salarie
    {
        // Attributs
        private string _matricule;
        private string _service;
        private string _categorie;
        private string _nom;
        private double _salaire ;

        // Propriétés
        public string Matricule { get => _matricule; set => _matricule = value; }
        public string Service { get => _service; set => _service = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Nom { get => _nom; set => _nom = value; }

        // Attributs static (utilisable comme ancienne déclaration de variabe)
        private static double _salaireTotal;
        private static int _nombreDeSalarie;

        // Propriétés static
        public static double SalaireTotal { get => _salaireTotal; set => _salaireTotal = value; }
        public static int NombreDeSalarie { get => _nombreDeSalarie; set => _nombreDeSalarie = value; }

        // Propriétés qui utilise des propriétés static
        public double Salaire { get => _salaire; set => SalaireTotal = SalaireTotal - _salaire + (_salaire = value); }

        // Constructeurs (crée une nouvelle instance)
        public Salarie()
        {
            _nombreDeSalarie++;
            Salaire = 1555;
        }

        public Salarie(string matricule = "defaut", string service = "defaut", string categorie = "defaut", string nom = "defaut", double salaire = 1555) 
        {
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;
            _nombreDeSalarie++;
        }


        // Méthodes
        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salare de {Nom} est de {Salaire} euros");
        }
        public static void AfficherNombreDeSalarie()
        {
            Console.WriteLine($"Nombre de salariés : {NombreDeSalarie}");
        }

        public static void AfficherSalaireTotal()
        {
            Console.WriteLine($"Salaire total : {SalaireTotal}");
        }
        public static void AfficherMoyenneSalaire()
        {
            Console.WriteLine($"Salaire moyen : {SalaireTotal / NombreDeSalarie}");
        }

        public void ChangerSalaire(double salaire)
        {
            Salaire = salaire;
            Console.WriteLine($"On change le salaire de {Nom} à {Salaire} euros");
        }

    }
}

