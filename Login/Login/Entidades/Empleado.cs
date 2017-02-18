using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Login.Entidades
{
  public  class Empleado
    {
           [Key]
        public int IdEmpleado { get; set; }
        public string  NombreEmpleado { get; set; }
        public int TelefonoEmpleado { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Direccion { get; set; }
        public string Salario { get; set; }
        public string Cargo { get; set; }

        public Empleado(int idEmpleado, string nombreEmpleado, int telefonoEmpleado, DateTime fechaContratacion, string direccion, string salario, string cargo)
        {
            IdEmpleado = idEmpleado;
            NombreEmpleado = nombreEmpleado;
            TelefonoEmpleado = telefonoEmpleado;
            FechaContratacion = fechaContratacion;
            Direccion = direccion;
            Salario = salario;
            Cargo = cargo;

        }

        public Empleado()
        {

        }
    }
}
