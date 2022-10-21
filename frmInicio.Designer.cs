namespace pryParedesTPDeportes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stpIndicadorRuta = new System.Windows.Forms.StatusStrip();
            this.mspInicio = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxFondo = new System.Windows.Forms.PictureBox();
            this.mspInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // stpIndicadorRuta
            // 
            this.stpIndicadorRuta.Location = new System.Drawing.Point(0, 183);
            this.stpIndicadorRuta.Name = "stpIndicadorRuta";
            this.stpIndicadorRuta.Size = new System.Drawing.Size(484, 22);
            this.stpIndicadorRuta.TabIndex = 0;
            this.stpIndicadorRuta.Text = "statusStrip1";
            // 
            // mspInicio
            // 
            this.mspInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mspInicio.Location = new System.Drawing.Point(0, 0);
            this.mspInicio.Name = "mspInicio";
            this.mspInicio.Size = new System.Drawing.Size(484, 24);
            this.mspInicio.TabIndex = 1;
            this.mspInicio.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistaToolStripMenuItem,
            this.entrenadorToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistaToolStripMenuItem1,
            this.entrenadorToolStripMenuItem1});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // deportistaToolStripMenuItem
            // 
            this.deportistaToolStripMenuItem.Name = "deportistaToolStripMenuItem";
            this.deportistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deportistaToolStripMenuItem.Text = "Deportista";
            this.deportistaToolStripMenuItem.Click += new System.EventHandler(this.deportistaToolStripMenuItem_Click);
            // 
            // entrenadorToolStripMenuItem
            // 
            this.entrenadorToolStripMenuItem.Name = "entrenadorToolStripMenuItem";
            this.entrenadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entrenadorToolStripMenuItem.Text = "Entrenador";
            this.entrenadorToolStripMenuItem.Click += new System.EventHandler(this.entrenadorToolStripMenuItem_Click);
            // 
            // deportistaToolStripMenuItem1
            // 
            this.deportistaToolStripMenuItem1.Name = "deportistaToolStripMenuItem1";
            this.deportistaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deportistaToolStripMenuItem1.Text = "Deportista";
            this.deportistaToolStripMenuItem1.Click += new System.EventHandler(this.deportistaToolStripMenuItem1_Click);
            // 
            // entrenadorToolStripMenuItem1
            // 
            this.entrenadorToolStripMenuItem1.Name = "entrenadorToolStripMenuItem1";
            this.entrenadorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entrenadorToolStripMenuItem1.Text = "Entrenador";
            this.entrenadorToolStripMenuItem1.Click += new System.EventHandler(this.entrenadorToolStripMenuItem1_Click);
            // 
            // pbxFondo
            // 
            this.pbxFondo.Image = ((System.Drawing.Image)(resources.GetObject("pbxFondo.Image")));
            this.pbxFondo.Location = new System.Drawing.Point(0, 27);
            this.pbxFondo.Name = "pbxFondo";
            this.pbxFondo.Size = new System.Drawing.Size(484, 166);
            this.pbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFondo.TabIndex = 2;
            this.pbxFondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 205);
            this.Controls.Add(this.pbxFondo);
            this.Controls.Add(this.stpIndicadorRuta);
            this.Controls.Add(this.mspInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspInicio;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspInicio.ResumeLayout(false);
            this.mspInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stpIndicadorRuta;
        private System.Windows.Forms.MenuStrip mspInicio;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbxFondo;
    }
}

