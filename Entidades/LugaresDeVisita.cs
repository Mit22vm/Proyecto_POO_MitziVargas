using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class LugaresDeVisita
    {
        //Atributos
        private int id_Lugares_De_Visita;
        private string lugarVisita;
        private DateTime fecha;
        private string canton;
        private string distrito;
        private string lugar;
        private int id_Gira;

        //Propiedades
        public int Id_Lugares_De_Visita { 
            get => id_Lugares_De_Visita; 
            set => id_Lugares_De_Visita = value; 
        }
        public string LugarVisita { 
            get => lugarVisita; 
            set => lugarVisita = value; 
        }
        public DateTime Fecha { 
            get => fecha; 
            set => fecha = value; 
        }
        public string Canton {
            get => canton; 
            set => canton = value; 
        }
        public string Distrito { 
            get => distrito;
            set => distrito = value; 
        }
        public string Lugar { 
            get => lugar; 
            set => lugar = value; 
        }
        public int Id_Gira {
            get => id_Gira;
            set => id_Gira = value; 
        }
        //Método constructor vacío
        public LugaresDeVisita()
        {
            id_Lugares_De_Visita = 0;
            lugarVisita = string.Empty;
            fecha = DateTime.Today;
            canton = string.Empty;
            distrito = string.Empty;
            lugar = string.Empty;
            id_Gira = 0;
        }
    }
}
