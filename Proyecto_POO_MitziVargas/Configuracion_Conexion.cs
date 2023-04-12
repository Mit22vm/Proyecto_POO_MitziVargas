using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_MitziVargas
{
    public static class Configuracion_Conexion
    {
        //internal static string getConnectionString;

        public static string getConnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
                    
            }
        }
    }
}
