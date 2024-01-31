using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExercicesCSharpASP.NET.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "Nom")]
        public string Name { get; set; }

        [Display(Name = "Adresse Mail")]
        public string Email { get; set; }

        [Display(Name = "Numéro de tel")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adresse")]
        public string Address { get; set; }

        [Display(Name = "Ville")]
        public string City { get; set; }

        [Display(Name = "Région")]
        public string Region { get; set; }

        [Display(Name = "Code postal")]
        public string PostalCode { get; set; }

        [Display(Name = "Pays")]
        public string Country { get; set; }


    }
}
     