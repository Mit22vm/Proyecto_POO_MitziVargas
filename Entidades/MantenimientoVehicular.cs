using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MantenimientoVehicular
    {
        //Atributos
        private int id_Mantenimiento_Vehicular;
        private string descripcion;
        private DateTime cita_Mantenimiento;
        private decimal costo;
        private int codigoTaller;
        private int id_Placa;
        private DateTime fechaProxima;

        //Propiedades
        public int Id_Mantenimiento_Vehicular {
            get => id_Mantenimiento_Vehicular;
            set => id_Mantenimiento_Vehicular = value; 
        }
        public string Descripcion { 
            get => descripcion; 
            set => descripcion = value; 
        }
        public DateTime Cita_Mantenimiento { 
            get => cita_Mantenimiento; 
            set => cita_Mantenimiento = value; 
        }
        public decimal Costo { 
            get => costo; 
            set => costo = value; 
        }
        public int CodigoTaller { 
            get => codigoTaller; 
            set => codigoTaller = value; 
        }
        public int Id_Placa { 
            get => id_Placa; 
            set => id_Placa = value; 
        }
        public DateTime FechaProxima {
            get => fechaProxima; 
            set => fechaProxima = value; 
        }
        //Método constructor vacío
        public MantenimientoVehicular()
        {
            id_Mantenimiento_Vehicular = 0;
            descripcion = string.Empty;
            cita_Mantenimiento = DateTime.Today;
            costo = 0;
            codigoTaller = 0;
            id_Placa = 0;
            fechaProxima = DateTime.Today;
        }
    }
}
