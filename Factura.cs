using Gestion_de_ventas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_ventas
{
    public partial class Factura : Form
    {

        float precio = 0;
        private int autoIncrementValue = 0;

        public Factura()
        {
            InitializeComponent();
            lblprecioU.TextChanged += tbcantidad_TextChanged;

        }

        private void Factura_Load(object sender, EventArgs e)
        {

            lblfecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CargarProductos();
            lblprecio.Text = (0).ToString("C");
            lblprecioU.Text = (0).ToString("C");


            tbpagos.Items.Add("Contado");
            tbpagos.Items.Add("Credito");
            tbpagos.Items.Add("Transferencia");
            tbpagos.Items.Add("Tarjeta C o D");

            // Seleccionar una opción por defecto si lo deseas
            tbpagos.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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


                    if (long.TryParse(tbuser.Text, out long Cedula))
                    {
                        consulta = "SELECT * FROM Clientes WHERE Cedula= @param";
                        comando.Parameters.AddWithValue("@param", Cedula);
                    }
                    else
                    {
                        consulta = "SELECT * FROM Clientes WHERE Nombre LIKE '%' + @param + '%'";
                        comando.Parameters.AddWithValue("@param", tbuser.Text);
                    }

                    comando.CommandText = consulta;

                    using (SqlDataAdapter adaptar = new SqlDataAdapter(comando))
                    {
                        DataTable dt = new DataTable();
                        adaptar.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Asigna los valores a las etiquetas
                            DataRow row = dt.Rows[0];
                            lbluser.Text = row["Nombre"].ToString();
                            
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.", "Información");
                            lbluser.Text = string.Empty;
                          
                            // Limpia las etiquetas adicionales si es necesario
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

        private void textBox2_TextChanged(object sender, EventArgs e)
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

                    // Inicializar tbid en 0 si está vacío o nulo
                    if (string.IsNullOrEmpty(tbidproducto.Text))
                    {
                        tbidproducto.Text = "0";
                    }

                    string consulta = "SELECT * FROM Productos WHERE id = @id";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        if (int.TryParse(tbidproducto.Text, out int id))
                        {
                            comando.Parameters.AddWithValue("@id", id);

                            Console.WriteLine($"Valor de @id: {id}"); // Agregar mensaje de depuración

                            using (SqlDataReader lector = comando.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    Console.WriteLine("Leyendo datos..."); // Agregar mensaje de depuración

                                    lblproductos.Text = lector["Nombre"]?.ToString();
                                    lblprecioU.Text = lector["Precio"]?.ToString();
                                    lblprovee.Text = lector["Proveedor"]?.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Producto no encontrado.", "Error");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un ID válido.", "Error");
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error en la base de datos: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
                tbcantidad.TextChanged += tbcantidad_TextChanged;
            }
        }



        private void CargarProductos()
        {
            
        }





        private void tbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (lblproductos.Text != string.Empty && lblprecioU.Text != string.Empty)
            {
                Producto producto = new Producto();
                producto.Id = int.Parse(tbidproducto.Text);
                producto.Nombre = lblproductos.Text;
                producto.PrecioUnitario = decimal.Parse(lblprecioU.Text);
                producto.Cantidad = int.Parse(tbcantidad.Text);

                listaFacturacion.Add(producto);

                dtfactura.Rows.Add(producto.Nombre, producto.Cantidad, producto.PrecioUnitario, producto.Cantidad * producto.PrecioUnitario);

            }
            else
            {
                MessageBox.Show("Seleccione un producto válido.", "Error");
            }
        }
        private List<Producto> listaFacturacion = new List<Producto>();

        private void btneditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
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

                using (RespuestoEntities4 repuesto = new RespuestoEntities4())
                {
                    foreach (var producto in listaFacturacion)
                    {
                         Gestion_de_ventas.Base.Compras compra = new Gestion_de_ventas.Base.Compras
                        {
                            id = producto.Id,
                            Fecha = fecha,
                            Productos = producto.Nombre,
                            Proveedor = lblprovee.Text,
                            Precio_total = (double)(producto.Cantidad * producto.PrecioUnitario),
                            Forma_pago = tbpagos.Text,
                            Cantidad = producto.Cantidad
                        };

                         repuesto.Compras.Add(compra);

                         var productoInventario = repuesto.Productos.FirstOrDefault(p => p.id == producto.Id);
                        if (productoInventario != null)
                        {
                             productoInventario.Stock -= producto.Cantidad;

                             if (productoInventario.Stock < 0)
                            {
                                MessageBox.Show($"La cantidad en el inventario para el producto {producto.Nombre} no puede ser negativa.", "Error");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Producto {producto.Nombre} no encontrado en el inventario.", "Error");
                            return;
                        }
                    }

                    repuesto.SaveChanges();

                    MessageBox.Show("Productos agregados exitosamente y cantidades descontadas del inventario.", "Éxito");
                }

                autoIncrementValue++;
                tbid.Text = autoIncrementValue.ToString();

                listaFacturacion.Clear();
                dtfactura.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar los productos: " + ex.Message, "Error");
            }
        }

        private void tbcantidad_TextChanged(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(tbcantidad.Text, out cantidad))
            {
                decimal precioUnitario = decimal.Parse(lblprecioU.Text);
                decimal precioTotal = cantidad * precioUnitario;
                lblprecio.Text = precioTotal.ToString("C2"); // Formato de moneda
            }
            else
            {
                lblprecio.Text = "$0.00"; // Valor predeterminado si no se ingresa una cantidad válida
            }
        }
    }
}

