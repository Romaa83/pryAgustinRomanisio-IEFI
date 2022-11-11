namespace pryAgustinRomanisio_IEFI
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SSEstado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeSociosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosPorActividadOBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SSEstado.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSEstado
            // 
            this.SSEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SSEstado.Location = new System.Drawing.Point(0, 395);
            this.SSEstado.Name = "SSEstado";
            this.SSEstado.Size = new System.Drawing.Size(731, 22);
            this.SSEstado.TabIndex = 0;
            this.SSEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sociosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSociosToolStripMenuItem,
            this.consultarSociosToolStripMenuItem,
            this.modificarOEliminarSociosToolStripMenuItem,
            this.toolStripSeparator1,
            this.listadoDeSociosToolStripMenuItem1,
            this.listadoDeSociosToolStripMenuItem,
            this.listadoDeSociosPorActividadOBarrioToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // agregarSociosToolStripMenuItem
            // 
            this.agregarSociosToolStripMenuItem.Name = "agregarSociosToolStripMenuItem";
            this.agregarSociosToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.agregarSociosToolStripMenuItem.Text = "Agregar Socios...";
            this.agregarSociosToolStripMenuItem.Click += new System.EventHandler(this.agregarSociosToolStripMenuItem_Click);
            // 
            // consultarSociosToolStripMenuItem
            // 
            this.consultarSociosToolStripMenuItem.Name = "consultarSociosToolStripMenuItem";
            this.consultarSociosToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.consultarSociosToolStripMenuItem.Text = "Consultar Socios...";
            this.consultarSociosToolStripMenuItem.Click += new System.EventHandler(this.consultarSociosToolStripMenuItem_Click);
            // 
            // modificarOEliminarSociosToolStripMenuItem
            // 
            this.modificarOEliminarSociosToolStripMenuItem.Name = "modificarOEliminarSociosToolStripMenuItem";
            this.modificarOEliminarSociosToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.modificarOEliminarSociosToolStripMenuItem.Text = "Modificar o Eliminar Socios...";
            this.modificarOEliminarSociosToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarSociosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // listadoDeSociosToolStripMenuItem1
            // 
            this.listadoDeSociosToolStripMenuItem1.Name = "listadoDeSociosToolStripMenuItem1";
            this.listadoDeSociosToolStripMenuItem1.Size = new System.Drawing.Size(291, 22);
            this.listadoDeSociosToolStripMenuItem1.Text = "Listado de socios...";
            this.listadoDeSociosToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeSociosToolStripMenuItem1_Click);
            // 
            // listadoDeSociosToolStripMenuItem
            // 
            this.listadoDeSociosToolStripMenuItem.Name = "listadoDeSociosToolStripMenuItem";
            this.listadoDeSociosToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.listadoDeSociosToolStripMenuItem.Text = "Listado de saldos...";
            this.listadoDeSociosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosToolStripMenuItem_Click);
            // 
            // listadoDeSociosPorActividadOBarrioToolStripMenuItem
            // 
            this.listadoDeSociosPorActividadOBarrioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadToolStripMenuItem,
            this.barrioToolStripMenuItem});
            this.listadoDeSociosPorActividadOBarrioToolStripMenuItem.Name = "listadoDeSociosPorActividadOBarrioToolStripMenuItem";
            this.listadoDeSociosPorActividadOBarrioToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.listadoDeSociosPorActividadOBarrioToolStripMenuItem.Text = "Listado de socios por Actividad o Barrio...";
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actividadToolStripMenuItem.Text = "Actividad";
            this.actividadToolStripMenuItem.Click += new System.EventHandler(this.actividadToolStripMenuItem_Click);
            // 
            // barrioToolStripMenuItem
            // 
            this.barrioToolStripMenuItem.Name = "barrioToolStripMenuItem";
            this.barrioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barrioToolStripMenuItem.Text = "Barrio";
            this.barrioToolStripMenuItem.Click += new System.EventHandler(this.barrioToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 417);
            this.Controls.Add(this.SSEstado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.SSEstado.ResumeLayout(false);
            this.SSEstado.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SSEstado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosPorActividadOBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrioToolStripMenuItem;
    }
}

