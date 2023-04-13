using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class AD_Vehiculo
    {

        private string _cadenaConexion = "Data Source=DESKTOP-BQM0IO4;Initial Catalog=FLOTA_VEHICULAR_BD_PROYECTO_POO_MITZI;Integrated Security=True";
        private int id_Placa;

        public AD_Vehiculo(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }
        //Funcion obtener vehiculo
        public Vehiculo ObtenerVehiculo(string condicion)
        {
            Vehiculo vehiculo = new Vehiculo();
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-BQM0IO4;Initial Catalog=FLOTA_VEHICULAR_BD_PROYECTO_POO_MITZI;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            SqlDataReader datos;
            string sentencia = "Select ID_PLACA,ID_SUCURSAL,CHASIS,MOTOR,TIPO_COMBUSTIBLE,MARCA,ESTILO,MODELO,CILINDRADA,ESTADO_VEHICULO,CAPACIDAD_PASAJEROS from VEHICULO";


                //"Select id_Placa,id_Sucursal,chasis,motor,tipoCombustible,marca,estilo,modelo,cilindrada,estadoVehiculo,cantidadPasajeros,tipoVehiculo from VEHICULOS where borrado=0 ";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = $"{sentencia} where {condicion}";
            }
            comando.CommandText = sentencia;
            try
            {
                cnn.Open();
                datos = comando.ExecuteReader();
                if (datos.HasRows)
                {
                    datos.Read();
                    vehiculo.Id_Placa = datos.GetInt32(0);
                    vehiculo.Id_Sucursal = datos.GetInt32(1);
                    vehiculo.Chasis = datos.GetString(2);
                    vehiculo.Motor = datos.GetString(3);
                    vehiculo.TipoCombustibles = datos.GetString(4);
                    vehiculo.Marca = datos.GetString(5);
                    vehiculo.Estilo = datos.GetString(6);
                    vehiculo.Modelo = datos.GetInt32(7);
                    vehiculo.Cilindrada = datos.GetInt32(8);
                    vehiculo.EstadoVehiculo = datos.GetString(9);
                    vehiculo.CapacidadPasajeros = datos.GetInt32(10);
                    //vehiculo.TipoVehiculo = datos.GetString(11);

                    //existe
                }
                cnn.Close();
            }
            catch (Exception e)
            {

                throw e;
            }

            return vehiculo;
        }

        //Lista vehiculo
        public List<Vehiculo> ListarVehiculos(string condicion = "")
        {
            DataSet datos = new DataSet();
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-BQM0IO4;Initial Catalog=FLOTA_VEHICULAR_BD_PROYECTO_POO_MITZI;Integrated Security=True");
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            List<Vehiculo> vehiculos = new List<Vehiculo>();
            

            string sentencia = "Select ID_PLACA,ID_SUCURSAL,CHASIS,MOTOR,TIPO_COMBUSTIBLE,MARCA,ESTILO,MODELO,CILINDRADA,ESTADO_VEHICULO,CAPACIDAD_PASAJEROS,TIPO_VEHICULO from VEHICULO";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = $"{sentencia} and {condicion}";
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, cnn);

                adapter.Fill(datos, "Vehiculo");
                //linq 
                if (datos.Tables[0].Rows.Count > 0)
                    vehiculos = (from DataRow registro in datos.Tables["Vehiculo"].Rows
                                 select new Vehiculo()
                                 {
                                     Id_Placa = Convert.ToInt32(registro[0]),
                                     Id_Sucursal = Convert.ToInt32(registro[1]),
                                     Chasis = registro[2].ToString(),
                                     Motor = registro[3].ToString(),
                                     TipoCombustibles = registro[4].ToString(),
                                     Marca = registro[5].ToString(),
                                     Estilo = registro[6].ToString(),
                                     Modelo = Convert.ToInt32(registro[7]),
                                     Cilindrada = Convert.ToInt32(registro[8]),
                                     EstadoVehiculo = Convert.ToString(registro[9]),
                                     CapacidadPasajeros = Convert.ToInt32(registro[10]),
                                     TipoVehiculo = Convert.ToString(registro[11]),

                                     //Existe = true
                                 }
                           ).ToList();
            }
            catch (Exception e)
            {

                throw e;
            }

            return vehiculos;

        }
    }
}
