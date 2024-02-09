using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzeriaApi.Models
{
    [Table("pizza_ingredient")]
    public class PizzaIngredient
    {
        [Column("pizza_id")]
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }


        [Column("ingredient_id")]
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
