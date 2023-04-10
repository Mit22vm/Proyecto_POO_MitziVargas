using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    //Clase que hereda de Registro
    public class RegistroPoliza
    {
        //Atributos
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string estadoPoliza;


        //Propiedades
        public DateTime FechaInicio
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }
        public DateTime FechaFin
        {
            get => fechaFin;
            set => fechaFin = value;
        }
        public string EstadoPoliza
        {
            get => estadoPoliza;
            set => estadoPoliza = value;
        }

        //Método constructor vacío
        public RegistroPoliza()
        {
            fechaInicio = DateTime.Today;
            fechaFin = DateTime.Today;
            estadoPoliza = string.Empty;
        }
    }
}
