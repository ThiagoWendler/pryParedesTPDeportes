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
    public partial class frmRegistroEntrenador : Form
    {
        public frmRegistroEntrenador()
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

        private void frmRegistroEntrenador_Load(object sender, EventArgs e)
        {
            //Uso de Try-Catch, "Try" para probar el codigo, en caso de no funcionar correctamente, "Catch" se encarga de evitar un crasheo del programa 
            try
            {
                //En caso de funcionar, el color de la StatusStrip cambia a verde
                lblCorrectaONo.Text = "Conexion establecida correctamente";
                lblCorrectaONo.ForeColor = Color.Green;


            }
            catch (Exception MensajeDeError)
            {
                //En caso de NO funcionar, el color de la StatusStrip cambia a rojo
                lblCorrectaONo.Text = "Conexion Incorrecta";
                lblCorrectaONo.ForeColor = Color.Red;


            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Abro la BD
                ConexionDeLaBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaDeBD);
                ConexionDeLaBD.Open();

                ComandosDeLaBD = new OleDbCommand();

                ComandosDeLaBD.Connection = ConexionDeLaBD; //Conexion de los datos
                ComandosDeLaBD.CommandType = CommandType.Text;
                ComandosDeLaBD.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    " VALUES ('" + txtCodigoDeportista.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "','" + txtProvincia.Text + "','" + lstDeporte.SelectedItem + "')";

                
                ComandosDeLaBD.ExecuteNonQuery(); //Son el numero de filas afectadas
                MessageBox.Show("Los datos fueron almacenados con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ErrorDeDatos)
            {
                MessageBox.Show("No fue posible guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ConexionDeLaBD.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoDeportista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Comprueba y no permite al usuario escribir un dato incorrecto, se basa en la tabla ASCII
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Comprueba y no permite al usuario escribir un dato incorrecto, se basa en la tabla ASCII
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Comprueba y no permite al usuario escribir un dato incorrecto, se basa en la tabla ASCII
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Comprueba y no permite al usuario escribir un dato incorrecto, se basa en la tabla ASCII
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Comprueba y no permite al usuario escribir un dato incorrecto, se basa en la tabla ASCII
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
