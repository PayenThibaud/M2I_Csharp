using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumeroTelephone { get; set; }
        public List<Reservation> Reservations { get; set; } = new();
    }
}
