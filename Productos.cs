using Gestion_de_ventas.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;    

namespace Gestion_de_ventas
{
    public partial class Productos : Form
    {
        private int autoIncrementValue = 0;
        public Productos()
        {
            InitializeComponent();
            mostrarcampos();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Use parameterized query to prevent SQL injection
                    string consulta = "DELETE FROM productos WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        // Add parameter with value
                        comando.Parameters.AddWithValue("@id", Convert.ToInt32(tbid.Text));

                        // Execute the command
                        int rowsAffected = comando.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado exitosamente.", "Éxito");
                            // Optionally, clear the textboxes
                            tbid.Clear();
                            tbnombre.Clear();
                            tbdescrip.Clear();
                            tbprecio.Clear();
                            tbstock.Clear();
                            tbprovee.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            using (RespuestoEntities4 repuesto = new RespuestoEntities4())
            {
                Gestion_de_ventas.Base.Productos produ = new Gestion_de_ventas.Base.Productos
                {
                    id = Convert.ToInt32(tbid.Text),
                    Nombre = tbnombre.Text,
                    Descripcion  = tbdescrip.Text, 
                    Precio = Convert.ToInt32(tbprecio.Text), 
                    Stock = Convert.ToInt32(tbstock.Text),  
                    Proveedor = tbprovee.Text
                };

                repuesto.Productos.Add(produ);
                repuesto.SaveChanges();

                MessageBox.Show("Producto agregado exitosamente", "Exito");
                
            }
            autoIncrementValue++;

            tbid.Text = autoIncrementValue.ToString();
        }



        private void mostrarcampos()
        {
            using (RespuestoEntities4 rep = new RespuestoEntities4())
            {
                IQueryable<Gestion_de_ventas.Base.Productos> uapa = from d in rep.Productos
                                                select d;
                List<Gestion_de_ventas.Base.Productos> lista = uapa.ToList();
                dtabla.DataSource = lista;
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            tbid.Text = autoIncrementValue.ToString();
        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM productos WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", tbid.Text);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                tbid.Text = lector["id"].ToString();
                                tbnombre.Text = lector["Nombre"].ToString();
                                tbdescrip.Text = lector["Descripcion"].ToString();
                                tbprecio.Text = lector["Precio"].ToString();
                                tbstock.Text = lector["Stock"].ToString();
                                tbprovee.Text = lector["Proveedor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado.", "Error");
                            }
                        }
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "UPDATE productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock, Proveedor = @Proveedor WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", tbnombre.Text);
                        comando.Parameters.AddWithValue("@Descripcion", tbdescrip.Text);
                        comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(tbprecio.Text));
                        comando.Parameters.AddWithValue("@Stock", Convert.ToInt32(tbstock.Text));
                        comando.Parameters.AddWithValue("@Proveedor", tbprovee.Text);
                        comando.Parameters.AddWithValue("@id", Convert.ToInt32(tbid.Text));

                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto modificado exitosamente.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

