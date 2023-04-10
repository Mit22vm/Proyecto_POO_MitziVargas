using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DetalleMantenimiento
    {
        //Atributos
        private int id_Detalle_Mantenimiento;
        private string descripcionDetalle;
        private int id_Mantenimiento;

        //Propiedades
        public int Id_Detalle_Mantenimiento { 
            get => id_Detalle_Mantenimiento; 
            set => id_Detalle_Mantenimiento = value;
        }
        public string DescripcionDetalle { 
            get => descripcionDetalle; 
            set => descripcionDetalle = value; 
        }
        public int Id_Mantenimiento { 
            get => id_Mantenimiento; 
            set => id_Mantenimiento = value; 
        }
        //Método constructor vacío
        public DetalleMantenimiento()
        {
            id_Detalle_Mantenimiento = 0;
            descripcionDetalle = string.Empty;
            id_Mantenimiento = 0;
        }
    }
}
