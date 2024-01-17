using ExoADO02.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO02.Class
{
    internal class IHM
    {
        public void AfficherMenu()
        {
            Console.WriteLine("   ____                                          _           \r\n  / ___|___  _ __ ___  _ __ ___   __ _ _ __   __| | ___  ___ \r\n | |   / _ \\| '_ ` _ \\| '_ ` _ \\ / _` | '_ \\ / _` |/ _ \\/ __|\r\n | |__| (_) | | | | | | | | | | | (_| | | | | (_| |  __/\\__ \\\r\n  \\____\\___/|_| |_| |_|_| |_| |_|\\__,_|_| |_|\\__,_|\\___||___/");
            Console.WriteLine("1. Afficher les clients");
            Console.WriteLine("2. Créer un client");
            Console.WriteLine("3. Modifier un client");
            Console.WriteLine("4. Supprimer un client");
            Console.WriteLine("5. Afficher les détails d'un client");
            Console.WriteLine("6. Ajouter une commande");
            Console.WriteLine("7. Modifier une commande");
            Console.WriteLine("8. Supprimer une commande");
            Console.WriteLine("0 - Quitter");
        }



        public void Start()
        {
            while (true)
            {
                AfficherMenu();
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AfficherToutClient();
                        break;
                    case "2":
                        CreerClient();
                        break;
                    case "3":
                        ModifierClient();
                        break;
                    case "4":
                        SupprimerClient();
                        break;
                    case "5":
                        AfficherUnClient();
                        break;
                    case "6":
                        AjouterCommande();
                        break;
                    case "7":
                        ModifierCommande();
                        break;
                    case "8":
                        SupprimerCommande();
                        break;
                    case "0":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
        }

        private void AfficherToutClient()
        {
            Console.WriteLine("Affichage de tous les clients:");

            ClientDAO clientDAO = new ClientDAO();

            List<Client> clients = clientDAO.GetAll();

            foreach (Client client in clients)
            {
                Console.WriteLine($"ID: {client.Id}, Nom: {client.Nom}, Prénom: {client.Prenom}, Adresse: {client.Adresse}, Code Postal: {client.CodePostal}, Ville: {client.Ville}, Téléphone: {client.Telephone}");
            }
        }

        private void CreerClient()
        {
            Console.WriteLine("Création d'un nouveau client:");

            Console.Write("Nom: ");
            string nom = Console.ReadLine();

            Console.Write("Prénom: ");
            string prenom = Console.ReadLine();

            Console.Write("Adresse: ");
            string adresse = Console.ReadLine();

            Console.Write("Code Postal: ");
            string codePostal = Console.ReadLine();

            Console.Write("Ville: ");
            string ville = Console.ReadLine();

            Console.Write("Téléphone: ");
            string telephone = Console.ReadLine();

            ClientDAO clientDAO = new ClientDAO();

            Client nouveauClient = new Client(0, nom, prenom, adresse, codePostal, ville, telephone);

            Client clientCree = clientDAO.Save(nouveauClient);

            Console.WriteLine($"Nouveau client créé avec l'ID: {clientCree.Id}");
        }

        private void ModifierClient()
        {
            Console.WriteLine("Modification d'un client:");

            Console.Write("Entrez l'ID du client à modifier: ");
            if (!int.TryParse(Console.ReadLine(), out int clientId))
            {
                Console.WriteLine("ID invalide.");
                return;
            }

            ClientDAO clientDAO = new ClientDAO();

            Client clientAModifier = clientDAO.GetOneById(clientId);

            if (clientAModifier == null)
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {clientId}.");
                return;
            }

            Console.WriteLine("Informations actuelles du client:");
            Console.WriteLine(clientAModifier.ToString());

            Console.WriteLine("Entrez les nouvelles informations:");

            Console.Write("Nouveau nom: ");
            clientAModifier.Nom = Console.ReadLine();

            Console.Write("Nouveau prénom: ");
            clientAModifier.Prenom = Console.ReadLine();

            Console.Write("Nouvelle adresse: ");
            clientAModifier.Adresse = Console.ReadLine();

            Console.Write("Nouveau code postal: ");
            clientAModifier.CodePostal = Console.ReadLine();

            Console.Write("Nouvelle ville: ");
            clientAModifier.Ville = Console.ReadLine();

            Console.Write("Nouveau numéro de téléphone: ");
            clientAModifier.Telephone = Console.ReadLine();

            clientDAO.Update(clientAModifier);

            Console.WriteLine($"Client avec l'ID {clientId} modifié avec succès.");
            Console.WriteLine(clientAModifier.ToString());
        }


        private void SupprimerClient()
        {
            Console.WriteLine("Suppression d'un client:");

            Console.Write("Entrez l'ID du client à supprimer: ");
            if (!int.TryParse(Console.ReadLine(), out int clientId))
            {
                Console.WriteLine("ID invalide.");
                return;
            }

            ClientDAO clientDAO = new ClientDAO();

            Client clientASupprimer = clientDAO.GetOneById(clientId);

            if (clientASupprimer == null)
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {clientId}.");
                return;
            }

            Console.WriteLine("Informations du client à supprimer:");
            Console.WriteLine(clientASupprimer.ToString());


            Console.Write("Confirmez la suppression (Y): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToLower() == "Y")
            {
                clientDAO.Delete(clientId);
                Console.WriteLine($"Client avec l'ID {clientId} supprimé avec succès.");
            }
            else
            {
                Console.WriteLine("Suppression annulée.");
            }
        }

        private void AfficherUnClient()
        {
            Console.WriteLine("Affichage des détails d'un client:");

            Console.Write("Entrez l'ID du client à afficher: ");
            if (!int.TryParse(Console.ReadLine(), out int clientId))
            {
                Console.WriteLine("ID invalide.");
                return;
            }

            ClientDAO clientDAO = new ClientDAO();
            CommandeDAO commandeDAO = new CommandeDAO();

            Client clientAffiche = clientDAO.GetOneById(clientId);

            if (clientAffiche == null)
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {clientId}.");
                return;
            }

            Console.WriteLine("Détails du client:");
            Console.WriteLine(clientAffiche.ToString());

            List<Commande> commandesClient = commandeDAO.GetAllByClient(clientAffiche);

            if (commandesClient.Count > 0)
            {
                Console.WriteLine("Commandes du client:");

                foreach (Commande commande in commandesClient)
                {
                    Console.WriteLine(commande.ToString());
                }
            }
            else
            {
                Console.WriteLine("Le client n'a aucune commande.");
            }
        }


        private void AjouterCommande()
        {

            ClientDAO clientDAO = new ClientDAO();
            CommandeDAO commandeDAO = new CommandeDAO();

            Console.Write("Entrez l'ID du client: ");
            if (!int.TryParse(Console.ReadLine(), out int clientId))
            {
                Console.WriteLine("ID invalide.");
                return;
            }

            Client client = clientDAO.GetOneById(clientId);

            if (client == null)
            {
                Console.WriteLine($"Aucun client trouvé avec l'ID {clientId}.");
                return;
            }

            Console.Write("Entrez la date de la commande (format yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Date invalide.");
                return;
            }

            Console.Write("Entrez le total de la commande: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal total))
            {
                Console.WriteLine("Total invalide.");
                return;
            }

            Commande nouvelleCommande = new Commande(0, total, date);

            nouvelleCommande.Client = client;

            Commande commandeAjoutee = commandeDAO.Save(nouvelleCommande);

            Console.WriteLine($"Nouvelle commande ajoutée avec l'ID: {commandeAjoutee.Id}");
        }


        private void ModifierCommande()
        {

            CommandeDAO commandeDAO = new CommandeDAO();

            Console.WriteLine("Modification d'une commande:");

            Console.Write("Entrez l'ID de la commande à modifier: ");
            if (!int.TryParse(Console.ReadLine(), out int commandeId))
            {
                Console.WriteLine("ID invalide.");
                return;
            }

            Commande commandeAModifier = commandeDAO.GetOneById(commandeId);

            if (commandeAModifier == null)
            {
                Console.WriteLine($"Aucune commande trouvée avec l'ID {commandeId}.");
                return;
            }

            Console.Write("Entrez la nouvelle date de la commande (format yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime nouvelleDate))
            {
                Console.WriteLine("Date invalide.");
                return;
            }

            Console.Write("Entrez le nouveau total de la commande: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal nouveauTotal))
            {
                Console.WriteLine("Total invalide.");
                return;
            }

            commandeAModifier.Date = nouvelleDate;
            commandeAModifier.Total = nouveauTotal;

            commandeAModifier = commandeDAO.Update(commandeAModifier);

            Console.WriteLine($"Commande avec l'ID {commandeId} modifiée avec succès.");
            Console.WriteLine(commandeAModifier.ToString());
        }

        private void SupprimerCommande()
        {
            CommandeDAO commandeDAO = new CommandeDAO();

            Console.WriteLine("Suppression d'une commande:");

            Console.Write("Entrez l'ID de la commande à supprimer: ");
            if (!int.TryParse(Console.ReadLine(), out int commandeId))
            {
                Console.WriteLine("ID invalide.");
                return;
            }

            Commande commandeASupprimer = commandeDAO.GetOneById(commandeId);

            if (commandeASupprimer == null)
            {
                Console.WriteLine($"Aucune commande trouvée avec l'ID {commandeId}.");
                return;
            }

            Console.WriteLine("Informations de la commande à supprimer:");
            Console.WriteLine(commandeASupprimer.ToString());

            Console.Write("Confirmez la suppression (Y): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToLower() == "y")
            {
                commandeDAO.Delete(commandeId);
                Console.WriteLine($"Commande avec l'ID {commandeId} supprimée avec succès.");
            }
            else
            {
                Console.WriteLine("Suppression annulée.");
            }
        }

    }
}
