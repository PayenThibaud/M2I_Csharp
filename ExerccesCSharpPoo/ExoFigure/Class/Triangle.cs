using ExoFigure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoFigure.Class
{
    internal class Triangle : Figure, IDeplacable
    {
        private double _base;
        private double _hauteur;

        public double Base { get => _base; set => _base = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public Triangle(double Base, double hauteur, Point origine) : base(origine)
        {
            _hauteur = hauteur;
            _base = Base;
        }

        public void AfficherCoordonneesPoints()
        {
            Console.WriteLine($"Coordonnées des points du triangle :");

            Point A = Origine;
            Point B = new Point(Origine.PosX - (_base / 2), Origine.PosY - _hauteur);
            Point C = new Point(Origine.PosX + (_base / 2), Origine.PosY - _hauteur);

            Console.WriteLine($"A : {A}");
            Console.WriteLine($"B : {B}");
            Console.WriteLine($"C : {C}");
        }
    }
}
