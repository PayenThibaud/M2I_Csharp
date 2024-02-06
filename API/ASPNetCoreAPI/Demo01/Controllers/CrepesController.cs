using Demo01.Data;
using Demo01.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrepesController : ControllerBase
    {
        private readonly CrepeFakeDb _fakeDb;
        public CrepesController(CrepeFakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var crepes = _fakeDb.Crepes;

            if (crepes.Any())
            {
                return Ok(crepes);
            }
            return NotFound();
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            var crepe = _fakeDb.Crepes.FirstOrDefault(x => x.Id == id);

            if (crepe == null)
            {
                return NotFound(new
                {
                    Message = "Crepe non trouvée !"
                });
            }
            return Ok(new
            {
                Message = "Crepe trouvée !",
                Crepe = crepe
            });
        }
        [HttpPost]
        public IActionResult Post([FromBody] Crepe crepe)
        {
            _fakeDb.Crepes.Add(crepe);

            return CreatedAtAction(nameof(Get), crepe.Id, "Crepe ajoutée");
        }
    }
}
