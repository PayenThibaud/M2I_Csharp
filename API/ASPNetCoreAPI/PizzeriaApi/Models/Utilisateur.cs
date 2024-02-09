using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzeriaApi.Models
{
    [Table("utilisateur")]
    public class Utilisateur
    {
        [Key]
        [Column("(id)")]
        public int Id { get; set; }

        [Column("prenom")]
        [Required]
        public string Prenom { get; set; }

        [Column("nom")]
        [Required]
        public string Nom {  get; set; }

        [RegularExpression(@"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$", ErrorMessage = "Invalid email address")]
        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Column("numero")]
        [Required]
        public string Numero { get; set; }

        [Column("adresse")]
        [Required]
        public string Adresse { get; set; }

        [Required]
        public bool IsAdmin { get; set; } = false;

    }
}
