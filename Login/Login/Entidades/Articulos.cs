﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Login.Entidades
{
 public   class Articulos
    {
        [Key]
        public int IdArticulo { get; set; }
        public String NombreArticulo { get; set; }
        public int Existencia { get; set; }
        public string PrecioVenta { get; set; }
        public string PrecioCompra { get; set; }
        public string Categoria { get; set; }
        public int CodigoArticulo { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Articulos(int idArticulo, String nombreArticulo, int existencia, string precioVenta, string precioCompra, string categoria, int codigoArticulo, DateTime fechaIngreso )
        {
            IdArticulo = idArticulo;
            NombreArticulo = nombreArticulo;
            Existencia = existencia;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            Categoria = categoria;
            CodigoArticulo = codigoArticulo;
            FechaIngreso= fechaIngreso;



    }

        public Articulos()
        {

        }

    }
}
