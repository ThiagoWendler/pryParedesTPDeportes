namespace pryParedesTPDeportes
{
    partial class frmConsultaDeportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDeportista));
            this.lblCorrectaONo = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsultaDeportista = new System.Windows.Forms.DataGridView();
            this.lblConsultaDeportista = new System.Windows.Forms.Label();
            this.CodigoDeportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDeportista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorrectaONo
            // 
            this.lblCorrectaONo.AutoSize = true;
            this.lblCorrectaONo.Location = new System.Drawing.Point(62, 271);
            this.lblCorrectaONo.Name = "lblCorrectaONo";
            this.lblCorrectaONo.Size = new System.Drawing.Size(0, 13);
            this.lblCorrectaONo.TabIndex = 71;
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(9, 271);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(54, 13);
            this.lblConexion.TabIndex = 70;
            this.lblConexion.Text = "Conexion:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(278, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 36);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(193, 188);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(283, 36);
            this.btnConsultar.TabIndex = 68;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsultaDeportista
            // 
            this.dgvConsultaDeportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaDeportista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDeportista,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Edad,
            this.Deporte});
            this.dgvConsultaDeportista.Location = new System.Drawing.Point(12, 32);
            this.dgvConsultaDeportista.Name = "dgvConsultaDeportista";
            this.dgvConsultaDeportista.Size = new System.Drawing.Size(649, 150);
            this.dgvConsultaDeportista.TabIndex = 67;
            // 
            // lblConsultaDeportista
            // 
            this.lblConsultaDeportista.AutoSize = true;
            this.lblConsultaDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaDeportista.Location = new System.Drawing.Point(200, 4);
            this.lblConsultaDeportista.Name = "lblConsultaDeportista";
            this.lblConsultaDeportista.Size = new System.Drawing.Size(237, 25);
            this.lblConsultaDeportista.TabIndex = 66;
            this.lblConsultaDeportista.Text = "Consultar deportistas";
            // 
            // CodigoDeportista
            // 
            this.CodigoDeportista.HeaderText = "Codigo Deportista";
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
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Deporte
            // 
            this.Deporte.HeaderText = "Deporte";
            this.Deporte.Name = "Deporte";
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 305);
            this.Controls.Add(this.lblCorrectaONo);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsultaDeportista);
            this.Controls.Add(this.lblConsultaDeportista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaDeportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Deportista";
            this.Load += new System.EventHandler(this.frmConsultaDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaDeportista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrectaONo;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvConsultaDeportista;
        private System.Windows.Forms.Label lblConsultaDeportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deporte;
    }
}