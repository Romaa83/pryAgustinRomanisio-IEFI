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
    public partial class frmListadoSaldos : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();

        public frmListadoSaldos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvListadoSaldos.Rows.Clear();
            int ContadorSocios = 0;
            decimal ContadorSaldos = 0;
            Conexion.Open();
            ComandoBD.Connection = Conexion;
            ComandoBD.CommandType = CommandType.TableDirect;
            ComandoBD.CommandText = "Socio";

            OleDbDataReader lector = ComandoBD.ExecuteReader();

            while (lector.Read())
            {
                ContadorSocios++;
                dgvListadoSaldos.Rows.Add(lector.GetInt32(0), lector.GetString(1), lector.GetDecimal(5));
                ContadorSaldos = ContadorSaldos + lector.GetDecimal(5);
            }
            Conexion.Close();
            txtTotalSocios.Text = ContadorSocios.ToString();
            txtTotalSaldos.Text = ContadorSaldos.ToString();
            txtPromedioSaldos.Text = (ContadorSaldos / ContadorSocios).ToString("0.00");

        }

        private void frmListadoSaldos_Load(object sender, EventArgs e)
        {
            txtTotalSaldos.Enabled = false;
            txtTotalSocios.Enabled = false;
            txtPromedioSaldos.Enabled=false;
        }
    }
}
