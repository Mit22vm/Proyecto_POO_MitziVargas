using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class HorasGira
    {
        //Atributos
        private int id_Horas_Giras;
        private DateTime horaSalida;
        private DateTime horaLLegada;
        private DateTime fecha;
        private int id_Gira;

        //Propiedades
        public int Id_Horas_Giras { 
            get => id_Horas_Giras; 
            set => id_Horas_Giras = value; 
        }
        public DateTime HoraSalida { 
            get => horaSalida; 
            set => horaSalida = value; 
        }
        public DateTime HoraLLegada { 
            get => horaLLegada; 
            set => horaLLegada = value; 
        }
        public DateTime Fecha { 
            get => fecha; 
            set => fecha = value; }
        public int Id_Gira { 
            get => id_Gira; 
            set => id_Gira = value; 
        }

        //Método constructor vacío
        public HorasGira()
        {
            id_Horas_Giras = 0;
            horaSalida = DateTime.Today;
            horaLLegada = DateTime.Today;
        }
    }
}
