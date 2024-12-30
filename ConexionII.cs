using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_ventas
{
    public static class ConexionII
    {
        private static string connectionString = "Data Source=SERVIDOR;Initial Catalog=TU_BASE_DE_DATOS;Integrated Security=True;";

        public static DataSet ExecuteQuery(string query)
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones adecuadamente
                Console.WriteLine("Error: " + ex.Message);
            }

            return dataSet;
        }
    }
}
   


