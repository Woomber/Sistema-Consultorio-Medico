namespace Consultorio_GUI
{
    partial class FormVacunas
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
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblVacunas = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.cbAgregar = new System.Windows.Forms.ComboBox();
            this.dgvVacuna = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(15, 25);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(321, 20);
            this.txtPaciente.TabIndex = 4;
            // 
            // lblVacunas
            // 
            this.lblVacunas.AutoSize = true;
            this.lblVacunas.Location = new System.Drawing.Point(12, 9);
            this.lblVacunas.Name = "lblVacunas";
            this.lblVacunas.Size = new System.Drawing.Size(76, 13);
            this.lblVacunas.TabIndex = 3;
            this.lblVacunas.Text = "Vacunas para:";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(12, 58);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(44, 13);
            this.lblAgregar.TabIndex = 5;
            this.lblAgregar.Text = "Agregar";
            // 
            // cbAgregar
            // 
            this.cbAgregar.FormattingEnabled = true;
            this.cbAgregar.Location = new System.Drawing.Point(62, 55);
            this.cbAgregar.Name = "cbAgregar";
            this.cbAgregar.Size = new System.Drawing.Size(193, 21);
            this.cbAgregar.TabIndex = 6;
            // 
            // dgvVacuna
            // 
            this.dgvVacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacuna.Location = new System.Drawing.Point(15, 82);
            this.dgvVacuna.Name = "dgvVacuna";
            this.dgvVacuna.Size = new System.Drawing.Size(324, 311);
            this.dgvVacuna.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(261, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FormVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 405);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVacuna);
            this.Controls.Add(this.cbAgregar);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblVacunas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVacunas";
            this.Text = "Vacunas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblVacunas;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.ComboBox cbAgregar;
        private System.Windows.Forms.DataGridView dgvVacuna;
        private System.Windows.Forms.Button btnAgregar;
    }
}