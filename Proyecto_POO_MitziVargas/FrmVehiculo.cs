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
    public partial class FrmVehiculo : Form
    {
        //evento
        public event EventHandler Aceptar;
        //variables globales
        //private int id_Placa = 0;
        private int id_PlacaVehiculo = 0;
       
        public FrmVehiculo()
        {
            InitializeComponent();
        }
        //Cargar vEhiculos
        private void CargarVehiculos(string condicion = "")
        {
            LN_Vehiculo logica = new LN_Vehiculo(Configuracion_Conexion.getConnectionString);
            List<Vehiculo> lista;
            try
            {
                lista = logica.ListarVehiculos(condicion);

                grdLista.DataSource = lista;


            }
            catch (Exception e)
            {

                throw e;
            }
        }
        //Seleccionar Vehiculos
        private void SeleccionarVehiculo()
        {
            try
            {
                if (grdLista.SelectedRows.Count > 0)
                {
                    id_PlacaVehiculo = Convert.ToInt32(grdLista.SelectedRows[0].Cells[1].Value);
                    Aceptar(id_PlacaVehiculo, null);
                    Close();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            string condicion;
            try
            {
                if (!string.IsNullOrEmpty(txtDesVehiculo.Text))
                {
                    condicion = $"id_Placa='{txtPlaca.Text} like '%{txtDesVehiculo.Text.Trim()}%'";
                }
                else
                {
                    condicion = $"id_Placa='{txtPlaca.Text}'";
                }

                CargarVehiculos(condicion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            id_PlacaVehiculo = -1;
            Aceptar(id_Placa, null);
            Close();
        }

        private void btnAceptarV_Click(object sender, EventArgs e)
        {
            try
            {
                SeleccionarVehiculo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            try
            {
                CargarVehiculos(string.Empty);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void grdLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SeleccionarVehiculo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
