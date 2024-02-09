using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzeriaApi.Models
{
    [Table("ingredient")]
    public class Ingredient
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nom")]
        [Required]
        public string Name { get; set; }

        [Column("descriptif")]
        [Required]
        public string Description { get; set; }

        public List<PizzaIngredient> PizzaIngredients { get; set; } = new List<PizzaIngredient>();
    }
}
