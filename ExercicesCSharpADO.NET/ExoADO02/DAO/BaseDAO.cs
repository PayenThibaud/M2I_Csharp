using ExoADO02.Class;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO02.DAO
{
    internal abstract class BaseDAO<T>
    {
        protected string request = "";

        public abstract List<T> GetAll();
        public abstract T Save(T element);
        public abstract T Update(T element);
        public abstract void Delete(int id);
        public abstract T? GetOneById(int id);
        public virtual void AddCommandToClient(int clientId, Commande commande)
        {
            using SqlConnection connection = DataConnection.GetConnection;

            request = "UPDATE Commande SET ClientID = @ClientID WHERE ID = @CommandeID;";

            using SqlCommand command = new SqlCommand(request, connection);
            command.Parameters.AddWithValue("@ClientID", clientId);
            command.Parameters.AddWithValue("@CommandeID", commande.Id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}