namespace pryParedesTPDeportes
{
    partial class frmRegistroEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEntrenador));
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblConexion = new System.Windows.Forms.Label();
            this.lblCorrectaONo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "Tenis",
            "Ciclismo",
            "Basquet",
            "Futbol",
            "Rugby",
            "Atletismo",
            "Handball",
            "Padel"});
            this.lstDeporte.Location = new System.Drawing.Point(149, 165);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 56;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(149, 131);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ShortcutsEnabled = false;
            this.txtProvincia.Size = new System.Drawing.Size(100, 20);
            this.txtProvincia.TabIndex = 55;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            this.txtProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvincia_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(149, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 54;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(149, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 53;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 52;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.Location = new System.Drawing.Point(149, 10);
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.ShortcutsEnabled = false;
            this.txtCodigoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeportista.TabIndex = 51;
            this.txtCodigoDeportista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDeportista_KeyPress);
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(12, 168);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(56, 13);
            this.lblDeporte.TabIndex = 50;
            this.lblDeporte.Text = "Deporte:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(12, 134);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(64, 13);
            this.lblProvincia.TabIndex = 49;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 103);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 48;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 47;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportista.Location = new System.Drawing.Point(12, 10);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(112, 13);
            this.lblCodigoDeportista.TabIndex = 45;
            this.lblCodigoDeportista.Text = "Codigo Deportista:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(89, 247);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 32);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargar.Location = new System.Drawing.Point(15, 209);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(234, 32);
            this.btnCargar.TabIndex = 57;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(12, 295);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(54, 13);
            this.lblConexion.TabIndex = 59;
            this.lblConexion.Text = "Conexion:";
            // 
            // lblCorrectaONo
            // 
            this.lblCorrectaONo.AutoSize = true;
            this.lblCorrectaONo.Location = new System.Drawing.Point(65, 295);
            this.lblCorrectaONo.Name = "lblCorrectaONo";
            this.lblCorrectaONo.Size = new System.Drawing.Size(0, 13);
            this.lblCorrectaONo.TabIndex = 60;
            // 
            // frmRegistroEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 317);
            this.Controls.Add(this.lblCorrectaONo);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoDeportista);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroEntrenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Entrenador";
            this.Load += new System.EventHandler(this.frmRegistroEntrenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Label lblCorrectaONo;
    }
}