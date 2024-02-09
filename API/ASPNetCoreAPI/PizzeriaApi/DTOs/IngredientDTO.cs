using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzeriaApi.DTOs
{
    public class IngredientDTO
    {
        public int Id { get; set; }

        [Column("nom")]
        [Required]
        public string Name { get; set; }

        [Column("descriptif")]
        [Required]
        public string Description { get; set; }

        public List<string> NomsPizzas { get; set; }
    }
}
