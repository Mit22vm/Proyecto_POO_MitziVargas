using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ActivosVehiculo
    {
        //Atributo
        private int id_Activos_Vehiculo;
        private string tipoHerramienta;
        private DateTime fechaVencimiento;
        private DateTime garantia;
        private int id_Placa;

        //Propiedades
        public int Id_Activos_Vehiculo
        {
            get => id_Activos_Vehiculo;
            set => id_Activos_Vehiculo = value;
        }
        public string TipoHerramienta
        {
            get => tipoHerramienta;
            set => tipoHerramienta = value;
        }
        public DateTime FechaVencimiento
        {
            get => fechaVencimiento;
            set => fechaVencimiento = value;
        }
        public DateTime Garantia
        {
            get => garantia;
            set => garantia = value;
        }
        public int Id_Placa
        {
            get => id_Placa;
            set => id_Placa = value;
        }
        //Método constructor vacío
        public ActivosVehiculo()
        {
            id_Activos_Vehiculo = 0;
            tipoHerramienta = string.Empty;
            fechaVencimiento = DateTime.Today;
            garantia = DateTime.Today;
            id_Placa = 0;
        }
    }
}
