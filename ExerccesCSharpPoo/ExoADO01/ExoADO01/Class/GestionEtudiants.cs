using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO01.Class
{
    public class GestionEtudiants
    {
        private string connectionString;

        public GestionEtudiants(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CreerEtudiant()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("La connexion est ouverte!");
                }
                else
                {
                    Console.WriteLine("La connexion n'est pas ouverte :(");
                    return;
                }

                Console.WriteLine("Nom ?");
                string nom = Console.ReadLine() ?? "";
                Console.WriteLine("Prenom ?");
                string prenom = Console.ReadLine() ?? "";
                Console.WriteLine("Numero de classe ?");
                int NumeroDeClasse;
                while (!int.TryParse(Console.ReadLine(), out NumeroDeClasse))
                    Console.WriteLine("Saisie invalide ! Recommence");
                Console.WriteLine("Date du diplome ?");
                string DateDeDiplome = Console.ReadLine() ?? "";

                string reqCreation = $"INSERT INTO etudiant (nom, prenom, Numero_de_classe, Date_de_diplome) VALUES ('{nom}', '{prenom}', '{NumeroDeClasse}', '{DateDeDiplome}')";

                SqlCommand command = new SqlCommand(reqCreation, connection);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} lignes affectées.");

                command.Dispose();

                connection.Close();

                Console.WriteLine("");
            }
        }

        public void AfficherTousEtudiants()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string req = "SELECT id, nom, prenom, Numero_de_classe, Date_de_diplome FROM etudiant;";

                SqlCommand commande = new SqlCommand(req, conn);

                try
                {
                    conn.Open();

                    SqlDataReader reader = commande.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"id : {reader.GetInt32(0)}, nom : {reader.GetString(1)}, prenom : {reader.GetString(2)}, Numero de classe : {reader.GetInt32(3)}, Date de diplome : {reader.GetString(4)}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("");
            }
        }

        public void AfficherEtudiantsClasse()
        {
            Console.WriteLine("Le numéro de la classe ?");
            int Numero_de_classe;
            while (!int.TryParse(Console.ReadLine(), out Numero_de_classe))
                Console.WriteLine("Saisie invalide ! Recommence");

            Console.WriteLine($"Voici tout les étudiant de la classe {Numero_de_classe} :");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string req = "SELECT id, nom, prenom, Numero_de_classe, Date_de_diplome FROM etudiant WHERE Numero_de_classe=@Numero_de_classe;";

                SqlCommand commande = new SqlCommand(req, conn);

                commande.Parameters.AddWithValue("@Numero_de_classe", Numero_de_classe);

                try
                {
                    conn.Open();

                    SqlDataReader reader = commande.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"id : {reader.GetInt32(0)}, nom : {reader.GetString(1)}, prenom : {reader.GetString(2)}, Numero de classe : {reader.GetInt32(3)}, Date de diplome : {reader.GetString(4)}");
                    }

                    if (!reader.HasRows)
                    {
                        Console.WriteLine($"Aucun étudiant trouvé avec le Numero de classe {Numero_de_classe}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("");
            }
        }

        public void SupprimerEtudiant()
        {
            Console.WriteLine("L'id de l'étudiant à supprimer : ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
                Console.WriteLine("Saisie invalide ! Recommence");

            using (SqlConnection connectionSupprime = new SqlConnection(connectionString))
            {
                string reqSelect = "SELECT id, nom, prenom, Numero_de_classe, Date_de_diplome FROM etudiant WHERE id=@id;";
                string reqDelete = "DELETE FROM etudiant WHERE id=@id;";

                connectionSupprime.Open();

                using (SqlCommand commandSelect = new SqlCommand(reqSelect, connectionSupprime))
                {
                    commandSelect.Parameters.AddWithValue("@id", id);

                    try
                    {
                        using (SqlDataReader reader = commandSelect.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine($"id : {reader.GetInt32(0)}, nom : {reader.GetString(1)}, prenom : {reader.GetString(2)}, Numero de classe : {reader.GetInt32(3)}, Date de diplome : {reader.GetString(4)}");
                                Console.WriteLine("Suppression en cours...");

                                Console.Write("Confirmez-vous la suppression de cet étudiant ? (y/n): ");
                                string confirmation = Console.ReadLine();

                                if (confirmation.ToLower() == "y")
                                {
                                    reader.Close();

                                    using (SqlCommand commandDelete = new SqlCommand(reqDelete, connectionSupprime))
                                    {
                                        commandDelete.Parameters.AddWithValue("@id", id);
                                        int rowsAffectedsup = commandDelete.ExecuteNonQuery();
                                        Console.WriteLine($"{rowsAffectedsup} lignes affectées. L'étudiant a été supprimé.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Suppression annulée.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Aucun étudiant trouvé avec l'id {id}");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
