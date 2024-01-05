using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Classes
{
    internal class Dinosaur
    {
        public double _age = 100000000;
        private int _poids = 10;

        public int Age { get => (int)_age; set => _age = value; }

        public int Poid
        {
            get
            {
                Console.WriteLine("recup du poid");
                return _poids;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ok go 100Kg");
                    _poids = 100;
                }
                else
                {
                    _poids = value;
                }
            }

        }
        public string AgePoids { get => $"{_age} {_poids}"; }

        public string AgePoid { get => $"{Age} { Poid}"; }
    }
}
