using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Login.Entidades
{
  public  class Ventas
    {
        [Key]

        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public float Descuento { get; set; }
        public string Cliente { get; set; }
        public string TipoVenta { get; set; }
    //  public string Producto { get; set; }
        public int CantidadProd { get; set; }
        public float ITBS { get; set; }
    }
}
