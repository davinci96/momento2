using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Configuracion
    {
        static string cadenaconexion = @"Data Source=DESKTOP-BC95F1A\SQLEXPRESS; Initial Catalog = concesiona; Trusted_Connection=true";

        public static string CadenaConexion
        {
            get { return cadenaconexion; }
        }
    }
}
