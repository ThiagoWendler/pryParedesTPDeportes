using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryParedesTPDeportes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Se declara la ruta de la BD
        public string RutaDeBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";


        //Lector de BD
        public OleDbDataReader LectorDeLaBD;

        //Conexion de la BD
        public OleDbConnection ConexionDeLaBD;

        //Comandos de la BD
        public OleDbCommand ComandosDeLaBD;



        private void Form1_Load(object sender, EventArgs e)
        {
            //Uso de Try-Catch, "Try" para probar el codigo, en caso de no funcionar correctamente, "Catch" se encarga de evitar un crasheo del programa 
            try
            {
                //En caso de funcionar, el color de la StatusStrip cambia a verde
                stpIndicadorRuta.BackColor = Color.Green;
                
                
            }
            catch (Exception MensajeDeError)
            {
                //En caso de NO funcionar, el color de la StatusStrip cambia a rojo
                stpIndicadorRuta.BackColor = Color.Red;
                
                
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult, que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: Si - No)
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado del dialogo es Si, la aplicacion se cierra
            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeportista frmRegistroDeportista = new frmRegistroDeportista();
            frmRegistroDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenador frmRegistroEntrenador = new frmRegistroEntrenador();
            frmRegistroEntrenador.ShowDialog();
        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista frmConsultaDeportista = new frmConsultaDeportista();
            frmConsultaDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador frmConsultaEntrenador = new frmConsultaEntrenador();
            frmConsultaEntrenador.ShowDialog();

        }
    }
}
