using Exo4WebAPI.Models;

namespace Exo4WebAPI.Data
{
    public class ContactsFakeDb
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>()
        {
            new Contact()
            {
                Id = 1,
                Nom = "Benjamin",
                Prenom = "Fontaine",
                NomComplet = "Benjamin Fontaine",
                DateDeNaissance = new DateTime(1997, 10, 19),
                Sexe1 = Sexe.Mâle,
                Avatar = "http://localhost:port/Avatars/force.png"
            },
            new Contact()
            {
                Id = 2,
                Nom = "Alice",
                Prenom = "Dupont",
                NomComplet = "Alice Dupont",
                DateDeNaissance = new DateTime(1990, 12, 05),
                Sexe1 = Sexe.Femelle,
                Avatar = "http://localhost:port/Avatars/avatar2.png"
            },
            new Contact()
            {
                Id = 3,
                Nom = "Louis",
                Prenom = "Lefevre",
                NomComplet = "Louis Lefevre",
                DateDeNaissance = new DateTime(1985, 06, 15),
                Sexe1 = Sexe.Mâle,
                Avatar = "http://localhost:port/Avatars/avatar3.png"
            },
            new Contact()
            {
                Id = 4,
                Nom = "Sophie",
                Prenom = "Martin",
                NomComplet = "Sophie Martin",
                DateDeNaissance = new DateTime(2000, 03, 23),
                Sexe1 = Sexe.Femelle,
                Avatar = "http://localhost:port/Avatars/avatar4.png"
            },
            new Contact()
            {
                Id = 5,
                Nom = "Luc",
                Prenom = "Robert",
                NomComplet = "Luc Robert",
                DateDeNaissance = new DateTime(1980, 08, 10),
                Sexe1 = Sexe.Mâle,
                Avatar = "http://localhost:port/Avatars/avatar5.png"
            },
        };
    }
}
