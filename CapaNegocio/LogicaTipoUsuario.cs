using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.Linq;

namespace CapaNegocio
{

    public class LogicaTipoUsuario
    {
        //instanciar el data contex
        public static DataClasses1DataContext dc = new DataClasses1DataContext();
        //metodo para obtener toda la informacion de la entidad

        public static List<Tbl_TipoUsuario> obtenerTusuario()
        {
            var lista = dc.Tbl_TipoUsuario.Where(tusu=>tusu.Tusu_estado=='A');
            //select * from                where Tusu_estado=A

            return lista.ToList();

        }
    }
}
