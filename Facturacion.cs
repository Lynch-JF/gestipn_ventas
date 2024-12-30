using Gestion_de_ventas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas
{
    public partial class Facturacion : Form
    {
        float precio = 0;
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'respuestoDataSet1.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.respuestoDataSet1.Ventas);
            lblfecha.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            lblprecio.Text = (0).ToString("C");
            CargarProductos();

            tbpagos.Items.Add("Contado");
            tbpagos.Items.Add("Credito");
            tbpagos.Items.Add("Transferencia");
            tbpagos.Items.Add("Tarjeta C o D");

            // Seleccionar una opción por defecto si lo deseas
            tbpagos.SelectedIndex = 0;
        }


        private void CargarProductos()
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT id, Nombre FROM Productos";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Asigna los datos al ComboBox
                        tbproductos.DisplayMember = "Nombre";
                        tbproductos.ValueMember = "id"; 
                        tbproductos.DataSource = dt;
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

        private void CargarPrecioProducto(int productoId)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT Precio FROM Productos WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", productoId);
                        object result = comando.ExecuteScalar();
                        if (result != null)
                        {
                            precio = Convert.ToSingle(result);
                            lblprecio.Text = precio.ToString("C");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al cargar el precio: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }




        private void tbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbproductos.SelectedValue != null)
            {
                int productoId = Convert.ToInt32(tbproductos.SelectedValue);
                CargarPrecioProducto(productoId);
            }
        }

        private void tbcantidad_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(tbcantidad.Text, out float cantidad))
            {
                float total = cantidad * precio;
                lblprecio.Text = total.ToString("C");
            }
            else
            {
                lblprecio.Text = (0).ToString("C");
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime fecha;
                bool fechaValida = DateTime.TryParseExact(lblfecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);
                if (!fechaValida)
                {
                    MessageBox.Show("Formato de fecha incorrecto. Por favor, use el formato dd/MM/yyyy.", "Error");
                    return;
                }

                double precioTotal;
                bool precioValido = Double.TryParse(lblprecio.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out precioTotal);
                if (!precioValido)
                {
                    MessageBox.Show("Formato de precio incorrecto.", "Error");
                    return;
                }

                using (RespuestoEntities4 repuesto = new RespuestoEntities4())
                {
                    Gestion_de_ventas.Base.Ventas venta = new Gestion_de_ventas.Base.Ventas
                    {
                        Productos = tbproductos.Text,
                        Fecha = fecha,
                        Cliente = tbcliente.Text,
                        Forma_pago = tbpagos.Text,
                        Precio_total = precioTotal
                    };

                    repuesto.Ventas.Add(venta);
                    repuesto.SaveChanges();

                    MessageBox.Show("Venta agregada exitosamente", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error");
            }

        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbventas_Enter(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "UPDATE Ventas SET Precio_total = @Precio, Forma_pago = @FormaPago WHERE Productos = @Productos";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Productos", tbproductos.Text);
                        comando.Parameters.AddWithValue("@FormaPago", tbpagos.Text);

                        // Elimina el símbolo de dólar y cualquier espacio en blanco
                        string precioTexto = lblprecio.Text.Replace("$", "").Trim();

                        // Verifica que precioTexto sea un valor numérico válido
                        if (decimal.TryParse(precioTexto, out decimal precioTotal))
                        {
                            comando.Parameters.AddWithValue("@Precio", precioTotal);

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
                        else
                        {
                            MessageBox.Show("El valor del precio total no es válido.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IJKDO29\\SQLEXPRESS;Database=Respuesto;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Ventas WHERE id = @Clientes";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Clientes", tbcliente.Text);

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                tbcliente.Text = lector["Cliente"].ToString();
                                lblprecio.Text = lector["Precio_total"].ToString();
                                tbproductos.Text = lector["Productos"].ToString();
                                tbpagos.Text = lector["Forma_pago"].ToString();
                               
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
    }
}
