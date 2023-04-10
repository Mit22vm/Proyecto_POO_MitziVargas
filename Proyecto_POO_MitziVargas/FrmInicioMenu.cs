using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO_MitziVargas
{
    public partial class FrmInicioMenu : Form
    {
        public FrmInicioMenu()
        {
            InitializeComponent();
        }
        //Conexion de formulario Solicitud de gira
        private void MnuSolicitudGira_Click(object sender, EventArgs e)
        {
            FrmSolicitudGira form = new FrmSolicitudGira();
            form.Show(this); //Con esto se abre un formulario dentro de otro
        }

        private void MnuSolicitudGira_Click_1(object sender, EventArgs e)
        {
            FrmSolicitudGira form = new FrmSolicitudGira();
            form.Show(this); //Con esto se abre un formulario dentro de otro
        }
    }
}
