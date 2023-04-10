using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class RegistroGira
    {
        //Atributos
        private int id_Gira;
        private string origen;
        private string destino;
        private int kilometrajeSalida;
        private int kilometrajeLlegada;
        private DateTime fechaSalida;
        private DateTime fechaLlegada;
        private int cantidadPasajeros;
        private string estadoGira;
        private string observacionGira;
        private string tipo;
        private string justificacion;
        private int id_Placa;

        //Propiedades
        public int Id_Gira {
            get => id_Gira; 
            set => id_Gira = value; 
        }
        public string Origen { 
            get => origen; 
            set => origen = value; 
        }
        public string Destino { 
            get => destino; 
            set => destino = value; 
        }
        public int KilometrajeSalida { 
            get => kilometrajeSalida; 
            set => kilometrajeSalida = value; 
        }
        public int KilometrajeLlegada { 
            get => kilometrajeLlegada; 
            set => kilometrajeLlegada = value; 
        }
        public DateTime FechaSalida { 
            get => fechaSalida; 
            set => fechaSalida = value; 
        }
        public DateTime FechaLlegada {
            get => fechaLlegada; 
            set => fechaLlegada = value; 
        }
        public int CantidadPasajeros {
            get => cantidadPasajeros; 
            set => cantidadPasajeros = value;
        }
        public string EstadoGira { 
            get => estadoGira; 
            set => estadoGira = value; 
        }
        public string ObservacionGira {
            get => observacionGira; 
            set => observacionGira = value; 
        }
        public string Tipo { 
            get => tipo; 
            set => tipo = value; 
        }
        public string Justificacion { 
            get => justificacion;
            set => justificacion = value;
        }
        public int Id_Placa {
            get => id_Placa; 
            set => id_Placa = value;
        }

        //Método constructor vacío
        public RegistroGira()
        {
            id_Gira = 0;
            origen = string.Empty;
            destino = string.Empty;
            kilometrajeSalida = 0;
            kilometrajeLlegada = 0;
            fechaSalida = DateTime.Today;
            fechaLlegada = DateTime.Today;
            cantidadPasajeros = 0;
            estadoGira = string.Empty;
            observacionGira = string.Empty;
            tipo = string.Empty;
            justificacion = string.Empty;
            id_Placa = 0;
        }
    }

}
