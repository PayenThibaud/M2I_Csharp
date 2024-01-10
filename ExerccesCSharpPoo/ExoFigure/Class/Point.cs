using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoFigure.Class
{
    internal class Point
    {
        private double _posX;
        private double _posY;
        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }

        internal Point(double x, double y)
        {
            _posX = x;
            _posY = y;
        }

        public override string ToString()
        {
            return $"({PosX}, {PosY})";
        }
    }
}
