using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_ventas
{
    internal class conexion
    {
        static string Conexionstring = "Server=localhost\\SQLEXPRESS;Database=Respuesto;Integrated Security=True";
        //public static string nombre;

        public int Consultalogin(string usuario, int contrasena)
        {
            int count;
            using (SqlConnection con = new SqlConnection(Conexionstring))
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE usuario = @Usuario AND contrasena = @Contrasena";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                con.Open();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }

        public int Consql(string usuario, int contrasena)
        {
            return Consultalogin(usuario, contrasena);
        }
    }
}
