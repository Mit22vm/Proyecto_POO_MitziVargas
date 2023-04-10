using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pasajeros
    {
        //Atributos
        private int id_Pasajero;
        private int id_Gira;
        private string estadoPasajero;
        private string id_Cedula;

        //Propiedades
        public int Id_Pasajero { 
            get => id_Pasajero; 
            set => id_Pasajero = value; 
        }
        public int Id_Gira { 
            get => id_Gira; 
            set => id_Gira = value;
        }
        public string EstadoPasajero {
            get => estadoPasajero;
            set => estadoPasajero = value; 
        }
        public string Id_Cedula { 
            get => id_Cedula; 
            set => id_Cedula = value;
        }
        //Método constructor vacío
        public Pasajeros()
        {
            id_Pasajero = 0;
            id_Gira = 0;
            estadoPasajero = string.Empty;
            id_Cedula = string.Empty;
        }
    }
}
