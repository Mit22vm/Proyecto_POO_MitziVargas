using System;
using AccesoDatos;
using Entidades;

namespace Logica
{
    public class LN_Gira
    {
        private string _cadenaConexion;

        public LN_Gira(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public LN_Gira()
        {
            _cadenaConexion = string.Empty;
        }

        public string CadenaConexion { get => _cadenaConexion; set => _cadenaConexion = value; }

        
        //pASO 2
        //Funcion se tiene que llamar igual a la funcion de AD_GIRA

        public int identificadorGirasSiguientes()
        {
            AD_Gira datos = new AD_Gira(_cadenaConexion); //Para traer la funcion

            int totalGiras = datos.identificadorGirasSiguientes();//Devuelve la consulta de la bd
            int proximaGira = totalGiras + 1; //le suma a la variable de total 1

            return proximaGira;
        }
    }
}
