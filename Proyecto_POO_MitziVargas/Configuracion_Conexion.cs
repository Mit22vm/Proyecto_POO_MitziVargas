using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO_MitziVargas
{
    class Configuracion_Conexion
    {
        public static string getConexionString
        {
            get
            {
                return Properties.Settings.Default.FLOTA_VEHICULAR_BD_PROYECTO_POO_MITZIConnectionString;
            }
        }
    }
}
