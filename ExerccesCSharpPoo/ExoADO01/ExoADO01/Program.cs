using Azure.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\DDB_ExoADO01; Initial Catalog=contactDB; Integrated Security=True; Connect Timeout=30; Encrypt=True; Trust Server Certificate=False; Application Intent=ReadWrite; Multi Subnet Failover=False";

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

            // Utilisation de paramètres pour éviter les attaques par injection SQL
            string req = "INSERT INTO etudiant (nom, prenom, Numero_de_classe, Date_de_diplome) " +
                         "VALUES (@Nom, @Prenom, @NumeroDeClasse, @DateDeDiplome)";

            using (SqlCommand command = new SqlCommand(req, connection))
            {
                // Ajout des paramètres
                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@NumeroDeClasse", NumeroDeClasse);
                command.Parameters.AddWithValue("@DateDeDiplome", DateDeDiplome);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} lignes affectées.");
            }
        }
    }
}
