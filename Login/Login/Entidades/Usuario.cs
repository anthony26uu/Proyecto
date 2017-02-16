using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Login.Entidades
{
  public  class Usuario
    {
        [Key]
        public string NombreUsuario { get; set; }
        public string PassUsuario { get; set; }

        public Usuario(string nombreUsuario, string passUsuario)
        {
             PassUsuario = passUsuario;
             NombreUsuario = nombreUsuario;
        }

        public Usuario()
        {

        }
    }
}
