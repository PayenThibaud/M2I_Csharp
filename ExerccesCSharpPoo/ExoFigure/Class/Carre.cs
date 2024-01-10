using ExoFigure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoFigure.Class
{
    internal class Carre : Figure, IDeplacable
    {
        private double _cote;

        public double Cote { get => _cote; set => _cote = value; }

        public Carre(double cote, Point origine) : base(origine)
        {
            _cote = cote;
        }

        public void AfficherCoordonneesPoints()
        {
            Console.WriteLine($"Coordonnées des points du carré :");
    
            Point A = Origine;
            Point B = new Point(Origine.PosX + _cote, Origine.PosY);
            Point C = new Point(Origine.PosX, Origine.PosY + _cote);
            Point D = new Point(Origine.PosX + _cote, Origine.PosY + _cote);

            Console.WriteLine($"A : {A}");
            Console.WriteLine($"B : {B}");
            Console.WriteLine($"C : {C}");
            Console.WriteLine($"D : {D}");
        }

    }
}
