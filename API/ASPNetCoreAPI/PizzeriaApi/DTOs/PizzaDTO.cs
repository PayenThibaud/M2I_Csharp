using PizzeriaApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzeriaApi.DTOs
{
    public class PizzaDTO
    {
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

        [NotMapped]
        public List<Ingredient> Ingredients { get; set; }
    }
}
