using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoLicencia
    {
        //Atributos
        private string id_Licencia;
        private DateTime fechaVencimiento;
        private string tipo;
        private string tienePermiso;
        private string id_Cedula;

        //Propiedades
        public string Id_Licencia { 
            get => id_Licencia; 
            set => id_Licencia = value; 
        }
        public DateTime FechaVencimiento { 
            get => fechaVencimiento; 
            set => fechaVencimiento = value; 
        }
        public string Tipo { 
            get => tipo; 
            set => tipo = value; 
        }
        public string TienePermiso { 
            get => tienePermiso; 
            set => tienePermiso = value; 
        }
        public string Id_Cedula { 
            get => id_Cedula; 
            set => id_Cedula = value; 
        }
        //Método constructor vacío
        public TipoLicencia()
        {
            id_Licencia = string.Empty;
            fechaVencimiento = DateTime.Today;
            tipo = string.Empty;
            tienePermiso = string.Empty;
            id_Cedula = string.Empty;
        }
    }
}
