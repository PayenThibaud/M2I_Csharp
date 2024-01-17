using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO02.Class
{
    internal class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }

        public List<Commande> Commandes { get; set; } = new();

        public Client(int id, string nom, string prenom, string adresse, string codePostal, string ville, string tel)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = tel;
        }

        public Client(string nom, string prenom, string adresse, string codePostal, string ville, string tel)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = tel;
        }

        public override string ToString()
        {
            return $"id: {Id}, identité: {Prenom} {Nom.ToUpper()}, Adresse: {Adresse} CodePostal: {CodePostal}, Ville: {Ville.ToUpper()}, tel: {Telephone}";
        }
    }
}