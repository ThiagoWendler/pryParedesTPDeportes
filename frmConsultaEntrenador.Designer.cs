namespace pryParedesTPDeportes
{
    partial class frmConsultaEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEntrenador));
            this.lblConsultaEntrenador = new System.Windows.Forms.Label();
            this.dgvConsultaEntrenadores = new System.Windows.Forms.DataGridView();
            this.CodigoDeportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCorrectaONo = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaEntrenador
            // 
            this.lblConsultaEntrenador.AutoSize = true;
            this.lblConsultaEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaEntrenador.Location = new System.Drawing.Point(208, 8);
            this.lblConsultaEntrenador.Name = "lblConsultaEntrenador";
            this.lblConsultaEntrenador.Size = new System.Drawing.Size(259, 25);
            this.lblConsultaEntrenador.TabIndex = 8;
            this.lblConsultaEntrenador.Text = "Consultar entrenadores";
            // 
            // dgvConsultaEntrenadores
            // 
            this.dgvConsultaEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEntrenadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeportista,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Provincia,
            this.Deporte});
            this.dgvConsultaEntrenadores.Location = new System.Drawing.Point(20, 36);
            this.dgvConsultaEntrenadores.Name = "dgvConsultaEntrenadores";
            this.dgvConsultaEntrenadores.Size = new System.Drawing.Size(643, 150);
            this.dgvConsultaEntrenadores.TabIndex = 14;
            this.dgvConsultaEntrenadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaEntrenadores_CellContentClick);
            // 
            // CodigoDeportista
            // 
            this.CodigoDeportista.HeaderText = "Codigo Entrenador";
            this.CodigoDeportista.Name = "CodigoDeportista";
            this.CodigoDeportista.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            this.Deporte.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(201, 192);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(283, 36);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(286, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 36);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCorrectaONo
            // 
            this.lblCorrectaONo.AutoSize = true;
            this.lblCorrectaONo.Location = new System.Drawing.Point(70, 275);
            this.lblCorrectaONo.Name = "lblCorrectaONo";
            this.lblCorrectaONo.Size = new System.Drawing.Size(0, 13);
            this.lblCorrectaONo.TabIndex = 65;
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(17, 275);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(54, 13);
            this.lblConexion.TabIndex = 64;
            this.lblConexion.Text = "Conexion:";
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 304);
            this.Controls.Add(this.lblCorrectaONo);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaEntrenadores);
            this.Controls.Add(this.lblConsultaEntrenador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta de Entrenador";
            this.Load += new System.EventHandler(this.frmConsultaEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaEntrenador;
        private System.Windows.Forms.DataGridView dgvConsultaEntrenadores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
        private System.Windows.Forms.Label lblCorrectaONo;
        private System.Windows.Forms.Label lblConexion;
    }
}