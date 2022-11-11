namespace pryAgustinRomanisio_IEFI
{
    partial class frmConsultaActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SSEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvListarActividad = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.gpbInformacion = new System.Windows.Forms.GroupBox();
            this.lblMayorSaldo = new System.Windows.Forms.Label();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSaldoMayor = new System.Windows.Forms.TextBox();
            this.txtSaldoMenor = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SSEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarActividad)).BeginInit();
            this.gpbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSEstado
            // 
            this.SSEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SSEstado.Location = new System.Drawing.Point(0, 693);
            this.SSEstado.Name = "SSEstado";
            this.SSEstado.Size = new System.Drawing.Size(757, 22);
            this.SSEstado.TabIndex = 43;
            this.SSEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 404);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 33);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvListarActividad
            // 
            this.dgvListarActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NombreApellido,
            this.Direccion,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvListarActividad.Location = new System.Drawing.Point(12, 108);
            this.dgvListarActividad.Name = "dgvListarActividad";
            this.dgvListarActividad.Size = new System.Drawing.Size(724, 277);
            this.dgvListarActividad.TabIndex = 41;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "Nombre y Apellido";
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.Width = 125;
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(625, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 33);
            this.btnListar.TabIndex = 40;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(333, 28);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(249, 33);
            this.cboActividad.TabIndex = 39;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(24, 31);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(247, 25);
            this.lblActividad.TabIndex = 38;
            this.lblActividad.Text = "Ingrese una Actividad:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(405, 404);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 33);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.Location = new System.Drawing.Point(524, 404);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(200, 33);
            this.btnGenerarInforme.TabIndex = 45;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // gpbInformacion
            // 
            this.gpbInformacion.Controls.Add(this.txtTotal);
            this.gpbInformacion.Controls.Add(this.txtPromedio);
            this.gpbInformacion.Controls.Add(this.txtSaldoMenor);
            this.gpbInformacion.Controls.Add(this.txtSaldoMayor);
            this.gpbInformacion.Controls.Add(this.lblTotal);
            this.gpbInformacion.Controls.Add(this.lblPromedio);
            this.gpbInformacion.Controls.Add(this.lblSaldoMenor);
            this.gpbInformacion.Controls.Add(this.lblMayorSaldo);
            this.gpbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacion.Location = new System.Drawing.Point(12, 457);
            this.gpbInformacion.Name = "gpbInformacion";
            this.gpbInformacion.Size = new System.Drawing.Size(712, 191);
            this.gpbInformacion.TabIndex = 46;
            this.gpbInformacion.TabStop = false;
            this.gpbInformacion.Text = "Información";
            // 
            // lblMayorSaldo
            // 
            this.lblMayorSaldo.AutoSize = true;
            this.lblMayorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorSaldo.Location = new System.Drawing.Point(8, 50);
            this.lblMayorSaldo.Name = "lblMayorSaldo";
            this.lblMayorSaldo.Size = new System.Drawing.Size(150, 25);
            this.lblMayorSaldo.TabIndex = 47;
            this.lblMayorSaldo.Text = "Saldo mayor:";
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.AutoSize = true;
            this.lblSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor.Location = new System.Drawing.Point(380, 50);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(151, 25);
            this.lblSaldoMenor.TabIndex = 48;
            this.lblSaldoMenor.Text = "Saldo menor:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(12, 127);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(118, 25);
            this.lblPromedio.TabIndex = 49;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(380, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 25);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "Total:";
            // 
            // txtSaldoMayor
            // 
            this.txtSaldoMayor.Location = new System.Drawing.Point(164, 47);
            this.txtSaldoMayor.Name = "txtSaldoMayor";
            this.txtSaldoMayor.Size = new System.Drawing.Size(164, 31);
            this.txtSaldoMayor.TabIndex = 51;
            // 
            // txtSaldoMenor
            // 
            this.txtSaldoMenor.Location = new System.Drawing.Point(537, 47);
            this.txtSaldoMenor.Name = "txtSaldoMenor";
            this.txtSaldoMenor.Size = new System.Drawing.Size(164, 31);
            this.txtSaldoMenor.TabIndex = 52;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(164, 124);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(164, 31);
            this.txtPromedio.TabIndex = 53;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(537, 124);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 31);
            this.txtTotal.TabIndex = 54;
            // 
            // frmConsultaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 715);
            this.Controls.Add(this.gpbInformacion);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.SSEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvListarActividad);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboActividad);
            this.Controls.Add(this.lblActividad);
            this.Name = "frmConsultaActividad";
            this.Text = "Consulta Actividad";
            this.Load += new System.EventHandler(this.frmConsultaActividad_Load);
            this.SSEstado.ResumeLayout(false);
            this.SSEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarActividad)).EndInit();
            this.gpbInformacion.ResumeLayout(false);
            this.gpbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SSEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvListarActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.GroupBox gpbInformacion;
        private System.Windows.Forms.Label lblMayorSaldo;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSaldoMayor;
        private System.Windows.Forms.TextBox txtSaldoMenor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}