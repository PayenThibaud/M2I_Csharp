using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO02.DAO
{
    internal class DataConnection
    {
        private static readonly string connectionString = "Data Source=(localdb)\\DDB_Ado; Integrated Security=True; Database=gestionDesCommandes";

        public static SqlConnection GetConnection { get => new(connectionString); }
    }
}