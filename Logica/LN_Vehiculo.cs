using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public class LN_Vehiculo
    {
        private string _cadenaConexion;

        public string CadenaConexion
        {
            get => _cadenaConexion;
            set => _cadenaConexion = value;
        }

        public LN_Vehiculo(string getConnectionString)
        {
            _cadenaConexion = string.Empty;
        }

        //Obtener los vehiculos
        public Vehiculo ObtenerVehiculo(string condicion)
        {
            Vehiculo resultado;
            AD_Vehiculo AccesoDatos = new AD_Vehiculo(_cadenaConexion);
            try
            {
                resultado = AccesoDatos.ObtenerVehiculo(condicion);
            }
            catch (Exception e)
            {
                throw e;
            }
            return resultado;
        }

        //Lista vehiculos
        public List<Vehiculo> ListarVehiculos(string condicion = "")
        {
            List<Vehiculo> resultado;
            AD_Vehiculo AccesoDatos = new AD_Vehiculo(_cadenaConexion);
            try
            {
                resultado = AccesoDatos.ListarVehiculos(condicion);
            }
            catch (Exception e)
            {
                throw e;
            }
            return resultado;
        }
    }
}
