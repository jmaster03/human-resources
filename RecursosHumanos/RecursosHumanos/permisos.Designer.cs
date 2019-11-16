namespace RecursosHumanos
{
    partial class permisos
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
            this.permisosrc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // permisosrc
            // 
            this.permisosrc.ActiveViewIndex = -1;
            this.permisosrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.permisosrc.Cursor = System.Windows.Forms.Cursors.Default;
            this.permisosrc.DisplayStatusBar = false;
            this.permisosrc.DisplayToolbar = false;
            this.permisosrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permisosrc.Location = new System.Drawing.Point(0, 0);
            this.permisosrc.Name = "permisosrc";
            this.permisosrc.Size = new System.Drawing.Size(800, 450);
            this.permisosrc.TabIndex = 0;
            this.permisosrc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.permisosrc);
            this.Name = "permisos";
            this.Text = "permisos";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer permisosrc;
    }
}