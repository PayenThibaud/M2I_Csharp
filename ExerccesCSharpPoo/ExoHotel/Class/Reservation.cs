using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Class
{
    internal class Reservation
    {
        private static int _counter = 0;

        private int _id;
        private StatutReservation _statutReservation;
        private List<Chambre> _chambre;
        private Client _client;

        public int Id { get => _id; set => _id = value; }
        internal StatutReservation StatutReservation { get => _statutReservation; set => _statutReservation = value; }
        internal List<Chambre> Chambre { get => _chambre; set => _chambre = value; }
        internal Client Client { get => _client; set => _client = value; }


        public Reservation(StatutReservation statutReservation, List<Chambre> chambre, Client client)
        {
            _id = ++_counter;
            _statutReservation = statutReservation;
            _chambre = chambre;
            _client = client;
        }
    }
}
