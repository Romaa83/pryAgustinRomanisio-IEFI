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

namespace pryAgustinRomanisio_IEFI
{
    public partial class frmListadoSocios : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb"); //Socio
        OleDbConnection ConexionBD2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb"); 
        OleDbCommand ComandoBD = new OleDbCommand();
        OleDbCommand ComandoBD2 = new OleDbCommand();

        public frmListadoSocios()
        {
            InitializeComponent();
        }

        private void frmListadoSocios_Load(object sender, EventArgs e)
        {
            //Procedimiento para ver si se conecta a la base de datos
            try
            {
                Conexion.Open();
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.Connection = Conexion;
                toolStripStatusLabel1.Text = "Conectado a la base de datos!" + "  " + DateTime.Now;
                SSEstado.BackColor = Color.Green;
                Conexion.Close();
            }
            catch (Exception error)
            {
                toolStripStatusLabel1.Text = error.Message;
                SSEstado.BackColor = Color.Red;

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvListadoSocios.Rows.Clear();
            Conexion.Open();
            ComandoBD.Connection = Conexion;
            ComandoBD.CommandText = "Socio";
            OleDbDataReader lector = ComandoBD.ExecuteReader();

            while (lector.Read())
            {
                string NombreBarrio = "";
                string NombreActividad = "";

                //Se abre otra conexion para mostrar el nombre del barrio 

                ConexionBD2.Open(); 
                ComandoBD2.Connection = ConexionBD2;
                ComandoBD2.CommandType = CommandType.TableDirect;
                ComandoBD2.CommandText = "Barrio";
                OleDbDataReader lector2 = ComandoBD2.ExecuteReader();
                while (lector2.Read() && NombreBarrio == "")
                {
                    if (lector2.GetInt32(0) == lector.GetInt32(3))
                    {
                        NombreBarrio = lector2.GetString(1);
                        
                    }
                }
                ConexionBD2.Close();

                //Se abre otra conexion para mostrar el nombre de la actividad

                ConexionBD2.Open(); 
                ComandoBD2.Connection = ConexionBD2;
                ComandoBD2.CommandText = "Actividad";
                OleDbDataReader lector3 = ComandoBD2.ExecuteReader();
                while (lector3.Read() && NombreActividad == "")
                {
                    if (lector3.GetInt32(0) == lector.GetInt32(4))
                    {
                        NombreActividad = lector3.GetString(1);
                    }
                }
                ConexionBD2.Close();

                //Se agregan en la grilla
                dgvListadoSocios.Rows.Add(lector.GetInt32(0), lector.GetString(1), 
                    lector.GetString(2), NombreBarrio, NombreActividad, lector.GetDecimal(5));

            }
            Conexion.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
