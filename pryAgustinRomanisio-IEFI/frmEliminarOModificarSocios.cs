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
    public partial class frmEliminarOModificarSocios : Form
    {
        OleDbConnection Conexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbConnection ConexionBD2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Gimnasio.accdb");
        OleDbCommand ComandoBD = new OleDbCommand();
        OleDbCommand ComandoBD2 = new OleDbCommand();
        bool Bandera = false; //creo bandera para determinar que boton se toco

        public frmEliminarOModificarSocios()
        {
            InitializeComponent();
        }

        private void frmEliminarOModificarSocios_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtNombreApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtSaldo.Enabled = false;
            cboBarrio.Enabled = false;
            cboActividad.Enabled = false;

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
                        if (lector.GetInt32(0) == Convert.ToInt32(txtDNI.Text)) //SE BUSCA POR DNI
                        {
                            txtNombreApellido.Enabled = true;
                            txtDireccion.Enabled = true;
                            txtSaldo.Enabled = true;
                            cboBarrio.Enabled = true;
                            cboActividad.Enabled = true;

                            bandera = true;
                            txtNombreApellido.Text = lector.GetString(1);
                            txtDireccion.Text = lector.GetString(2);
                            ConexionBD2.Open(); //ABRO UNA SEGUNDA CONEXION QUE CONECTA LA TABLA BARRIO
                            ComandoBD2.Connection = ConexionBD2;
                            ComandoBD2.CommandType = CommandType.TableDirect;
                            ComandoBD2.CommandText = "Barrio";
                            OleDbDataReader lector2 = ComandoBD2.ExecuteReader();
                            while (lector2.Read())
                            {
                                if (lector2.GetInt32(0) == lector.GetInt32(3)) //CUANDO EL LECTOR2 ENCUENTRA EL NUMERO DEL LECTOR.
                                {
                                    cboBarrio.Text = lector2.GetString(1); //MUESTRA EL DETALLE DE LA TABLA
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
                                    cboActividad.Text = lector3.GetString(1);
                                }
                            }
                            ConexionBD2.Close();
                            txtSaldo.Text = Convert.ToString(lector.GetDecimal(5));
                            btnEliminar.Enabled = true;
                            btnModificar.Enabled = true;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Bandera = false;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codBarrio = 0;
            int codActividad = 0;
            if (txtNombreApellido.Text != "" && txtDireccion.Text != "" && txtSaldo.Text != "")
            {
                if (Bandera == false) //Si la bandera es falsa, quiere decir que se toco el boton MODIFICAR
                {
                    //Se abre una conexion para tomar la tabla Barrio
                    ConexionBD2.Open();
                    ComandoBD2.Connection = ConexionBD2;
                    ComandoBD2.CommandType = CommandType.TableDirect;
                    ComandoBD2.CommandText = "Barrio";
                    OleDbDataReader lector = ComandoBD2.ExecuteReader();

                    while (lector.Read() && cboBarrio.Text != lector.GetString(1))
                    {
                    }
                    if (cboBarrio.Text == lector.GetString(1))
                    {
                        codBarrio = lector.GetInt32(0);
                    }
                    ConexionBD2.Close();

                    //Se abre de nuevo para tomar la tabla actividad
                    ConexionBD2.Open();
                    ComandoBD2.Connection = ConexionBD2;
                    ComandoBD2.CommandType = CommandType.TableDirect;
                    ComandoBD2.CommandText = "Actividad";
                    OleDbDataReader lector2 = ComandoBD2.ExecuteReader();
                    while (lector2.Read() && cboActividad.Text != lector2.GetString(1))
                    {
                    }
                    if (cboActividad.Text == lector2.GetString(1))
                    {
                        codActividad = lector2.GetInt32(0);
                    }
                    codActividad = lector2.GetInt32(0);
                    ConexionBD2.Close();

                    //Se abre una nueva conexion para actualizar los datos 
                    Conexion.Open();
                    using (System.Data.OleDb.OleDbCommand comandoModificar = new System.Data.OleDb.OleDbCommand(
                            "UPDATE Socio SET Nombre_Apellido=@NOMBRE, DIRECCION=@DIRECCION," +
                            "Codigo_Barrio=@BARRIO,Codigo_Actividad=@ACTIVIDAD, Saldo=@SALDO WHERE Dni_Socio=@DNI", Conexion)) //creo comando, sentencia sql, y lo conecto con la base
                    {
                        comandoModificar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NOMBRE", txtNombreApellido.Text));
                        comandoModificar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DIRECCION", txtDireccion.Text));
                        comandoModificar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@BARRIO", codBarrio));
                        comandoModificar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@ACTIVIDAD", codActividad));
                        comandoModificar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@SALDO", txtSaldo.Text));
                        comandoModificar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DNI", txtDNI.Text));
                        comandoModificar.ExecuteNonQuery();
                        MessageBox.Show("Actualizado con exito!!");
                    }
                    Conexion.Close();

                    txtNombreApellido.Text = "";
                    txtDireccion.Text = "";
                    cboBarrio.SelectedIndex = -1;
                    cboActividad.SelectedIndex = -1;
                    txtSaldo.Text = "";
                    btnGuardar.Enabled = false;
                    txtNombreApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtSaldo.Enabled = false;
                    cboBarrio.Enabled = false;
                    cboActividad.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;

                }
                if (Bandera == true) //Si la bandera es verdadera, quiere decir que se toco el boton ELIMINAR
                {
                    Conexion.Open();
                    using (System.Data.OleDb.OleDbCommand comandoEliminar = new System.Data.OleDb.OleDbCommand("DELETE * FROM Socio WHERE Dni_Socio=" +
                        txtDNI.Text + "", Conexion))
                    {
                        comandoEliminar.ExecuteNonQuery();
                        MessageBox.Show("Datos ELIMINADOS con exito!!");
                    }
                    Conexion.Close();
                    txtNombreApellido.Text = "";
                    txtDireccion.Text = "";
                    cboBarrio.SelectedIndex = -1;
                    cboActividad.SelectedIndex = -1;
                    txtSaldo.Text = "";
                    btnGuardar.Enabled = false;
                    txtNombreApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtSaldo.Enabled = false;
                    cboBarrio.Enabled = false;
                    cboActividad.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese TODOS los valores");
                txtNombreApellido.Text = "";
                txtDireccion.Text = "";
                cboBarrio.SelectedIndex = -1;
                cboActividad.SelectedIndex = -1;
                txtSaldo.Text = "";
                btnGuardar.Enabled = false;
                txtNombreApellido.Enabled = false;
                txtDireccion.Enabled = false;
                txtSaldo.Enabled = false;
                cboBarrio.Enabled = false;
                cboActividad.Enabled = false;
            }
            

            
            if (Bandera == true) //Si la bandera es verdadera, quiere decir que se toco el boton ELIMINAR
            {
                Conexion.Open();
                using (System.Data.OleDb.OleDbCommand comandoEliminar = new System.Data.OleDb.OleDbCommand("DELETE * FROM Socio WHERE Dni_Socio=" +
                    txtDNI.Text + "", Conexion))
                {
                    comandoEliminar.ExecuteNonQuery();
                    MessageBox.Show("Datos ELIMINADOS con exito!!");
                }
                Conexion.Close();
                txtNombreApellido.Text = "";
                txtDireccion.Text = "";
                cboBarrio.SelectedIndex = -1;
                cboActividad.SelectedIndex = -1;
                txtSaldo.Text = "";
                btnGuardar.Enabled = false;
                txtNombreApellido.Enabled = false;
                txtDireccion.Enabled = false;
                txtSaldo.Enabled = false;
                cboBarrio.Enabled = false;
                cboActividad.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Bandera = true; 
            btnGuardar.Enabled = true;
        }
    }
}
