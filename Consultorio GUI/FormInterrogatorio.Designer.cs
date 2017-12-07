namespace Consultorio_GUI
{
    partial class FormInterrogatorio
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
            this.checkDeporte = new System.Windows.Forms.CheckBox();
            this.lblInterrogatorio = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.cbAlimentacion = new System.Windows.Forms.ComboBox();
            this.lblAlimentacion = new System.Windows.Forms.Label();
            this.checkDrogas = new System.Windows.Forms.CheckBox();
            this.checkToma = new System.Windows.Forms.CheckBox();
            this.checkDiabetes = new System.Windows.Forms.CheckBox();
            this.checkFuma = new System.Windows.Forms.CheckBox();
            this.checkCerVas = new System.Windows.Forms.CheckBox();
            this.checkCancer = new System.Windows.Forms.CheckBox();
            this.checkCorazon = new System.Windows.Forms.CheckBox();
            this.checkRinon = new System.Windows.Forms.CheckBox();
            this.CheckMental = new System.Windows.Forms.CheckBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkDeporte
            // 
            this.checkDeporte.AutoSize = true;
            this.checkDeporte.Location = new System.Drawing.Point(12, 100);
            this.checkDeporte.Name = "checkDeporte";
            this.checkDeporte.Size = new System.Drawing.Size(105, 17);
            this.checkDeporte.TabIndex = 0;
            this.checkDeporte.Text = "¿Hace Deporte?";
            this.checkDeporte.UseVisualStyleBackColor = true;
            // 
            // lblInterrogatorio
            // 
            this.lblInterrogatorio.AutoSize = true;
            this.lblInterrogatorio.Location = new System.Drawing.Point(12, 18);
            this.lblInterrogatorio.Name = "lblInterrogatorio";
            this.lblInterrogatorio.Size = new System.Drawing.Size(96, 13);
            this.lblInterrogatorio.TabIndex = 1;
            this.lblInterrogatorio.Text = "Interrogatorio para:";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(15, 34);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(321, 20);
            this.txtPaciente.TabIndex = 2;
            // 
            // cbAlimentacion
            // 
            this.cbAlimentacion.FormattingEnabled = true;
            this.cbAlimentacion.Items.AddRange(new object[] {
            "Muy Malo",
            "Malo",
            "Regular",
            "Bueno",
            "Muy Bueno"});
            this.cbAlimentacion.Location = new System.Drawing.Point(85, 66);
            this.cbAlimentacion.Name = "cbAlimentacion";
            this.cbAlimentacion.Size = new System.Drawing.Size(251, 21);
            this.cbAlimentacion.TabIndex = 3;
            // 
            // lblAlimentacion
            // 
            this.lblAlimentacion.AutoSize = true;
            this.lblAlimentacion.Location = new System.Drawing.Point(12, 69);
            this.lblAlimentacion.Name = "lblAlimentacion";
            this.lblAlimentacion.Size = new System.Drawing.Size(67, 13);
            this.lblAlimentacion.TabIndex = 4;
            this.lblAlimentacion.Text = "Alimentación";
            // 
            // checkDrogas
            // 
            this.checkDrogas.AutoSize = true;
            this.checkDrogas.Location = new System.Drawing.Point(12, 123);
            this.checkDrogas.Name = "checkDrogas";
            this.checkDrogas.Size = new System.Drawing.Size(117, 17);
            this.checkDrogas.TabIndex = 5;
            this.checkDrogas.Text = "¿Consume drogas?";
            this.checkDrogas.UseVisualStyleBackColor = true;
            // 
            // checkToma
            // 
            this.checkToma.AutoSize = true;
            this.checkToma.Location = new System.Drawing.Point(12, 146);
            this.checkToma.Name = "checkToma";
            this.checkToma.Size = new System.Drawing.Size(65, 17);
            this.checkToma.TabIndex = 6;
            this.checkToma.Text = "¿Toma?";
            this.checkToma.UseVisualStyleBackColor = true;
            // 
            // checkDiabetes
            // 
            this.checkDiabetes.AutoSize = true;
            this.checkDiabetes.Location = new System.Drawing.Point(12, 192);
            this.checkDiabetes.Name = "checkDiabetes";
            this.checkDiabetes.Size = new System.Drawing.Size(108, 17);
            this.checkDiabetes.TabIndex = 8;
            this.checkDiabetes.Text = "¿Tiene diabetes?";
            this.checkDiabetes.UseVisualStyleBackColor = true;
            // 
            // checkFuma
            // 
            this.checkFuma.AutoSize = true;
            this.checkFuma.Location = new System.Drawing.Point(12, 169);
            this.checkFuma.Name = "checkFuma";
            this.checkFuma.Size = new System.Drawing.Size(64, 17);
            this.checkFuma.TabIndex = 7;
            this.checkFuma.Text = "¿Fuma?";
            this.checkFuma.UseVisualStyleBackColor = true;
            // 
            // checkCerVas
            // 
            this.checkCerVas.AutoSize = true;
            this.checkCerVas.Location = new System.Drawing.Point(147, 192);
            this.checkCerVas.Name = "checkCerVas";
            this.checkCerVas.Size = new System.Drawing.Size(197, 17);
            this.checkCerVas.TabIndex = 13;
            this.checkCerVas.Text = "¿Enfermedades Cerebrovasculares?";
            this.checkCerVas.UseVisualStyleBackColor = true;
            // 
            // checkCancer
            // 
            this.checkCancer.AutoSize = true;
            this.checkCancer.Location = new System.Drawing.Point(147, 169);
            this.checkCancer.Name = "checkCancer";
            this.checkCancer.Size = new System.Drawing.Size(72, 17);
            this.checkCancer.TabIndex = 12;
            this.checkCancer.Text = "¿Cáncer?";
            this.checkCancer.UseVisualStyleBackColor = true;
            // 
            // checkCorazon
            // 
            this.checkCorazon.AutoSize = true;
            this.checkCorazon.Location = new System.Drawing.Point(147, 146);
            this.checkCorazon.Name = "checkCorazon";
            this.checkCorazon.Size = new System.Drawing.Size(164, 17);
            this.checkCorazon.TabIndex = 11;
            this.checkCorazon.Text = "¿Enfermedades del corazón?";
            this.checkCorazon.UseVisualStyleBackColor = true;
            // 
            // checkRinon
            // 
            this.checkRinon.AutoSize = true;
            this.checkRinon.Location = new System.Drawing.Point(147, 123);
            this.checkRinon.Name = "checkRinon";
            this.checkRinon.Size = new System.Drawing.Size(147, 17);
            this.checkRinon.TabIndex = 10;
            this.checkRinon.Text = "¿Enfermedades de riñón?";
            this.checkRinon.UseVisualStyleBackColor = true;
            // 
            // CheckMental
            // 
            this.CheckMental.AutoSize = true;
            this.CheckMental.Location = new System.Drawing.Point(147, 100);
            this.CheckMental.Name = "CheckMental";
            this.CheckMental.Size = new System.Drawing.Size(151, 17);
            this.CheckMental.TabIndex = 9;
            this.CheckMental.Text = "¿Enfermedades mentales?";
            this.CheckMental.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(15, 224);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(321, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormInterrogatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 260);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.checkCerVas);
            this.Controls.Add(this.checkCancer);
            this.Controls.Add(this.checkCorazon);
            this.Controls.Add(this.checkRinon);
            this.Controls.Add(this.CheckMental);
            this.Controls.Add(this.checkDiabetes);
            this.Controls.Add(this.checkFuma);
            this.Controls.Add(this.checkToma);
            this.Controls.Add(this.checkDrogas);
            this.Controls.Add(this.lblAlimentacion);
            this.Controls.Add(this.cbAlimentacion);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblInterrogatorio);
            this.Controls.Add(this.checkDeporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInterrogatorio";
            this.Text = "Interrogatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDeporte;
        private System.Windows.Forms.Label lblInterrogatorio;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.ComboBox cbAlimentacion;
        private System.Windows.Forms.Label lblAlimentacion;
        private System.Windows.Forms.CheckBox checkDrogas;
        private System.Windows.Forms.CheckBox checkToma;
        private System.Windows.Forms.CheckBox checkDiabetes;
        private System.Windows.Forms.CheckBox checkFuma;
        private System.Windows.Forms.CheckBox checkCerVas;
        private System.Windows.Forms.CheckBox checkCancer;
        private System.Windows.Forms.CheckBox checkCorazon;
        private System.Windows.Forms.CheckBox checkRinon;
        private System.Windows.Forms.CheckBox CheckMental;
        private System.Windows.Forms.Button btnActualizar;
    }
}