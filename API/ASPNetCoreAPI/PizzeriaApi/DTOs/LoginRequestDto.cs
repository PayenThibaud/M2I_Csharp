﻿using System.ComponentModel.DataAnnotations;

namespace PizzeriaApi.DTOs
{
    public class LoginRequestDTO
    {
        [Required]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        //[PasswordValidator]
        public string? PassWord { get; set; }
    }
}
