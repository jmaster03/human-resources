namespace RecursosHumanos
{
    partial class empladosAR
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
            this.empleadosA = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // empleadosA
            // 
            this.empleadosA.ActiveViewIndex = -1;
            this.empleadosA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empleadosA.Cursor = System.Windows.Forms.Cursors.Default;
            this.empleadosA.DisplayStatusBar = false;
            this.empleadosA.DisplayToolbar = false;
            this.empleadosA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empleadosA.Location = new System.Drawing.Point(0, 0);
            this.empleadosA.Name = "empleadosA";
            this.empleadosA.Size = new System.Drawing.Size(800, 450);
            this.empleadosA.TabIndex = 0;
            this.empleadosA.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // empladosAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empleadosA);
            this.Name = "empladosAR";
            this.Text = "empladosA";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer empleadosA;
    }
}