using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PizzeriaApi.Models;
using PizzeriaApi.Repositories;
using AutoMapper;
using PizzeriaApi.DTOs;
using System.Reflection.Metadata;
using PizzeriaApi.Helpers;

namespace PizzeriaApi.Controllers
{
    [Route("pizzas")]
    [ApiController]
    [Authorize]
    public class PizzaController : ControllerBase
    {
        private readonly IRepository<Pizza> _repository;
        private readonly IMapper _mapper;

        public PizzaController(IRepository<Pizza> repository,
                                 IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET /pizzas
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //return Ok(_repository.GetAll());
            IEnumerable<Pizza> pizzas = await _repository.GetAll();

            IEnumerable<PizzaDTO> pizzaDTOs = _mapper.Map<IEnumerable<PizzaDTO>>(pizzas)!;
            //IEnumerable<pizzaDTO> pizzaDTOs = _mapper.Map<IEnumerable<pizza>, IEnumerable<pizzaDTO>>(pizzas)!;

            // possible d'ajouter des modification par rapport aux DTOs ici

            return Ok(pizzaDTOs);
        }

        //GET /pizzas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pizza = await _repository.Get(id);

            if (pizza == null)
                return NotFound(new
                {
                    Message = "There is no Pizza with this Id."
                });

            PizzaDTO pizzaDTO = _mapper.Map<PizzaDTO>(pizza)!;

            return Ok(new
            {
                Message = "Pizza found.",
                Pizza = pizzaDTO
            });
        }

        //POST /pizzas
        [HttpPost]
        [Authorize(Roles = Constants.RoleAdmin)]
        public async Task<IActionResult> Post([FromBody] PizzaDTO pizzaDTO)
        {
            var pizza = _mapper.Map<Pizza>(pizzaDTO)!;

            var pizzaADD = await _repository.Add(pizza);

            var pizzaADDDTO = _mapper.Map<PizzaDTO>(pizzaADD)!;

            if (pizzaADDDTO != null)
                return CreatedAtAction(nameof(GetById),
                                       new { id = pizzaADDDTO.Id },
                                       new
                                       {
                                           Message = "Pizza Added.",
                                           Pizza = pizzaADDDTO
                                       });

            return BadRequest("Something went wrong...");
        }

        //PUT /pizzas/4
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PizzaDTO pizzaDTO)
        {
            var pizzaFromDb = await _repository.Get(id);

            if (pizzaFromDb == null)
                return NotFound("There is no Pizza with this Id.");

            pizzaDTO.Id = id; // nécessaire dans le cas où l'id n'est pas ou mal définit dan la requete

            var pizza = _mapper.Map<Pizza>(pizzaDTO)!;

            var pizzaUpdated = await _repository.Update(pizza);

            var pizzaUpdatedDTO = _mapper.Map<PizzaDTO>(pizzaUpdated);

            if (pizzaUpdated != null)
                return Ok(new
                {
                    Message = "Pizza Updated.",
                    Pizza = pizzaUpdatedDTO
                });

            return BadRequest("Something went wrong...");
        }


        //DELETE /pizzas/12
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _repository.Delete(id))
                return Ok("Pizza Deleted");

            //return NotFound("pizza Not Found");
            return BadRequest("Something went wrong...");
        }


    }
}