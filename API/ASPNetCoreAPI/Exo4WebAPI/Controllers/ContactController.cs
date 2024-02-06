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
        public IActionResult GetAllContacts()
        {
            var contacts = _contactRepository.GetAll();

            if (contacts == null || contacts.Count == 0)
                return NotFound(new
                {
                    Message = "Contacts non trouvée !"
                });

            return Ok(new
            {
                Message = "Contacts trouvée !",
                Contact = contacts
            });
        }

        [HttpPost]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            _contactRepository.Add(contact);

            return CreatedAtAction(nameof(AddContact), new { id = contact.Id }, "Contact ajoutée");
        }


        [HttpGet("name/{nom}")]
        public IActionResult GetContactByNom(string nom)
        {
            var contact = _contactRepository.GetByNom(nom);

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

