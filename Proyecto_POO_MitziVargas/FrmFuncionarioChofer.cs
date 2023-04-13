using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Proyecto_POO_MitziVargas
{
    public partial class FrmFuncionarioChofer : Form
    {
        public event EventHandler AceptarFuncionario;
        //evento

        private int id_Funcionario = 0;
        public string id = string.Empty;
        public string nombre = string.Empty;

        public FrmFuncionarioChofer()
        {
            InitializeComponent();
        }

        private void cargarFuncionario(string condicion = "")
        {
            LN_Funcionario logica = new LN_Funcionario(Configuracion_Conexion.getConnectionString);
            List<Funcionario> lista;
            try
            {
                lista = logica.ListarFuncionarios(condicion);

                grdListaFun.DataSource = lista;


            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void SeleccionarFuncionarios()
        {
            try
            {
                if (grdListaFun.SelectedRows.Count > 0)
                {
                    id_Funcionario = Convert.ToInt32(grdListaFun.SelectedRows[0].Cells[2].Value);
                    id = grdListaFun.SelectedRows[0].Cells[2].Value.ToString();
                    nombre = grdListaFun.SelectedRows[0].Cells[1].Value.ToString();
                    AceptarFuncionario(id_Funcionario, null);
                    Close();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void btnBuscarChofer_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreChofer.Text))
                {
                    condicion = $"concat(nombre,' ',APELLIDO) like '%{txtNombreChofer.Text}%'";
                }
                cargarFuncionario(condicion);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdListaFun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SeleccionarFuncionarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SeleccionarFuncionarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            id_Funcionario = -1;
            AceptarFuncionario(id_Funcionario, null);
            Close();
        }

        private void FrmFuncionarioChofer_Load(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreChofer.Text))
                {
                    condicion = $"concat(nombre,' ',APELLIDO) like '%{txtNombreChofer.Text}%'";
                }
                cargarFuncionario(condicion);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdListaFun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SeleccionarFuncionarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
