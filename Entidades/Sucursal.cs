using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Sucursal
    {
        //Atributos
        private int id_Sucursal;
        private string ubicacion;
        private string telefono;
        private string nombreSucursal;

        //Propiedades
        public int Id_Sucursal
        {
            get => id_Sucursal;
            set => id_Sucursal = value;
        }
        public string Ubicacion
        {
            get => ubicacion;
            set => ubicacion = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Nombre_Sucursal
        {
            get => nombreSucursal;
            set => nombreSucursal = value;
        }
        //Método constructor vacío
        public Sucursal()
        {
            id_Sucursal = 0;
            ubicacion = string.Empty;
            telefono = string.Empty;
            nombreSucursal = string.Empty;
        }
    }
}
