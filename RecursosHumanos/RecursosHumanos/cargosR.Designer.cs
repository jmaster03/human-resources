namespace RecursosHumanos
{
    partial class cargosR
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
            this.cargosrc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cargosrc
            // 
            this.cargosrc.ActiveViewIndex = -1;
            this.cargosrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cargosrc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cargosrc.DisplayStatusBar = false;
            this.cargosrc.DisplayToolbar = false;
            this.cargosrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cargosrc.Location = new System.Drawing.Point(0, 0);
            this.cargosrc.Name = "cargosrc";
            this.cargosrc.Size = new System.Drawing.Size(800, 450);
            this.cargosrc.TabIndex = 0;
            this.cargosrc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cargosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cargosrc);
            this.Name = "cargosR";
            this.Text = "cargosR";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cargosrc;
    }
}