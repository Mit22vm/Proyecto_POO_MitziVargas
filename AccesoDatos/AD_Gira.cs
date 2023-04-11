using System;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public class AD_Gira
    {

        private string _cadenaConexion;


        public AD_Gira(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        //Función para colocar el identificador a la gira
        //La cuál agregar un número mas a la cantidad que ya se encuentra guardada
        public int identificadorGirasSiguientes()
        {
            int numGiras = 0; //guarda la cantidad giras

            //Abre la conexion a la BD
            SqlConnection cnn = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;

            try
            {
                cnn.Open();//abre conexión
                //variable
                string consulta = "SELECT MAX (ID_GIRA) FROM REGISTRO_GIRA";
                SqlCommand contador = new SqlCommand(consulta, cnn);
                numGiras = (int)contador.ExecuteScalar();
                cnn.Close();//Cierra conexión
            }
            catch (Exception)
            {
                
                throw;
            }

            return numGiras;
        }//fin función
    }
}
