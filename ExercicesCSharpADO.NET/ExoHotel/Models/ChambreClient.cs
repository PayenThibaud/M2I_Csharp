using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Models
{
    internal class ChambreClient
    {
        public int ChambreId { get; set; }
        public Chambre Chambre { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
