using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Proyecto_POO_MitziVargas
{
    public partial class FrmSolicitudGira : Form
    {
        public FrmSolicitudGira()
        {
            InitializeComponent();
        }
        //variable 
        //1
        LN_Gira logica = new LN_Gira();


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSolicitudGira_Load(object sender, EventArgs e)
        {
            logica.CadenaConexion = Configuracion_Conexion.getConexionString; //levantar la conexion de la bd a logica
            txtIdGira.Text = logica.identificadorGirasSiguientes().ToString();
        }
        //FECHAS
        //Funcion para validar las fechas de salida y llegada, comprobando si es extemporanea o no extemporanea

        public string ValidarFechaSalida(DateTime fecha)
        {
            // Obtener el día de la semana para la fecha de salida
            DayOfWeek diaDeSalida = fecha.DayOfWeek;

            // Obtener la fecha del martes de la semana anterior
            DateTime martesAnterior = fecha.AddDays(-(int)diaDeSalida - 2);

            // Obtener la fecha límite para la aprobación de la gira
            DateTime fechaLimite = martesAnterior.AddDays(-7);

            // Calcular la diferencia de tiempo entre la fecha límite y la fecha de salida
            TimeSpan diferenciaTiempo = fecha - fechaLimite;

            // Verificar si la fecha de salida cae en o antes del martes
            if (diaDeSalida > DayOfWeek.Tuesday)
            {
                // Si la fecha de salida es en o antes del martes, es extemporánea
                return "Extemporánea";
            }
            // Si la fecha de salida es más de un mes antes del martes anterior no es extemporánea
            else if (diferenciaTiempo.TotalDays > 8)
            {
                return "No Extemporánea";
            }
            // Si la fecha de salida es después del martes pero menos de un mes antes lo es extemporánea
            else
            {
                return "Extemporánea";
            }
        }//Fin funcion fechas


        //BOTON DE FECHAS
        private void btnValidar_Click(object sender, EventArgs e)
        {

            DateTime fechaSalida = dateTimePickerFechaSalida.Value;
            string resultado = ValidarFechaSalida(fechaSalida);
            txtTipo.Text = resultado;

        }//FIN BOTON
    }
}
