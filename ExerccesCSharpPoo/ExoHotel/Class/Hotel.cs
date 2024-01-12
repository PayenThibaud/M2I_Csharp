using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Class
{
    internal class Hotel
    {
        private List<Client> _clients;
        private List<Chambre> _chambres;
        private List<Reservation> _reservations;


        internal List<Client> Client { get => _clients; set => _clients = value; }
        internal List<Chambre> Chambre { get => _chambres; set => _chambres = value; }
        internal List<Reservation> Reservation { get => _reservations; set => _reservations = value; }


        internal Hotel(List<Client> client, List<Chambre> chambre, List<Reservation> reservation)
        {
            _clients = client;
            _chambres = chambre;
            _reservations = reservation;
        }

        public void AjouterClient(Client client)
        {
            _clients.Add(client);
        }


        public void AfficherClients()
        {
            Console.WriteLine("=== Liste des Clients ===");
            foreach (var client in _clients)
            {
                Console.WriteLine(client);
                Console.WriteLine("------------------------");
            }
        }
    }
}
