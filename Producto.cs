using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_ventas
{
    internal class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        public Producto() { }

public Producto(int id, string nombre, decimal precioUnitario, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }
    }
}
