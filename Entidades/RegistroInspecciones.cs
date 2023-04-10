using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    //Clase que hereda de Registro
    public class RegistroInspecciones
    {
           //Atributos
            private DateTime fechaProxima;

            //Propiedad
            public DateTime FechaProxima
            {
                get => fechaProxima;
                set => fechaProxima = value;
            }
            //Método Constructor vacío
            public RegistroInspecciones()
            {
                fechaProxima = DateTime.Today;
            }
        }
}
