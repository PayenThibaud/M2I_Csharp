using System.ComponentModel.DataAnnotations;

namespace PizzeriaApi.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        public string? Email { get; set; }
    }
}
