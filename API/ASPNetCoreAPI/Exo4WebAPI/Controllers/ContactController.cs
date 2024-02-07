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
        public IActionResult GetAllContacts(string? chainePrenom)
        {
            return Ok(
                _contactRepository.GetAll(c => c.Prenom!.StartsWith(chainePrenom))
                );
        }


        [HttpPost]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            var contactAdded = _contactRepository.Add(contact); 

            if (contactAdded != null)
            {
                return CreatedAtAction(nameof(GetContactById),
                    new { id = contactAdded.Id },
                    "Contact ajouté",
            }

            _contactRepository.Add(contact);

            return CreatedAtAction(nameof(AddContact), new { id = contact.Id }, "Contact ajouté");
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
                    Message = "Contact non trouvée !"
                });

            return Ok(new
            {
                Message = "Contact trouvée !",
                Contact = contact
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] Contact update)
        {
            var contact = _contactRepository.Update(update);

            if (contact == null)
            {
                return NotFound(new
                {
                    Message = $"Le contact avec l'ID '{id}' n'a pas été trouvé."
                });
            }

            return Ok(new
            {
                Message = "Contacts mis à jour !",
                Contact = contact
            });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var contact = _contactRepository.Delete(id);

            if (contact == null)
            {
                return NotFound(new
                {
                    Message = $"Le contact avec l'ID '{id}' n'a pas été trouvé."
                });
            }
            return NoContent();
        }
    }
}

