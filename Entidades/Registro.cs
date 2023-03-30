using System;

namespace Entidades
{
    public class Registro
    {
        //Atributos
        private int id_Registro;
        private DateTime fecha;
        private string descripcionFecha;
        private int id_Placa;

        //Propiedades
        public int Id_Registro
        {
            get => id_Registro;
            set => id_Registro = value;
        }
        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }
        public string DescripcionFecha
        {
            get => descripcionFecha;
            set => descripcionFecha = value;
        }
        public int Id_Placa
        {
            get => id_Placa;
            set => id_Placa = value;
        }
        //Método constructor vacío
        public Registro()
        {
            id_Registro = 0;
            fecha = DateTime.Today;
            descripcionFecha = string.Empty;
            id_Placa = 0;
        }

    }
}
