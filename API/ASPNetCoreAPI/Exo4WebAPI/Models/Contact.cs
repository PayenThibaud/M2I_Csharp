using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Exo4WebAPI.Models
{
    public class Contact
    {
        [JsonIgnore]
        [Column("id")]
        public int Id { get; set; }

        [JsonPropertyName("Id")]
        public int IdForJson => Id;

        [Column("lastname")]
        [Required]
        [RegularExpression(@"^[A-Z\- ]*", ErrorMessage = "LastName must be in uppercase !")]
        public string Nom { get; set; }

        [Column("firstname")]
        [Required]
        [RegularExpression(@"^[A-Z][A-Za-z\- ]*", ErrorMessage = "FirstName must start with an uppercase letter !")]
        public string Prenom { get; set; }

        public string NomComplet => $"{Prenom} {Nom}";

        [Column("gender")]
        [Required]
        [RegularExpression(@"[FMN]", ErrorMessage = "Gender must be either F, M, or N.")]
        [StringLength(1)]
        public string? Sexe1 { get; set; }

        [Column("birth_date")]
        [Required]
        public DateTime? DateDeNaissance { get; set; }
        public string Avatar { get; set; }

        public int Age
        {
            get
            {
                if (DateDeNaissance.HasValue)
                {
                    int age = DateTime.Now.Year - DateDeNaissance.Value.Year;
                    if (DateDeNaissance.Value.Date > DateTime.Now.Date.AddYears(-age))
                        age--;
                    return age;
                }
                return 0; // Gérer le cas où la date de naissance est nulle (ou un autre comportement approprié)
            }
        }
    }
}
