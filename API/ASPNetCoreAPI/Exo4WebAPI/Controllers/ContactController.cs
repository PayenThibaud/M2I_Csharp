using Exo4WebAPI.Data;
using Exo4WebAPI.Models;
using Exo4WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exo4WebAPI.Controllers
{
    [Route("contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactController(IRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        //public ActionResult<List<Contact>> GetAll()
        public IActionResult GetAll(string? startLastName) // ne pas oublier le "?" pour rendre le request param faculattif
        //public IActionResult GetAll([FromQuery] string? startLastName)
        {
            if (startLastName == null)
                return Ok(_contactRepository.GetAll());

            return Ok(
                //_repository.GetAll(c => c.LastName!.ToLower().StartsWith(startLastName.ToLower()))
                _contactRepository.GetAll(c => c.Nom!.StartsWith(startLastName.ToUpper()))
                );
        }


        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            var contactAdded = _contactRepository.Add(contact);

            if (contactAdded != null)
                //return Ok("Contact Added !");
                //return Created($"/contacts/{createdAtId}", "Contact Added !");
                return CreatedAtAction(nameof(GetContactById),
                                       new { id = contactAdded.Id },
                                       new
                                       {
                                           Message = "Contact Added.",
                                           Contact = contactAdded
                                       });

            return BadRequest("Something went wrong...");
        }


        [HttpGet("name/{prenom}")]
        public IActionResult GetContactByPrenom(string prenom)
        {
            var contact = _contactRepository.Get(c => c.Prenom == prenom);

            if (contact == null)
                return NotFound(new
                {
                    Message = "Contact non trouvée !"
                });

            return Ok(new
            {
                Message = "Contact trouvée !",
                Contact = contact
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(int id)
        {
            var contact = _contactRepository.GetById(id);


            if (contact == null)
                return NotFound(new
                {
                    Message = "There is no Contact with this Id."
                });
            //return NotFound("There is no Contact with this Id.");
            //return NotFound();

            return Ok(new
            {
                Message = "Contact found.",
                Contact = contact
            });
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Contact contact)
        //public IActionResult Put([FromBody] Contact contact) // ici l'id serait dans le contact
        {
            var contactFromDb = _contactRepository.GetById(id);

            if (contactFromDb == null)
                return NotFound("There is no Contact with this Id.");

            contact.Id = id; // nécessaire dans le cas où l'id n'est pas ou mal définit dan la requete

            var contactUpdated = _contactRepository.Update(contact);

            if (contactUpdated != null)
                return Ok(new
                {
                    Message = "Contact Updated.",
                    Contact = contactUpdated
                });

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            {
                if (_contactRepository.Delete(id))
                    return Ok("Contect Deleted");

                //return NotFound("Contact Not Found");
                return BadRequest("Something went wrong...");
            }
        }
    }
}

