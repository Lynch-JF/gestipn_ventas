//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_de_ventas.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public int id { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Productos { get; set; }
        public double Precio_total { get; set; }
        public string Forma_pago { get; set; }
    }
}