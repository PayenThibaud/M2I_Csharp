using ExoFigure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoFigure.Class
{
    internal abstract class Figure : IDeplacable
    {
        private Point _origine;

        internal Point Origine { get => _origine; set => _origine = value; }

        public Figure(Point origine)
        {
            _origine = origine;
        }

        public bool Deplacement(double x, double y)
        {
            Origine.PosX = x;
            Origine.PosY = y;

            return true;
        }
    }
}
