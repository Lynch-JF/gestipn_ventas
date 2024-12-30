using Gestion_de_ventas.Base;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            mostrar();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            
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


                    if (long.TryParse(tbbuscar.Text, out long Cedula))
                    {
                        consulta = "SELECT * FROM Clientes WHERE Cedula= @param";
                        comando.Parameters.AddWithValue("@param", Cedula);
                    }
                    else
                    {
                        consulta = "SELECT * FROM Clientes WHERE Nombre LIKE '%' + @param + '%'";
                        comando.Parameters.AddWithValue("@param", tbbuscar.Text);
                    }

                    comando.CommandText = consulta;



                    using (SqlDataAdapter adaptar = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adaptar.Fill(dt);
                        dtb.DataSource = dt;


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

        private void tbregister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbnombre.Text) ||
    string.IsNullOrWhiteSpace(tbapellido.Text) ||
    string.IsNullOrWhiteSpace(tbcedula.Text) ||
    string.IsNullOrWhiteSpace(tbtelefono.Text) ||
    string.IsNullOrWhiteSpace(tbaddress.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }


            if (  tbcedula.Text.Length !=11  || !long.TryParse(tbcedula.Text, out long cedula))
            {
                MessageBox.Show("El formato de la cédula es incorrecto. Debe ser un número entero.", "Error");
                return;
            }

            try
            {
                using (RespuestoEntities4 repuesto = new RespuestoEntities4())
                {
                    Gestion_de_ventas.Base.Clientes user = new Gestion_de_ventas.Base.Clientes
                    {
                        Nombre = tbnombre.Text,
                        Apellido = tbapellido.Text,
                        Cedula = (int)cedula, // El valor ya está validado y convertido a int
                        Telefono = tbtelefono.Text,
                        Direccion = tbaddress.Text
                    };

                    repuesto.Clientes.Add(user);
                    repuesto.SaveChanges();

                    MessageBox.Show("Usuario registrado exitosamente", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el usuario: {ex.Message}", "Error");
            }
        }

        private void mostrar()
        {
            using (RespuestoEntities4 rep = new RespuestoEntities4())
            {
                IQueryable<Gestion_de_ventas.Base.Clientes> uapa = from d in rep.Clientes
                                                                       select d;
                List<Gestion_de_ventas.Base.Clientes> lista = uapa.ToList();
                dtb.DataSource = lista;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(tbnombre.Text) ||
      string.IsNullOrWhiteSpace(tbapellido.Text) ||
      string.IsNullOrWhiteSpace(tbcedula.Text) ||
      string.IsNullOrWhiteSpace(tbtelefono.Text) ||
      string.IsNullOrWhiteSpace(tbaddress.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error");
                return;
            }

            if (tbcedula.Text.Length != 11 || !long.TryParse(tbcedula.Text, out long cedula))
            {
                MessageBox.Show("El formato de la cédula es incorrecto. Debe ser un número de 11 dígitos.", "Error");
                return;
            }



            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "UPDATE Clientes SET  Apellido = @Apellido, Cedula = @Cedula, Telefono = @Telefono, Direccion = @Direccion WHERE Nombre = @Nombre";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Apellido", tbapellido.Text);
                        comando.Parameters.AddWithValue("@Cedula", cedula);
                        comando.Parameters.AddWithValue("@Telefono", tbtelefono.Text);
                        comando.Parameters.AddWithValue("@Direccion", tbaddress.Text);
                        comando.Parameters.AddWithValue("@Nombre", tbnombre.Text);

                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente modificado exitosamente.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.", "Error");
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
    }
}
