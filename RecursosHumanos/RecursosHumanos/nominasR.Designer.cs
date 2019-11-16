namespace RecursosHumanos
{
    partial class nominasR
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
            this.nominacr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // nominacr
            // 
            this.nominacr.ActiveViewIndex = -1;
            this.nominacr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nominacr.Cursor = System.Windows.Forms.Cursors.Default;
            this.nominacr.DisplayStatusBar = false;
            this.nominacr.DisplayToolbar = false;
            this.nominacr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nominacr.Location = new System.Drawing.Point(0, 0);
            this.nominacr.Name = "nominacr";
            this.nominacr.Size = new System.Drawing.Size(800, 450);
            this.nominacr.TabIndex = 0;
            this.nominacr.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // nominasR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nominacr);
            this.Name = "nominasR";
            this.Text = "nominasR";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer nominacr;
    }
}