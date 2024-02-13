using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FormulaireMarier.Models
{
    public class FormulaireMariee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Au moins un pseudo 😀"), StringLength(12, MinimumLength = 3, ErrorMessage = "Le nom doit faire entre 3 et 12 caractères")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Une email svp!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Une petit adresse ? 😗")]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Pas de code postal ? 🙄")]
        public string Postal { get; set; }
        [Required]
        public int Age { get; set; }
        public DateTime Naissance { get; set; }
        public bool Mariee { get; set; } = false;
        [Range(1, 5, ErrorMessage = "Vous n'avez pas de préférence ... 😪")]
        public FurColor FurColor { get; set; }

        public override string ToString()
        {
            return $"{Nom} {Email} {Mariee} {FurColor}";
        }
    }
    public enum FurColor
    {
        Nothing,
        Red,
        Brown,
        Pink,
        Orange,
        White
    }
}
