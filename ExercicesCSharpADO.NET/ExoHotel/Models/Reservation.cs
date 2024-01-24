using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Models
{
    internal class Reservation
    {
        public int Id { get; set; }
        public StatutReservation Statut { get; set; }
        public List<Chambre> Chambres { get; set; }
        public Client Client { get; set; }
    }
}
