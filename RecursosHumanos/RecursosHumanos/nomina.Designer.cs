namespace RecursosHumanos
{
    partial class nomina
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
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNomina
            // 
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Location = new System.Drawing.Point(304, 46);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.Size = new System.Drawing.Size(568, 360);
            this.dgvNomina.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(94, 250);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 42);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular Nomina";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dtpAnio
            // 
            this.dtpAnio.CustomFormat = "yyyy";
            this.dtpAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnio.Location = new System.Drawing.Point(94, 139);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.Size = new System.Drawing.Size(100, 20);
            this.dtpAnio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nomina";
            // 
            // dtpMes
            // 
            this.dtpMes.CustomFormat = "MM";
            this.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMes.Location = new System.Drawing.Point(94, 197);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(100, 20);
            this.dtpMes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mes";
            // 
            // nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAnio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nomina";
            this.Text = "nomina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNomina;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}