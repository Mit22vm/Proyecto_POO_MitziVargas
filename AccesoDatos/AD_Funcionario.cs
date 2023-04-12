using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace AccesoDatos
{
    public class AD_Funcionario
    {
        private string _cadenaConexion;


        public AD_Funcionario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }
        //Función para extraer o seleccionar los funcionarios 

        public Funcionario ObtenerFuncionario(string realizarCon)
        {
            Funcionario funcionarios = new Funcionario();
            SqlConnection cnn = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            SqlDataReader informacionDatos;
            string sentencia = "Select id_Cedula,nombre,apellido1,apellido2,telefono1,telefono2,email from Funcionario";
            if (!string.IsNullOrEmpty(realizarCon))
            {
                sentencia = $"{sentencia} where {realizarCon}";
            }
            comando.CommandText = sentencia;
            try
            {
                cnn.Open();
                informacionDatos = comando.ExecuteReader();
                if (informacionDatos.HasRows)
                {
                    informacionDatos.Read();
                    funcionarios.Id_Cedula = informacionDatos.GetString(0);
                    funcionarios.Nombre = informacionDatos.GetString(1);
                    funcionarios.Apellido1 = informacionDatos.GetString(2);
                    funcionarios.Apellido2 = informacionDatos.GetString(3);
                    funcionarios.Telefono1 = informacionDatos.GetString(4);
                    funcionarios.Telefono2 = informacionDatos.GetString(5);
                    funcionarios.Email = informacionDatos.GetString(6);
                    funcionarios.Existe = true;
                }
                cnn.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            return funcionarios;
        }

        //Funcion para para almacenar los datos obtenidos de la BD
        //Se muestran los funcionario que se tienen en el DataGridView, y el objeto se llena con los datos obtenidos, realizando la verificacion si tiene filas

        public List<Funcionario> ListarFuncionarios(string condicion = "")
        {
            DataSet informacionDatos = new DataSet();
            SqlConnection cnn = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Funcionario> funcionarios = new List<Funcionario>();

            string sentencia = "Select id_Cedula,nombre,apellido1,apellido2,telefono1,telefono2,email from Funcionario";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = $"{sentencia} where {condicion}";
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, cnn);
                adapter.Fill(informacionDatos, "Funcionario");
                //linq lenguaje de c# para manejo de consultas
                if (informacionDatos.Tables[0].Rows.Count > 0)
                {
                    funcionarios = (from DataRow registro in informacionDatos.Tables[0].Rows
                                select new Funcionario()
                                {
                                    Id_Cedula = registro[0].ToString(),
                                    Nombre = registro[1].ToString(),
                                    Apellido1 = registro[2].ToString(),
                                    Apellido2 = registro[3].ToString(),
                                    Telefono1 = registro[4].ToString(),
                                    Telefono2 = registro[5].ToString(),
                                    Email = registro[6].ToString(),
                                    Existe = true
                                }
                           ).ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return funcionarios;

        }

    }
}
