using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            btnbuscar.Click += new EventHandler(btnbuscar_Click);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'respuestoDataSet.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.respuestoDataSet.Productos);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta;
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;

                    
                    if (int.TryParse(tbbuscar.Text, out int id))
                    {
                        consulta = "SELECT * FROM productos WHERE id = @param";
                        comando.Parameters.AddWithValue("@param", id);
                    }
                    else
                    {
                        consulta = "SELECT * FROM productos WHERE Nombre LIKE '%' + @param + '%'";
                        comando.Parameters.AddWithValue("@param", tbbuscar.Text);
                    }

                    comando.CommandText = consulta;

                    using (SqlDataAdapter adaptar = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adaptar.Fill(dt);
                        Dtable.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
   
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
          
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
