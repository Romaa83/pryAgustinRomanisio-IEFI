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
    public partial class frmMenu : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb"); 
        OleDbCommand ComandoBD = new OleDbCommand();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try //Procedimiento para ver si se puede conectar a la base de datos
            {
                Conexion.Open();
                ComandoBD.CommandType = CommandType.TableDirect;
                toolStripStatusLabel1.Text = "Conectado a la base de datos!" +  "  " + DateTime.Now;
                SSEstado.BackColor = Color.Green;
                Conexion.Close();
            }
            catch (Exception error)
            {
                toolStripStatusLabel1.Text = error.Message;
                SSEstado.BackColor = Color.Red;

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarSocios frmAgregarSocios = new frmAgregarSocios();
            frmAgregarSocios.ShowDialog();
        }

        private void consultarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarSocio frmConsultarSocio = new frmConsultarSocio();
            frmConsultarSocio.ShowDialog();
        }

        private void modificarOEliminarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarOModificarSocios frmEliminarOModificarSocios = new frmEliminarOModificarSocios();
            frmEliminarOModificarSocios.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoSocios frmListadoSocios = new frmListadoSocios();
            frmListadoSocios.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSaldos frmListadoSaldos = new frmListadoSaldos();
            frmListadoSaldos.ShowDialog();
        }
    }
}
