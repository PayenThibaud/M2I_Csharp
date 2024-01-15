using Microsoft.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\DDB_Ado;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

SqlConnection connection = new SqlConnection(connectionString);

connection.Open();

if (connection.State == System.Data.ConnectionState.Open)
{
    Console.WriteLine("Sa marche !");
}    
else { Console.WriteLine("Help ! ):");
};

Console.WriteLine("Saisie ton Prenom");
string prenom = Console.ReadLine() ?? "";
Console.WriteLine("Saisie ton Nom");
string nom = Console.ReadLine() ?? "";
Console.WriteLine("Saisie ton email");
string email = Console.ReadLine() ?? "";

string req = $"INSERT INTO personne (prenom, nom, email) VALUES ('{prenom}',' {nom}' , '{email}')";

SqlCommand command = new SqlCommand(req, connection);

int rowsAffected = command.ExecuteNonQuery();

Console.WriteLine(rowsAffected);

command.Dispose();

connection.Close();