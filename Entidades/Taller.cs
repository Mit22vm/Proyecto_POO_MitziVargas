using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Taller
    {
        //Atributos
        private int codigo_Taller;
        private string ubicacion;
        private int cantidadVehicular;

        //Propiedades
        public int Codigo_Taller { get => codigo_Taller; set => codigo_Taller = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int CantidadVehicular { get => cantidadVehicular; set => cantidadVehicular = value; }

        //Método constructor vacío
        public Taller()
        {
            codigo_Taller = 0;
            ubicacion = string.Empty;
            cantidadVehicular = 0;
        }
    }
}
