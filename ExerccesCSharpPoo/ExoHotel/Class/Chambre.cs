using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Class
{
    internal class Chambre
    {
        private int _numero;
        private StatutChambre _statut;
        private int _NbDeLit;
        private decimal _tarif;

        public int Numero { get => _numero; set => _numero = value; }
        public int NbDeLit { get => _NbDeLit; set => _NbDeLit = value; }
        public decimal Tarif { get => _tarif; set => _tarif = value; }
        internal StatutChambre Statut { get => _statut; set => _statut = value; }


        public Chambre(int numero, StatutChambre statut, int nbDeLit, decimal tarif)
        {
            _NbDeLit = nbDeLit;
            _tarif = tarif;
            _numero = numero;
            _statut = statut;
        }

        public override string ToString()
        {
            return $"Numero de chambre: {_numero}, avec {_NbDeLit}, au tarif de: {_tarif}";
        }
    }
}
