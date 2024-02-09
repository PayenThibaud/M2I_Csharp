using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzeriaApi.Models
{
    [Table("pizza")]
    public class Pizza
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nom")]
        [Required]
        public string Nom { get; set; }

        [Column("description")]
        [Required]
        public string Description { get; set; }

        [Column("prix")]
        [Required]
        public double Prix { get; set; }

        [Column("image")]
        [Required]
        public string Image { get; set; }

        [Column("pizza_vegetarienne")]
        [Required]
        public bool isVegetarienne { get; set; } = false;

        [Column("pizza_piquante")]
        [Required]
        public bool isPiquante { get; set; } = false;

        public List<PizzaIngredient> PizzaIngredients { get; set; } = new List<PizzaIngredient>();
    }
}
