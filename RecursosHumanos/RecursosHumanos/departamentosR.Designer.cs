namespace RecursosHumanos
{
    partial class departamentosR
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
            this.departamentoscrt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // departamentoscrt
            // 
            this.departamentoscrt.ActiveViewIndex = -1;
            this.departamentoscrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departamentoscrt.Cursor = System.Windows.Forms.Cursors.Default;
            this.departamentoscrt.DisplayStatusBar = false;
            this.departamentoscrt.DisplayToolbar = false;
            this.departamentoscrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departamentoscrt.Location = new System.Drawing.Point(0, 0);
            this.departamentoscrt.Name = "departamentoscrt";
            this.departamentoscrt.Size = new System.Drawing.Size(800, 450);
            this.departamentoscrt.TabIndex = 0;
            this.departamentoscrt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // departamentosR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.departamentoscrt);
            this.Name = "departamentosR";
            this.Text = "departamentosR";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer departamentoscrt;
    }
}