using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Vehiculo
    {
        //Atributo
        private int id_Placa;
        private int id_Sucursal;
        private string chasis;
        private string motor;
        private string tipoCombustibles;
        private string marca;
        private string estilo;
        private int modelo;
        private int cilindrada;
        private string estadoVehiculo;
        private int cantidadPasajeros;
        private string tipoVehiculo;

        //Propiedades
        public int Id_Placa
        {
            get => id_Placa;
            set => id_Placa = value;
        }
        public int Id_Sucursal
        {
            get => id_Sucursal;
            set => id_Sucursal = value;
        }
        public string Chasis
        {
            get => chasis;
            set => chasis = value;
        }
        public string Motor
        {
            get => motor;
            set => motor = value;
        }
        public string TipoCombustibles
        {
            get => tipoCombustibles;
            set => tipoCombustibles = value;
        }
        public string Marca
        {
            get => marca;
            set => marca = value;
        }
        public string Estilo
        {
            get => estilo;
            set => estilo = value;
        }
        public int Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public int Cilindrada
        {
            get => cilindrada;
            set => cilindrada = value;
        }
        public string EstadoVehiculo
        {
            get => estadoVehiculo;
            set => estadoVehiculo = value;
        }
        public int CantidadPasajeros
        {
            get => cantidadPasajeros;
            set => cantidadPasajeros = value;
        }
        public string TipoVehiculo
        {
            get => tipoVehiculo;
            set => tipoVehiculo = value;
        }
        //Método constructor vacío
        public Vehiculo()
        {
            id_Placa = 0;
            id_Sucursal = 0;
            chasis = string.Empty;
            motor = string.Empty;
            tipoCombustibles = string.Empty;
            marca = string.Empty;
            estilo = string.Empty;
            modelo = 0;
            cilindrada = 0;
            estadoVehiculo = string.Empty;
            cantidadPasajeros = 0;
            tipoVehiculo = string.Empty;
        }
    }
}
