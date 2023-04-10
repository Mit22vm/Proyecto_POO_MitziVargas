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
    }
}
