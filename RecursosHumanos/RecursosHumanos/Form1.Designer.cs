namespace RecursosHumanos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosF = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.nominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmpleadosActivosR = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosInactivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesPorAñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.btnNomina,
            this.Reportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpleadosF});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // EmpleadosF
            // 
            this.EmpleadosF.Name = "EmpleadosF";
            this.EmpleadosF.Size = new System.Drawing.Size(132, 22);
            this.EmpleadosF.Text = "Empleados";
            this.EmpleadosF.Click += new System.EventHandler(this.EmpleadosF_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(108, 20);
            this.btnNomina.Text = "Calcular Nomina";
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominasToolStripMenuItem,
            this.btnEmpleadosActivosR,
            this.empleadosInactivosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.cargosToolStripMenuItem1,
            this.entradasPorMesToolStripMenuItem,
            this.salidasPorMesToolStripMenuItem,
            this.vacacionesPorAñoToolStripMenuItem,
            this.permisosToolStripMenuItem1});
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 20);
            this.Reportes.Text = "Reportes";
            // 
            // nominasToolStripMenuItem
            // 
            this.nominasToolStripMenuItem.Name = "nominasToolStripMenuItem";
            this.nominasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nominasToolStripMenuItem.Text = "Nominas";
            this.nominasToolStripMenuItem.Click += new System.EventHandler(this.nominasToolStripMenuItem_Click);
            // 
            // btnEmpleadosActivosR
            // 
            this.btnEmpleadosActivosR.Name = "btnEmpleadosActivosR";
            this.btnEmpleadosActivosR.Size = new System.Drawing.Size(182, 22);
            this.btnEmpleadosActivosR.Text = "Empleados Activos";
            this.btnEmpleadosActivosR.Click += new System.EventHandler(this.btnEmpleadosActivosR_Click);
            // 
            // empleadosInactivosToolStripMenuItem
            // 
            this.empleadosInactivosToolStripMenuItem.Name = "empleadosInactivosToolStripMenuItem";
            this.empleadosInactivosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.empleadosInactivosToolStripMenuItem.Text = "Empleados Inactivos";
            this.empleadosInactivosToolStripMenuItem.Click += new System.EventHandler(this.empleadosInactivosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem1
            // 
            this.cargosToolStripMenuItem1.Name = "cargosToolStripMenuItem1";
            this.cargosToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.cargosToolStripMenuItem1.Text = "Cargos";
            this.cargosToolStripMenuItem1.Click += new System.EventHandler(this.cargosToolStripMenuItem1_Click);
            // 
            // entradasPorMesToolStripMenuItem
            // 
            this.entradasPorMesToolStripMenuItem.Name = "entradasPorMesToolStripMenuItem";
            this.entradasPorMesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entradasPorMesToolStripMenuItem.Text = "Entradas por Mes";
            // 
            // salidasPorMesToolStripMenuItem
            // 
            this.salidasPorMesToolStripMenuItem.Name = "salidasPorMesToolStripMenuItem";
            this.salidasPorMesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salidasPorMesToolStripMenuItem.Text = "Salidas por mes";
            // 
            // vacacionesPorAñoToolStripMenuItem
            // 
            this.vacacionesPorAñoToolStripMenuItem.Name = "vacacionesPorAñoToolStripMenuItem";
            this.vacacionesPorAñoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.vacacionesPorAñoToolStripMenuItem.Text = "Vacaciones por año";
            // 
            // permisosToolStripMenuItem1
            // 
            this.permisosToolStripMenuItem1.Name = "permisosToolStripMenuItem1";
            this.permisosToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.permisosToolStripMenuItem1.Text = "Permisos";
            this.permisosToolStripMenuItem1.Click += new System.EventHandler(this.permisosToolStripMenuItem1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = global::RecursosHumanos.Properties.Resources.curso_gestion_rrhh;
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 24);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(718, 346);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 370);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RRHH La redonda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosF;
        private System.Windows.Forms.ToolStripMenuItem btnNomina;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.ToolStripMenuItem nominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEmpleadosActivosR;
        private System.Windows.Forms.ToolStripMenuItem empleadosInactivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradasPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacacionesPorAñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem1;
        private System.Windows.Forms.Panel panelContainer;
    }
}

