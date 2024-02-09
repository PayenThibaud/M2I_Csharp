using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzeriaApi.DTOs;
using PizzeriaApi.Models;
using PizzeriaApi.Repositories;
using Constants = PizzeriaApi.Helpers.Constants;

namespace PizzeriaApi.Controllers
{
    [Route("Ingredients")]
    [ApiController]
    [Authorize]
    public class IngredientController : ControllerBase
    {
        private readonly IRepository<Ingredient> _repository;
        private readonly IMapper _mapper;

        public IngredientController(IRepository<Ingredient> repository,
                                 IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET /ingredients
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //return Ok(_repository.GetAll());
            IEnumerable<Ingredient> ingredients = await _repository.GetAll();

            IEnumerable<IngredientDTO> ingredientDTOs = _mapper.Map<IEnumerable<IngredientDTO>>(ingredients)!;
            //IEnumerable<ingredientDTO> ingredientDTOs = _mapper.Map<IEnumerable<ingredient>, IEnumerable<ingredientDTO>>(ingredients)!;

            // possible d'ajouter des modification par rapport aux DTOs ici

            return Ok(ingredientDTOs);
        }

        //GET /ingredients/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ingredient = await _repository.Get(id);

            if (ingredient == null)
                return NotFound(new
                {
                    Message = "There is no ingredient with this Id."
                });

            IngredientDTO ingredientDTO = _mapper.Map<IngredientDTO>(ingredient)!;

            return Ok(new
            {
                Message = "ingredient found.",
                ingredient = ingredientDTO
            });
        }

        //POST /ingredients
        [HttpPost]
        [Authorize(Roles = Constants.RoleAdmin)]
        public async Task<IActionResult> Post([FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient = _mapper.Map<Ingredient>(ingredientDTO)!;

            var ingredientADD = await _repository.Add(ingredient);

            var ingredientADDDTO = _mapper.Map<IngredientDTO>(ingredientADD)!;

            if (ingredientADDDTO != null)
                return CreatedAtAction(nameof(GetById),
                                       new { id = ingredientADDDTO.Id },
                                       new
                                       {
                                           Message = "ingredient Added.",
                                           ingredient = ingredientADDDTO
                                       });

            return BadRequest("Something went wrong...");
        }

        //PUT /ingredients/4
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] IngredientDTO ingredientDTO)
        {
            var ingredientFromDb = await _repository.Get(id);

            if (ingredientFromDb == null)
                return NotFound("There is no ingredient with this Id.");

            ingredientDTO.Id = id; // nécessaire dans le cas où l'id n'est pas ou mal définit dan la requete

            var ingredient = _mapper.Map<Ingredient>(ingredientDTO)!;

            var ingredientUpdated = await _repository.Update(ingredient);

            var ingredientUpdatedDTO = _mapper.Map<IngredientDTO>(ingredientUpdated);

            if (ingredientUpdated != null)
                return Ok(new
                {
                    Message = "ingredient Updated.",
                    ingredient = ingredientUpdatedDTO
                });

            return BadRequest("Something went wrong...");
        }


        //DELETE /ingredients/12
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _repository.Delete(id))
                return Ok("ingredient Deleted");

            //return NotFound("ingredient Not Found");
            return BadRequest("Something went wrong...");
        }


    }
}
