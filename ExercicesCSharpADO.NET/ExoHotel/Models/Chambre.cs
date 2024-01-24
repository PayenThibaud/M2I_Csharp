using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Models
{
    internal class Chambre
    {
        [Key]
        public int Numero { get; set; }
        public StatutChambre Statut { get; set; }
        public int NombreLits { get; set; }

        [Precision(14, 2)]
        public decimal Tarif { get; set; }
        public List<ReservationChambre> ReservationChambres { get; set; } = new List<ReservationChambre>();
    }

}
