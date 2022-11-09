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
    public partial class frmConsultarSocio : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();
        OleDbCommand ComandoBD2 = new OleDbCommand();

        public frmConsultarSocio()
        {
            InitializeComponent();
        }

        private void frmConsultarSocio_Load(object sender, EventArgs e)
        {
            //Procedimiento para ver si se puede conectar a la base de datos
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (txtDNI.Text != "")
            {
                try
                {
                    Conexion.Open();

                    ComandoBD.Connection = Conexion;
                    ComandoBD.CommandType = CommandType.TableDirect;
                    ComandoBD.CommandText = "Socio";
                    OleDbDataReader lector = ComandoBD.ExecuteReader();

                    while (lector.Read())
                    {
                        if (lector.GetInt32(0) == Convert.ToInt32(txtDNI.Text))
                        {
                            bandera = true;
                            lblMostrarNombre.Text = lector.GetString(1);
                            lblMostrarDireccion.Text = lector.GetString(2);
                            ConexionBD2.Open();
                            ComandoBD2.Connection = ConexionBD2;
                            ComandoBD2.CommandType = CommandType.TableDirect;
                            ComandoBD2.CommandText = "Barrio";
                            OleDbDataReader lector2 = ComandoBD2.ExecuteReader();
                            while (lector2.Read())
                            {
                                if (lector2.GetInt32(0) == lector.GetInt32(3))
                                {
                                    lblMostrarBarrio.Text = lector2.GetString(1);
                                }
                            }
                            ConexionBD2.Close();
                            ConexionBD2.Open();
                            ComandoBD2.Connection = ConexionBD2;
                            ComandoBD2.CommandType = CommandType.TableDirect;
                            ComandoBD2.CommandText = "Actividad";
                            OleDbDataReader lector3 = ComandoBD2.ExecuteReader();
                            while (lector3.Read())
                            {
                                if (lector3.GetInt32(0) == lector.GetInt32(4))
                                {
                                    lblMostrarACtividad.Text = lector3.GetString(1);
                                }
                            }
                            ConexionBD2.Close();
                            lblMostrarSaldo.Text = Convert.ToString(lector.GetDecimal(5));
                        }

                    }
                    if (bandera == false)
                    {

                        MessageBox.Show("Ese DNI no esta registrado en la base de datos");

                    }
                    Conexion.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Numero de DNI");
            }
           
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //para que la txt solo permita numeros
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
