using System.Text.Json.Serialization;

namespace Exo4WebAPI.Models
{
    public class Contact
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomComplet { get; set; }
        public Sexe Sexe1 { get; set; }
        public DateTime? DateDeNaissance { get; set; }
        public string Avatar { get; set; }

        public int? Age => DateDeNaissance.HasValue ? CalculAge(DateDeNaissance.Value) : null;
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