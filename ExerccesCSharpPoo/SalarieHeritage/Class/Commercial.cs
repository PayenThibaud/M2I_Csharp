using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarieHeritage.Class
{
    internal class Commercial : Salarie
    {
        // 2 Attribut :
        private double _chiffreDAffaire;
        private double _commission;

        //2 Propriété :
        public double ChiffreDAffaire { get => _chiffreDAffaire; set => _chiffreDAffaire = value; }
        public double Commission { get => _commission; set => _commission = value; }

        public override decimal Salaire
        {
            get => _salaire;
            set
            {
                TotalSalaires -= _salaire;
                _salaire = value + (decimal)(_chiffreDAffaire * _commission / 100);
                TotalSalaires += _salaire;
            }
        }
        // 2 constructeur :
        public Commercial() : base()
        {
        }

        public Commercial(double chiffredaffaire, double commission, string matricule, string nom, string service, string categorie, decimal salaire) : base(matricule, nom, service, categorie, salaire)
        {
            _chiffreDAffaire = chiffredaffaire;
            _commission = commission;
            _salaire = salaire + (decimal)(_chiffreDAffaire * _commission / 100 );
        }

        // methode 

        public override string ToString()
        {
            return $"{base.ToString()}, Chiffre d'affaires: {this.ChiffreDAffaire}, Commission: {this.Commission}";
        }

        public static Commercial CreerCommercial(string matricule, string nom, string service, string categorie, decimal salaire, double chiffreDaffaire, double commission)
        {
            Commercial nouveauCommercial = new Commercial(chiffreDaffaire, commission, matricule, nom, service, categorie, salaire);
            return nouveauCommercial;
        }
    }
}
