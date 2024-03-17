using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ContactApiDTOAsync.Helpers;
using System.ComponentModel;
using ContactApiDTOAsync.Validator;


namespace ContactApiDTOAsync.Models
{
    public class User
    {

        [Column("id)")]
        public string Id { get; set; }

        [Column("firsname)")]
        [Required]
        public string FirstName { get; set; }

        [Column("lastname)")]
        [Required]
        public string LastName { get; set; }

        [Required]
        public bool isAdmin { get; set; } = false;

        [Required]
        public string Email { get; set; }

        [PasswordValidator]
        [Required]
        public string Password { get; set; }
    }
}
