using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoFuncionarioGira
    {
        //Atributos
        private string id_Funcionario;
        private int id_Gira;
        private string id_Funcionario_Maneja;
        private string id_Funcionario_Solicita;
        private string id_Funcionario_Aprueba;

        //Propiedades
        public string Id_Funcionario { 
            get => id_Funcionario; 
            set => id_Funcionario = value; 
        }
        public int Id_Gira { 
            get => id_Gira; 
            set => id_Gira = value;
        }
        public string Id_Funcionario_Maneja { 
            get => id_Funcionario_Maneja; 
            set => id_Funcionario_Maneja = value; 
        }
        public string Id_Funcionario_Solicita { 
            get => id_Funcionario_Solicita; 
            set => id_Funcionario_Solicita = value;
        }
        public string Id_Funcionario_Aprueba { 
            get => id_Funcionario_Aprueba; 
            set => id_Funcionario_Aprueba = value; 
        }

        //Método constructor vacío
        public TipoFuncionarioGira()
        {
            id_Funcionario = string.Empty;
            id_Gira = 0;
            id_Funcionario_Maneja = string.Empty;
            id_Funcionario_Solicita = string.Empty;
            id_Funcionario_Aprueba = string.Empty;
        }
    }
}
