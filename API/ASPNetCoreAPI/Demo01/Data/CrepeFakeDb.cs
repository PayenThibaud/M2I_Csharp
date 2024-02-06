using Demo01.Models;

namespace Demo01.Data
{
    public class CrepeFakeDb
    {
        public List<Crepe> Crepes { get; set; } = new List<Crepe>()
        {
            new Crepe()
            {
                Id = 1,
                Name = "Surprise du chef",
                Diameter = 14,
                IsSalty = true,
                Topping1 = Topping.Camembert,
                Topping2 = Topping.Mayonnaise
            },

            new Crepe()
            {
                Id = 1,
                Name = "Surprise du chef",
                Diameter = 14,
                IsSalty = true,
                Topping1 = Topping.Camembert,
                Topping2 = Topping.Mayonnaise
            }
        };
    }
}