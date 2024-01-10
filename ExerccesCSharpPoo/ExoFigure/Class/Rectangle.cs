using ExoFigure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ExoFigure.Class
{
    internal class Rectangle : Figure, IDeplacable
    {
        private double _longueur;
        private double _largeur;

        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }


        public Rectangle(double longueur, double largeur, Point origine) : base(origine)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public void AfficherCoordonneesPoints()
        {
            Console.WriteLine($"Coordonnées des points du rectangle :");
            
            Point A = Origine;
            Point B = new Point(Origine.PosX + _longueur, Origine.PosY);
            Point C = new Point(Origine.PosX, Origine.PosY + _largeur);
            Point D = new Point(Origine.PosX + _longueur, Origine.PosY + _largeur);

            Console.WriteLine($"A : {A}");
            Console.WriteLine($"B : {B}");
            Console.WriteLine($"C : {C}");
            Console.WriteLine($"D : {D}");
        }

    }
}
