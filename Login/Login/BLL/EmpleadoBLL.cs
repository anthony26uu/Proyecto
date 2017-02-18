using Login.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login.BLL
{
  public  class EmpleadoBLL
    {
        public static bool Guardar(Empleado nuevo)
        {
            bool retorno = false;

            using (var db = new Repositorio<Empleado>())
            {
                retorno = db.Guardar(nuevo) != null;
            }
            return retorno;

        }


        public static bool Eliminar(Empleado IdEmpleado)
        {
            bool resultado = false;
            using (var db = new Repositorio<Empleado>())
            {
                resultado = db.Eliminar(IdEmpleado);

            }
            return resultado;
        }
    }
}
