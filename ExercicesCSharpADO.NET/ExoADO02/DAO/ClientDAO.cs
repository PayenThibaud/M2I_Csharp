using ExoADO02.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExoADO02.DAO
{
    internal class ClientDAO : BaseDAO<Client>
    { 
        public override void Delete(int id)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            string request = "DELETE FROM Client WHERE id = @Id;";

            using SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public override List<Client> GetAll()
        {
            List<Client> clients = new();

            using SqlConnection connection = DataConnection.GetConnection;

            string request = "SELECT id, Nom, Prenom, Adresse, CodePostal, Ville, Telephone FROM Client;";

            using SqlCommand command = new SqlCommand(request, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6)
                );

                clients.Add(client);
            }

            return clients;
        }

        public override Client? GetOneById(int id)
        {
            Client? client = null;

            string request = "SELECT id, Nom, Prenom, Adresse, CodePostal, Ville, Telephone FROM Client WHERE id=@id";

            using SqlConnection connection = DataConnection.GetConnection;

            using SqlCommand command = new SqlCommand(request, connection);

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                client = new Client(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6)
                );
            }

            return client;
        }

        public override Client Save(Client element)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            string request = "INSERT INTO Client (Nom, Prenom, Adresse, CodePostal, Ville, Telephone) OUTPUT INSERTED.ID VALUES (@Nom, @Prenom, @Adresse, @CodePostal, @Ville, @Telephone);";

            using SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.AddWithValue("@Nom", element.Nom);
            command.Parameters.AddWithValue("@Prenom", element.Prenom);
            command.Parameters.AddWithValue("@Adresse", element.Adresse);
            command.Parameters.AddWithValue("@CodePostal", element.CodePostal);
            command.Parameters.AddWithValue("@Ville", element.Ville);
            command.Parameters.AddWithValue("@Telephone", element.Telephone);

            connection.Open();

            element.Id = (int)command.ExecuteScalar();

            return element;
        }

        public override Client Update(Client element)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            string request = "UPDATE Client SET Nom=@Nom, Prenom=@Prenom, Adresse=@Adresse, CodePostal=@CodePostal, Ville=@Ville, Telephone=@Telephone WHERE id=@id;";

            using SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.AddWithValue("@Nom", element.Nom);
            command.Parameters.AddWithValue("@Prenom", element.Prenom);
            command.Parameters.AddWithValue("@Adresse", element.Adresse);
            command.Parameters.AddWithValue("@CodePostal", element.CodePostal);
            command.Parameters.AddWithValue("@Ville", element.Ville);
            command.Parameters.AddWithValue("@Telephone", element.Telephone);
            command.Parameters.AddWithValue("@id", element.Id);

            connection.Open();

            command.ExecuteNonQuery();

            return element;
        }
    }
}

