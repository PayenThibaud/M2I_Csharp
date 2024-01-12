using ExoHotel.Class;
using ExoHotel.LINQ;
using ExoHotel.Methode;
using System.Collections.Generic;

Hotel hotel = new Hotel(new List<Client>(), new List<Chambre>(), new List<Reservation>());


Console.Write($"Quel est le nom de l'hôtel ? ");

String NomHotel = Console.ReadLine();
hotel.Chambre = GenerateurChambre.GenererChambres();
Console.WriteLine($"L'Hotel {NomHotel} créé avec sucés !");

bool quitter = false;
while (!quitter)
{
    string choice;
    Console.WriteLine($"=== Menu Principal ===");
    Console.WriteLine("");
    Console.WriteLine("1. Ajouter un client ");
    Console.WriteLine("2. Afficher la liste des clients");
    Console.WriteLine("3. Afficher les réservations d'un client");
    Console.WriteLine("4. Ajouter une réservation");
    Console.WriteLine("5. Annuler une réservation");
    Console.WriteLine("6. Afficher la liste des réservations");
    Console.WriteLine("0. Quitter");
    Console.Write("Faites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            MesMethodes.AjouterClient(hotel);
            break;
        case "2":
            hotel.AfficherClients();
            break;
        case "3":
            MesMethodes.AfficherReservationsClient(hotel.Client, hotel.Reservation);
            break;
        case "4":
            MesMethodes.AjouterReservation(hotel);
            break;
        case "5":
            MesMethodes.AnnulerReservation(hotel);
            break;
        case "6":
            MesMethodes.AfficherListeReservations(hotel.Reservation);
            break;
        case "0":
            quitter = true;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erreur de saisie, recommencez !");
            Console.WriteLine("");
            Console.ResetColor();
            break;
    }
}