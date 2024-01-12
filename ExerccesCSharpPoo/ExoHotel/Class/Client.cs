using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ExoHotel.Class
{
    internal class Client
    {
        private static int _counter = 0;

        private int _id = 0;
        private string _nom;
        private string _prenom;
        private string _tel;


        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Tel { get => _tel; set => _tel = value; }


        public Client(string nom, string prenom, string tel)
        {
            _id = ++_counter; 
            _nom = nom;
            _prenom = prenom;
            _tel = tel;
        }

        public override string ToString()
        {
            return $"Nom: {_nom}, Prenom: {_prenom}, Numéro de téléphone: {_tel}";
        }
    }
}
