using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Login.Entidades
{
    class Articulos
    {
        [Key]
        public int IdArticulo { get; set; }
        public String NombreArticulo { get; set; }
        public int Existencia { get; set; }
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public string Categoria { get; set; }
        public int CodigoArticulo { get; set; }

        public Articulos(int idArticulo, String nombreArticulo, int existencia, float precioVenta, float precioCompra, string categoria, int codigoArticulo)
        {
            IdArticulo = idArticulo;
            NombreArticulo = nombreArticulo;
            Existencia = existencia;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            Categoria = categoria;
            CodigoArticulo = codigoArticulo;

        }

        public Articulos()
        {

        }

    }
}
