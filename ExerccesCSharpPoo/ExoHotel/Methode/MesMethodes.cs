using ExoHotel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Methode
{
    internal static class MesMethodes
    {
        public static void AjouterClient(Hotel hotel)
        {
            Console.WriteLine("=== Ajout d'un client ===");

            Console.Write("Veuillez saisir le nom du client : ");
            string nomClient = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom du client : ");
            string prenomClient = Console.ReadLine();

            Console.Write("Veuillez saisir le numéro de téléphone du client : ");
            string telClient = Console.ReadLine();

            Client nouveauClient = new Client(nomClient, prenomClient, telClient);

            // Ajouter le nouveau client à la liste des clients de l'hotel
            hotel.Client.Add(nouveauClient);
        }

        public static void AfficherReservationsClient(List<Client> clients, List<Reservation> reservations)
        {
            Console.WriteLine("=== Afficher les réservations d'un client ===");

            Console.Write("Veuillez saisir le nom du client : ");
            string nomClient = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom du client : ");
            string prenomClient = Console.ReadLine();

            // Recherche du client dans la liste de l'hotel
            Client client = clients.FirstOrDefault(c => c.Nom == nomClient && c.Prenom == prenomClient);

            if (client != null)
            {
                Console.WriteLine($"=== Réservations de {client.Nom} {client.Prenom} ===");

                foreach (var reservation in reservations)
                {
                    if (reservation.Client == client)
                    {
                        Console.WriteLine($"Numéro de réservation : {reservation.Id}");
                        Console.WriteLine($"Statut de la réservation : {reservation.StatutReservation}");

                        foreach (var chambre in reservation.Chambre)
                        {
                            Console.WriteLine($"Numéro de chambre : {chambre.Numero}");
                            // Ajoutez d'autres informations de chambre selon vos besoins
                        }

                        Console.WriteLine("------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("Client non trouvé.");
            }
        }

        public static void AjouterReservation(Hotel hotel)
        {
            Console.WriteLine("=== Ajout d'une réservation ===");

            Console.Write("Veuillez saisir le nom du client : ");
            string nomClient = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom du client : ");
            string prenomClient = Console.ReadLine();

            // Recherche du client dans la liste de l'hotel
            Client client = hotel.Client.FirstOrDefault(c => c.Nom == nomClient && c.Prenom == prenomClient);

            if (client != null)
            {
                Console.Write("Veuillez saisir le numéro de chambre : ");
                if (int.TryParse(Console.ReadLine(), out int numeroChambre))
                {
                    // Recherche de la chambre dans la liste de l'hotel
                    Chambre chambre = hotel.Chambre.FirstOrDefault(c => c.Numero == numeroChambre);

                    if (chambre != null)
                    {
                        // Vérification du statut de la chambre
                        if (chambre.Statut != StatutChambre.OCCUPE && chambre.Statut != StatutChambre.NETTOYAGE)
                        {
                            // Création de la réservation
                            Reservation nouvelleReservation = new Reservation(StatutReservation.PREVU, new List<Chambre> { chambre }, client);

                            // Ajout de la réservation à la liste des réservations de l'hotel
                            hotel.Reservation.Add(nouvelleReservation);

                            Console.WriteLine($"Réservation ajoutée avec succès pour {client.Nom} {client.Prenom} dans la chambre {chambre.Numero}.");
                        }
                        else
                        {
                            Console.WriteLine("Impossible de réserver une chambre occupée ou réservée.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Chambre non trouvée.");
                    }
                }
                else
                {
                    Console.WriteLine("Numéro de chambre invalide.");
                }
            }
            else
            {
                Console.WriteLine("Client non trouvé.");
            }
        }



        public static void AnnulerReservation(Hotel hotel)
        {
            Console.WriteLine("=== Annulation d'une réservation ===");

            Console.Write("Veuillez saisir le nom du client : ");
            string nomClient = Console.ReadLine();

            Console.Write("Veuillez saisir le prénom du client : ");
            string prenomClient = Console.ReadLine();

            // Recherche du client dans la liste de l'hotel
            Client client = hotel.Client.FirstOrDefault(c => c.Nom == nomClient && c.Prenom == prenomClient);

            if (client != null)
            {
                Console.Write("Veuillez saisir le numéro de chambre à annuler : ");
                if (int.TryParse(Console.ReadLine(), out int numeroChambre))
                {
                    // Recherche de la réservation correspondante
                    Reservation reservation = hotel.Reservation.FirstOrDefault(r => r.Client == client && r.Chambre.Any(ch => ch.Numero == numeroChambre));

                    if (reservation != null)
                    {
                        // Suppression de la réservation de la liste des réservations de l'hotel
                        hotel.Reservation.Remove(reservation);

                        Console.WriteLine($"Réservation annulée avec succès pour {client.Nom} {client.Prenom} dans la chambre {numeroChambre}.");
                    }
                    else
                    {
                        Console.WriteLine("Réservation non trouvée.");
                    }
                }
                else
                {
                    Console.WriteLine("Numéro de chambre invalide.");
                }
            }
            else
            {
                Console.WriteLine("Client non trouvé.");
            }
        }
        public static void AfficherListeReservations(List<Reservation> reservations)
        {
            Console.WriteLine("=== Liste des Réservations ===");

            if (reservations.Count > 0)
            {
                foreach (var reservation in reservations)
                {
                    Console.WriteLine($"Numéro de réservation : {reservation.Id}");
                    Console.WriteLine($"Statut de la réservation : {reservation.StatutReservation}");
                    Console.WriteLine($"Client : {reservation.Client.Nom} {reservation.Client.Prenom}");

                    Console.Write("Chambres : ");
                    foreach (var chambre in reservation.Chambre)
                    {
                        Console.Write($"{chambre.Numero} ");
                    }

                    Console.WriteLine("\n------------------------");
                }
            }
            else
            {
                Console.WriteLine("Aucune réservation trouvée.");
            }
        }
    }
}