using AutoMapper;
using PizzeriaApi.DTOs;
using PizzeriaApi.Models;

namespace PizzeriaApi.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Pizza, PizzaDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<Utilisateur, UtilisateurDTO>().ReverseMap();
        }

    }
}
