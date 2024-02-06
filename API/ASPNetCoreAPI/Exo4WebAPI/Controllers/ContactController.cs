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
        public IActionResult GetAllContacts(string? chainePrenom, string? chaineNom)
        {
            List<Contact> contacts;

            if (chainePrenom == null && chaineNom == null)
            {
                contacts = _contactRepository.GetAll();
            }
            else
            {
                if (chaineNom != null && chainePrenom != null)
                {
                    contacts = _contactRepository.GetAll(c => c.Prenom.Contains(chainePrenom) && c.Nom.Contains(chaineNom)).ToList();
                }
                else if (chaineNom != null)
                {
                    contacts = _contactRepository.GetAll(c => c.Nom.Contains(chaineNom)).ToList();
                }
                else 
                {
                    contacts = _contactRepository.GetAll(c => c.Prenom.Contains(chainePrenom)).ToList();
                }
            }

            if (contacts == null || contacts.Count == 0)
            {
                return NotFound(new { Message = "Contacts non trouvés !" });
            }

            return Ok(new { Message = "Contacts trouvés !", Contacts = contacts });
        }


        [HttpPost]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            if (contact == null)
            {
                return BadRequest("Contact invalide");
            }

            _contactRepository.Add(contact);

            return CreatedAtAction(nameof(AddContact), new { id = contact.Id }, "Contact ajouté");
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

