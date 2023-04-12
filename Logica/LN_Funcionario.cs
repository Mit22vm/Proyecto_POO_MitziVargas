using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Text;


namespace Logica
{
    public class LN_Funcionario
    {
        private string _cadenaConexion;

        public LN_Funcionario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }
        public string CadenaConexion { get => _cadenaConexion; set => _cadenaConexion = value; }


        public Funcionario ObtenerFuncionario(string condicion)
        {
            Funcionario resultado;
            AD_Funcionario AccesoDatos = new AD_Funcionario(_cadenaConexion);
            try
            {
                resultado = AccesoDatos.ObtenerFuncionario(condicion);
            }
            catch (Exception e)
            {
                throw e;
            }
            return resultado;
        }

        public List<Funcionario> ListarFuncionarios(string condicion = "")
        {
            List<Funcionario> resultado;
            AD_Funcionario AccesoDatos = new AD_Funcionario(_cadenaConexion);
            try
            {
                resultado = AccesoDatos.ListarFuncionarios(condicion);
            }
            catch (Exception e)
            {
                throw e;
            }
            return resultado;
        }
    }
}
