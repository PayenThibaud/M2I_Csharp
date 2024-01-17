using ExoADO02.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO02.DAO
{
    internal class CommandeDAO : BaseDAO<Commande>
    {
        public override void Delete(int id)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            request = "DELETE FROM Commandes WHERE id = @Id;";

            using SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public override List<Commande> GetAll()
        {
            List<Commande> commandes = new();

            using SqlConnection connection = DataConnection.GetConnection;

            request = "SELECT id, ClientID, Date, Total FROM Commandes;";

            using SqlCommand command = new SqlCommand(request, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Commande commande = new Commande(reader.GetInt32(0), reader.GetDecimal(1), reader.GetDateTime(2));

                if (!reader.IsDBNull(3))
                {
                    ClientDAO clientDAO = new ClientDAO();
                    commande.Client = clientDAO.GetOneById(reader.GetInt32(3));
                }

                commandes.Add(commande);
            }

            return commandes;
        }

        public override Commande? GetOneById(int id)
        {
            Commande? commande = null;

            request = "SELECT id, ClientID, Date, Total FROM Commandes WHERE id=@id";

            using SqlConnection connection = DataConnection.GetConnection;

            using SqlCommand command = new SqlCommand(request, connection);

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                commande = new Commande(reader.GetInt32(0), Convert.ToDecimal(reader.GetValue(1)), reader.GetDateTime(2));

                if (!reader.IsDBNull(3))
                {
                    ClientDAO clientDAO = new ClientDAO();
                    commande = new Commande(reader.GetInt32(0), Convert.ToDecimal(reader.GetValue(1)), reader.GetDateTime(2));
                }

            }

            return commande;
        }

        public override Commande Save(Commande element)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            using SqlCommand command = new SqlCommand();

            if (element.Client is null)
            {
                request = "INSERT INTO Commandes (Date, Total) OUTPUT INSERTED.ID VALUES (@Date, @Total);";
                command.CommandText = request;
            }
            else
            {
                request = "INSERT INTO commandes (Date, Total, ClientID) OUTPUT INSERTED.ID VALUES (@Date, @Total, @ClientID);";
                command.CommandText = request;
                command.Parameters.AddWithValue("@ClientID", element.Client.Id);
            }

            command.Parameters.AddWithValue("@Date", element.Date);
            command.Parameters.AddWithValue("@Total", element.Total);

            command.Connection = connection;

            connection.Open();

            element.Id = (int)command.ExecuteScalar();

            return element;
        }

        public override Commande Update(Commande element)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            using SqlCommand command = new SqlCommand();

            if (element.Client is null)
            {
                request = "UPDATE commandes SET Date=@Date, Total=@Total WHERE id=@id;";
                command.CommandText = request;
            }
            else
            {
                request = "UPDATE commandes SET Date=@Date, Total=@Total, ClientID=@ClientID WHERE id=@id;"; ;
                command.CommandText = request;
                command.Parameters.AddWithValue("@ClientID", element.Client.Id);
            }

            command.Parameters.AddWithValue("@Date", element.Date);
            command.Parameters.AddWithValue("@Total", element.Total);
            command.Parameters.AddWithValue("@id", element.Id);

            command.Connection = connection;

            connection.Open();

            command.ExecuteNonQuery();

            return element;
        }

        public List<Commande> GetAllByClient(Client client)
        {
            List<Commande> commandes = new();

            using SqlConnection connection = DataConnection.GetConnection;

            request = "SELECT id, ClientID, Date, Total FROM Commandes WHERE ClientID=@ClientID;";

            using SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.AddWithValue("@ClientID", client.Id);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Commande commande = new Commande(reader.GetInt32(0), Convert.ToDecimal(reader.GetValue(1)), reader.GetDateTime(2));
                commande.Client = client;

                commandes.Add(commande);
            }

            return commandes;
        }
    }
}
