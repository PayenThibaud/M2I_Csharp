using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Models
{

    internal enum StatutChambre
    {
        Libre,
        Occupe,
        Nettoyage
    }

    internal enum StatutReservation
    {
        Prevu,
        EnCours,
        Fini,
        Annule
    }

}
