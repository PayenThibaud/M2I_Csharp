using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Models
{
    internal class Hotel
    {
        [Key]
        public int Id { get; set; }

        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Chambre> Chambres { get; set; } = new List<Chambre>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();                     
    }
}
