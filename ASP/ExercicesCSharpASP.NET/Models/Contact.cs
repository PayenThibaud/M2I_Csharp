using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExercicesCSharpASP.NET.Models
{
    public class Contact
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phoneNumber;
        private string _address;
        private string _city;
        private string _region;
        private string _postalCode;
        private string _country;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string Region { get => _region; set => _region = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string Country { get => _country; set => _country = value; }

        public Contact(int id,string name, string email, string phoneNumber, string address, string city, string region, string postalCode, string country)
        {
            _id = id;
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
            _address = address;
            _city = city;
            _region = region;
            _postalCode = postalCode;
            _country = country;
        }
    }
}
     