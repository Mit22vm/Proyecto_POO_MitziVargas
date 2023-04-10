using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class RegistroIncidentes
    {
        //Atributos
        private int id_Registro_Incidentes;
        private int id_Gira;
        private string tipo;
        private DateTime horaIncidente;
        private DateTime fechaIncidente;
        private string ubicacion;
        private string descripcion;

        //Propiedades
        public int Id_Registro_Incidentes { 
            get => id_Registro_Incidentes; 
            set => id_Registro_Incidentes = value; 
        }
        public int Id_Gira { 
            get => id_Gira; 
            set => id_Gira = value; 
        }
        public string Tipo {
            get => tipo; 
            set => tipo = value; 
        }
        public DateTime HoraIncidente {
            get => horaIncidente;
            set => horaIncidente = value; 
        }
        public DateTime FechaIncidente { 
            get => fechaIncidente; 
            set => fechaIncidente = value; 
        }
        public string Ubicacion { 
            get => ubicacion; 
            set => ubicacion = value; 
        }
        public string Descripcion { 
            get => descripcion; 
            set => descripcion = value; 
        }
        //Método constructor vacío
        public RegistroIncidentes()
        {
            id_Registro_Incidentes = 0;
            id_Gira = 0;
            tipo = string.Empty;
            horaIncidente = DateTime.Today;
            fechaIncidente = DateTime.Today;
            ubicacion = string.Empty;
            descripcion = string.Empty;
        }
    }
}
