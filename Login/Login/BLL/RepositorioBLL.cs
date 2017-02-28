using Login.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login.BLL
{
    class RepositorioBLL
    {

        public static bool Guardar(Articulos  nuevo)
        {
            bool retorno = false;
            using (var db = new Repositorio<Articulos>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }
        public static bool Eliminar(Articulos IdArticulo)
        {
            bool resultado = false;
            using (var db = new Repositorio<Articulos>())
            {
                resultado = db.Eliminar(IdArticulo);

            }
            return resultado;
        }
    }
}
