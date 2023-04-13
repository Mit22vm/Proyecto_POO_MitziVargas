
namespace Proyecto_POO_MitziVargas
{
    partial class FrmFuncionarioChofer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscarChofer = new System.Windows.Forms.Button();
            this.grdListaFun = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFun)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscarChofer);
            this.groupBox1.Controls.Add(this.grdListaFun);
            this.groupBox1.Controls.Add(this.txtNombreChofer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infornación de chofer";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(473, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(341, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscarChofer
            // 
            this.btnBuscarChofer.Location = new System.Drawing.Point(438, 80);
            this.btnBuscarChofer.Name = "btnBuscarChofer";
            this.btnBuscarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarChofer.TabIndex = 3;
            this.btnBuscarChofer.Text = "Buscar";
            this.btnBuscarChofer.UseVisualStyleBackColor = true;
            this.btnBuscarChofer.Click += new System.EventHandler(this.btnBuscarChofer_Click);
            // 
            // grdListaFun
            // 
            this.grdListaFun.AllowUserToAddRows = false;
            this.grdListaFun.AllowUserToDeleteRows = false;
            this.grdListaFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaFun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.telefono2,
            this.Column3,
            this.Column2,
            this.existe,
            this.Nombre,
            this.apellido1,
            this.apellido2,
            this.telefono1});
            this.grdListaFun.Location = new System.Drawing.Point(44, 148);
            this.grdListaFun.Name = "grdListaFun";
            this.grdListaFun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaFun.Size = new System.Drawing.Size(518, 136);
            this.grdListaFun.TabIndex = 2;
            this.grdListaFun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaFun_CellContentClick);
            this.grdListaFun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaFun_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_Cedula";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // telefono2
            // 
            this.telefono2.DataPropertyName = "telefono2";
            this.telefono2.HeaderText = "Telefono(2)";
            this.telefono2.Name = "telefono2";
            this.telefono2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Existe";
            this.Column3.HeaderText = "email";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "nombre";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // existe
            // 
            this.existe.HeaderText = "existe";
            this.existe.Name = "existe";
            this.existe.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCompleto";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 400;
            // 
            // apellido1
            // 
            this.apellido1.DataPropertyName = "apellido1";
            this.apellido1.HeaderText = "Primer Apellido";
            this.apellido1.Name = "apellido1";
            this.apellido1.Visible = false;
            // 
            // apellido2
            // 
            this.apellido2.DataPropertyName = "apellido2";
            this.apellido2.HeaderText = "Segundo Apellido";
            this.apellido2.Name = "apellido2";
            this.apellido2.Visible = false;
            // 
            // telefono1
            // 
            this.telefono1.DataPropertyName = "telefono1";
            this.telefono1.HeaderText = "Telefono(1)";
            this.telefono1.Name = "telefono1";
            this.telefono1.Visible = false;
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(44, 83);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.Size = new System.Drawing.Size(372, 20);
            this.txtNombreChofer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Chofer:";
            // 
            // FrmFuncionarioChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFuncionarioChofer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario Chofer";
            this.Load += new System.EventHandler(this.FrmFuncionarioChofer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarChofer;
        private System.Windows.Forms.DataGridView grdListaFun;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn existe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1;
    }
}