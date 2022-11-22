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
    public partial class frmAgregarSocios : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();

        public frmAgregarSocios()
        {
            InitializeComponent();
        }

        private void frmAgregarSocios_Load(object sender, EventArgs e)
        {
            //Procedimiento para comprobar si conecta a la base de datos
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

            //Procedimiento para agregar al combobox Barrios
            Conexion.Open();
            ComandoBD.CommandText = "Barrio";
            OleDbDataReader lectorBarrio = ComandoBD.ExecuteReader();
            
            //Se recorre la tabla
            while (lectorBarrio.Read())
            {
                cboBarrio.Items.Add(lectorBarrio.GetString(1));
            }
            Conexion.Close();

            //Procedimiento para agregar al combobox Actividades
            Conexion.Open();
            ComandoBD.CommandText = "Actividad";
            OleDbDataReader lectorActividad = ComandoBD.ExecuteReader();

            //Se recorre la tabla
            while (lectorActividad.Read())
            {
                cboActividad.Items.Add(lectorActividad.GetString(1));
            }
            Conexion.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDniSocio.Text != "" && txtNombreApellido.Text != "" && txtDireccion.Text != "" && cboBarrio.SelectedIndex != -1 && cboActividad.SelectedIndex != -1 && txtSaldo.Text != "")
            {
                int codBarrio = 0;
                int codActividad = 0;

                Conexion.Open();
                ComandoBD.Connection = Conexion;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Barrio";

                OleDbDataReader lectorBarrio = ComandoBD.ExecuteReader();

                while (lectorBarrio.Read()) //Cambio el nombre del barrio por el numero que corresponde
                {
                    if (cboBarrio.Text == lectorBarrio.GetString(1))
                    {
                        codBarrio = lectorBarrio.GetInt32(0); //y lo agrego en una variable
                    }
                }
                Conexion.Close();

                Conexion.Open();
                ComandoBD.Connection = Conexion;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Actividad";
                OleDbDataReader lectorActividad = ComandoBD.ExecuteReader();

                while (lectorActividad.Read()) //Cambio el nombre de la actividad por el numero que corresponde
                {
                    if (cboActividad.Text == lectorActividad.GetString(1))
                    {
                        codActividad = lectorActividad.GetInt32(0); //y lo agrego en una variable
                    }
                }
                Conexion.Close();

                Conexion.Open();
                using (System.Data.OleDb.OleDbCommand ComandoAgregar = new System.Data.OleDb.OleDbCommand(
                            "INSERT INTO Socio (Dni_Socio, Nombre_Apellido, Direccion, Codigo_Barrio, Codigo_Actividad, Saldo) " +
                            "VALUES (@DNISOCIO, @NOMBREAPELLIDO, @DIRECCION, @BARRIO, @ACTIVIDAD, @SALDO)", Conexion)) //creo comando, sentencia sql
                {
                    ComandoAgregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DNISOCIO", txtDniSocio.Text));
                    ComandoAgregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NOMBREAPELLIDO", txtNombreApellido.Text));
                    ComandoAgregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DIRECCION", txtDireccion.Text));
                    ComandoAgregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@BARRIO", codBarrio));
                    ComandoAgregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@ACTIVIDAD", codActividad));
                    ComandoAgregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@SALDO", txtSaldo.Text));
                    ComandoAgregar.ExecuteNonQuery();
                    Conexion.Close();
                }
                txtDniSocio.Text = " ";
                txtNombreApellido.Text = " ";
                txtDireccion.Text = " ";
                cboBarrio.SelectedIndex = -1;
                cboActividad.SelectedIndex = -1;
                txtSaldo.Text = "";
                MessageBox.Show("Datos agregados con exito");
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos necesarios");
            }
         
        }

        private void txtDniSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //para que la txt solo permita numeros
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //para que la txt solo permita numeros
        }
    }
}
