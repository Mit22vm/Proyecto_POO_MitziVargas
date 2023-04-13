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
using Entidades;


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
            logica.CadenaConexion = Configuracion_Conexion.getConnectionString; //levantar la conexion de la bd a logica
            txtIdGira.Text = logica.identificadorGirasSiguientes().ToString();



            //DATAGRIDVIEW DE LUGARES

            // Configurar las columnas del DataGridView
            grdLugaresVisita.ColumnCount = 3;
            grdLugaresVisita.Columns[0].Name = "Lugar de Visita";
            grdLugaresVisita.Columns[1].Name = "Cantón";
            grdLugaresVisita.Columns[2].Name = "Distrito";
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


       



        //--------------------------------------------------------------------------------------------------

                                                        //Funcionario SOLICITANTE//

        //Boton de Buscar funcionarios
        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frm = new FrmFuncionarios();
           
            frm.AceptarFuncionario += new EventHandler(AceptarFuncionario);
            
            frm.Show(this);
        }


        //Aceptar Funcionario
        private void AceptarFuncionario(object id, EventArgs e)
        {
            try
            {
                int id_Funcionario = (int)id;
                if (id_Funcionario > -1)
                {
                    BuscarFuncionario(id_Funcionario);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar Funcionario
        private void BuscarFuncionario(int id)
        {
            Funcionario funcionario;
            LN_Funcionario logica = new LN_Funcionario(Configuracion_Conexion.getConnectionString);

            string condicion = $"id_Cedula={id}";
            try
            {
                funcionario = logica.ObtenerFuncionario(condicion);
                if (funcionario.Existe)
                {
                    txtFuncionario.Tag = funcionario.Id_Cedula.ToString();
                    txtFuncionario.Text = $"{funcionario.Nombre} {funcionario.Apellido1}";
                }
                else
                {
                    MessageBox.Show("Imposible cargar el funcionario ya que ha tenido cambios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
                                                       //Funcionario Chofer//
        //Boton de buscar funcionario chofer
        private void btnBuscarChofer_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frm = new FrmFuncionarios();

            frm.AceptarFuncionario += new EventHandler(AceptarFuncionarioChofer);

            frm.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //Aceptar Funcionario Chofer
        private void AceptarFuncionarioChofer(object id, EventArgs e)
        {
            try
            {
                int id_Funcionario = (int)id;
                if (id_Funcionario > -1)
                {
                    BuscarFuncionarioChofer(id_Funcionario);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar Funcionario chofer
        private void BuscarFuncionarioChofer(int id)
        {
            Funcionario funcionario;
            LN_Funcionario logica = new LN_Funcionario(Configuracion_Conexion.getConnectionString);
           

            string condicion = $"Id_Cedula={id}";
            try
            {
                funcionario = logica.ObtenerFuncionario(condicion);
                if (funcionario.Existe)
                {
                    txtFuncionarioChofer.Tag = funcionario.Id_Cedula.ToString();
                    txtFuncionarioChofer.Text = $"{funcionario.Nombre} {funcionario.Apellido1}";
                }
                else
                {
                    MessageBox.Show("Imposible cargar el funcionario chofer ya que ha tenido cambios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

                                                //Vehiculo//

        //Aceptar Vehiculo
        private void AceptarVehiculo(object id, EventArgs e)
        {
            try
            {
                int id_Placa = (int)id;
                if (id_Placa > -1)
                {
                    BuscarVehiculo(id_Placa);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar Vehiculo

        //-----revisar
        private void BuscarVehiculo(int id)
        {
            Vehiculo vehiculo;
            LN_Vehiculo logica = new LN_Vehiculo(Configuracion_Conexion.getConnectionString);

            string condicion = $"id_Placa={id}";

            try
            {
                vehiculo = logica.ObtenerVehiculo(condicion);
                if (vehiculo != null)
                {
                    txtVehiculo.Text = vehiculo.Id_Placa.ToString();
                    
                    txtVehiculo.Text = $"{vehiculo.Id_Placa} {vehiculo.TipoVehiculo}";
                }
                else
                {
                    MessageBox.Show("Imposible cargar el vehiculo ya que ha tenido cambios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            FrmVehiculo frm = new FrmVehiculo();

            frm.Aceptar += new EventHandler(AceptarVehiculo);

            frm.Show(this);
        }

      //Valida la HORA DE SALIDA

        public string ValidarHoraSalida()
        {
            // Obtener la hora seleccionada en el DateTimePicker
            DateTime horaSalida = dtpHoraSalida.Value;

            // Devolver la hora en formato "HH:mm"
            return horaSalida.ToString("HH:mm");
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            // Obtener la hora de salida en formato de cadena de caracteres
            string horaSalidaStr = ValidarHoraSalida();

            // Guardar la hora en el TextBox
            txtHoraSalida.Text = horaSalidaStr;

        }

        //Valida la hora de llegada

        public string ValidarHoraLlegada()
        {
            // Obtener la hora seleccionada en el DateTimePicker
            DateTime horaLlegada = dtpHoraLlegada.Value;

            // Devolver la hora en formato "HH:mm"
            return horaLlegada.ToString("HH:mm");
        }

        private void btnLlegada_Click(object sender, EventArgs e)
        {
            // Obtener la hora de salida en formato de cadena de caracteres
            string horaLlegadaStr = ValidarHoraLlegada();

            // Guardar la hora en el TextBox
            txtHoraLlegada.Text = horaLlegadaStr;
        }

        private void btnAgregarLugares_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario en los TextBoxes
            string lugarVisita = txtLugarVisita.Text;
            string canton = txtCanton.Text;
            string distrito = txtDistrito.Text;

            // Crear un nuevo arreglo de strings con la información ingresada
            string[] row = { lugarVisita, canton, distrito };

            // Agregar el arreglo como una nueva fila al DataGridView
            grdLugaresVisita.Rows.Add(row);

            // Limpiar los TextBoxes después de agregar la fila
            txtLugarVisita.Clear();
            txtCanton.Clear();
            txtDistrito.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada en el DataGridView
            int rowIndex = grdLugaresVisita.SelectedCells[0].RowIndex;

            // Eliminar la fila seleccionada del DataGridView
            if (rowIndex >= 0 && rowIndex < grdLugaresVisita.Rows.Count)
            {
                grdLugaresVisita.Rows.RemoveAt(rowIndex);
            }
        }
    }
}
