using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Funcionario
    {
        //Atributos de la clase
        private string id_Cedula;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string telefono1;
        private string telefono2;
        private string email;
        private bool existe;


        //Propiedades de la clase
        public string Id_Cedula
        {
            get => id_Cedula;
            set => id_Cedula = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido1
        {
            get => apellido1;
            set => apellido1 = value;
        }
        public string Apellido2
        {
            get => apellido2;
            set => apellido2 = value;
        }
        public string Telefono1
        {
            get => telefono1;
            set => telefono1 = value;
        }
        public string Telefono2
        {
            get => telefono2;
            set => telefono2 = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public bool Existe
        {
            get => existe;
            set => existe = value;
        }

        //Método constructor vacío
        public Funcionario()
        {
            id_Cedula = string.Empty;
            nombre = string.Empty;
            apellido1 = string.Empty;
            apellido2 = string.Empty;
            telefono1 = string.Empty;
            telefono2 = string.Empty;
            email = string.Empty;
        }
    }
}
