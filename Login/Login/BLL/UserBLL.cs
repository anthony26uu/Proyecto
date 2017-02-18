using Login.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login.BLL
{
  public  class UserBLL
    {
        public static bool Guardar(Usuario nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<Usuario>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }


        public static bool Eliminar(Usuario IdUser)
        {
            bool resultado = false;
            using (var db = new Repositorio<Usuario>())
            {
                resultado = db.Eliminar(IdUser);

            }
            return resultado;
        }
    }
}
