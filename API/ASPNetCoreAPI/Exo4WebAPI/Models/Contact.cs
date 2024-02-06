using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Exo4WebAPI.Models
{
    public class Contact
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("Id")] 
        public int IdForJson => Id;

        public string Nom {  get; set; }

        public string Prenom { get; set; }

        public string NomComplet => $"{Prenom} {Nom}";


        public Sexe Sexe1 { get; set; }
        public DateTime? DateDeNaissance { get; set; }
        public string Avatar { get; set; }

        public int Age => CalculAge(DateDeNaissance.Value);

        private static int CalculAge(DateTime DateDeNaissance)
        {
            var Aujourdhui = DateTime.Today;
            var age = Aujourdhui.Year - DateDeNaissance.Year;
            if (DateDeNaissance.Date > Aujourdhui.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }

    public enum Sexe
    {
        Mâle,
        Femelle,
    }
}
