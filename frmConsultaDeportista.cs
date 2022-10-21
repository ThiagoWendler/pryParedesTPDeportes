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
    public partial class frmConsultaDeportista : Form
    {
        public frmConsultaDeportista()
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

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            dgvConsultaDeportista.Rows.Clear();
            try
            {
                ConexionDeLaBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data source=" + RutaDeBD);
                ConexionDeLaBD.Open();

                //Se da inicio a la BD
                ComandosDeLaBD = new OleDbCommand();

                //Se encarga de traer todo lo de la tabla de Access
                ComandosDeLaBD.Connection = ConexionDeLaBD;
                ComandosDeLaBD.CommandType = CommandType.TableDirect;
                ComandosDeLaBD.CommandText = "DEPORTISTA";

                //Trae la tabla
                LectorDeLaBD = ComandosDeLaBD.ExecuteReader();

                while (LectorDeLaBD.Read())
                {
                    //Muestra todo lo de la base de datos en la grilla 
                    dgvConsultaDeportista.Rows.Add(LectorDeLaBD[0], LectorDeLaBD[1], LectorDeLaBD[2], LectorDeLaBD[3], LectorDeLaBD[4], LectorDeLaBD[5], LectorDeLaBD[6]);
                }
                LectorDeLaBD.Close();
                ConexionDeLaBD.Close();
            }
            catch (Exception MensajeNada)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
