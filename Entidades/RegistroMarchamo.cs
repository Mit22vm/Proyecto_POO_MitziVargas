using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    //Clase que hereda de Registro
    public class RegistroMarchamo
    {
        //Atributos
        private decimal valorVehicular;
        private decimal montoMarchamo;

        //Propiedades
        public decimal ValorVehicular
        {
            get => valorVehicular;
            set => valorVehicular = value;
        }
        public decimal MontoMarchamo
        {
            get => montoMarchamo;
            set => montoMarchamo = value;
        }
        //Método constructor vacío
        public RegistroMarchamo()
        {
            valorVehicular = 0;
            montoMarchamo = 0;
        }
    }
}
