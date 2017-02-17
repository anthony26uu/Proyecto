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
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string PassUsuario { get; set; }

        public Usuario(int id , string nombreUsuario, string passUsuario)
        {
             PassUsuario = passUsuario;
             Id = id;
             NombreUsuario = nombreUsuario; 

        }

        public Usuario()
        {

        }
    }
}
