using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectDatabase
{
    class ConnectDB
    {
        string ConnectionString = @"Data Source=pc19;Initial Catalog=eStore20;Integrated Security=True";

        public void InsertQuery(string Query) 
        {
            SqlConnection Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd = new SqlCommand(Query, Cnn);
            cmd.ExecuteNonQuery();
            Cnn.Close();
        }
        public SqlDataReader SelectQuery(string Query)
        {
            SqlConnection Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
            SqlCommand cmd = new SqlCommand(Query, Cnn);
            SqlDataReader res = cmd.ExecuteReader();
            return res;
        }
    }
}
