namespace Consultorio_GUI
{
    partial class FormPaciente
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabReadCitas = new System.Windows.Forms.TabPage();
            this.dgvVerCita = new System.Windows.Forms.DataGridView();
            this.tabCreateCita = new System.Windows.Forms.TabPage();
            this.lblNuevaCita_Hora = new System.Windows.Forms.Label();
            this.listNuevaCita_Hora = new System.Windows.Forms.ListBox();
            this.lblNuevaCita_Motivo = new System.Windows.Forms.Label();
            this.btnNuevaCita_Agendar = new System.Windows.Forms.Button();
            this.txtNuevaCita_Motivo = new System.Windows.Forms.TextBox();
            this.calendarNuevaCita = new System.Windows.Forms.MonthCalendar();
            this.tabReadPaciente = new System.Windows.Forms.TabPage();
            this.btnInfoPaciente_Confirmar = new System.Windows.Forms.Button();
            this.txtInfoPaciente_Password = new System.Windows.Forms.TextBox();
            this.lblInfo_NuevaPassword = new System.Windows.Forms.Label();
            this.btnInfoPaciente_Guardar = new System.Windows.Forms.Button();
            this.btnInfoPaciente_Vacuna = new System.Windows.Forms.Button();
            this.btnInfoPaciente_Historial = new System.Windows.Forms.Button();
            this.txtInfoPaciente_Fecha = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_Sexo = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_TipoSangre = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_Direccion = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_Telefono = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtInfoPaciente_Nombres = new System.Windows.Forms.TextBox();
            this.lblInfo_Nacimiento = new System.Windows.Forms.Label();
            this.lblInfo_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lblInfo_ApellidoPaterno = new System.Windows.Forms.Label();
            this.lblInfo_Nombres = new System.Windows.Forms.Label();
            this.lblInfo_Direccion = new System.Windows.Forms.Label();
            this.lblInfo_Telefono = new System.Windows.Forms.Label();
            this.lblInfo_Sexo = new System.Windows.Forms.Label();
            this.lblInfo_TipoSangre = new System.Windows.Forms.Label();
            this.tabReadRecetas = new System.Windows.Forms.TabPage();
            this.lblRecetas_Medicamentos = new System.Windows.Forms.Label();
            this.lblRecetas_Receta = new System.Windows.Forms.Label();
            this.dgvRecetas_Medicamentos = new System.Windows.Forms.DataGridView();
            this.cbRecetas_Receta = new System.Windows.Forms.ComboBox();
            this.tcMain.SuspendLayout();
            this.tabReadCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCita)).BeginInit();
            this.tabCreateCita.SuspendLayout();
            this.tabReadPaciente.SuspendLayout();
            this.tabReadRecetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas_Medicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabReadCitas);
            this.tcMain.Controls.Add(this.tabCreateCita);
            this.tcMain.Controls.Add(this.tabReadPaciente);
            this.tcMain.Controls.Add(this.tabReadRecetas);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(713, 324);
            this.tcMain.TabIndex = 2;
            // 
            // tabReadCitas
            // 
            this.tabReadCitas.Controls.Add(this.dgvVerCita);
            this.tabReadCitas.Location = new System.Drawing.Point(4, 22);
            this.tabReadCitas.Name = "tabReadCitas";
            this.tabReadCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabReadCitas.Size = new System.Drawing.Size(705, 298);
            this.tabReadCitas.TabIndex = 1;
            this.tabReadCitas.Text = "Mis Citas";
            this.tabReadCitas.UseVisualStyleBackColor = true;
            // 
            // dgvVerCita
            // 
            this.dgvVerCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerCita.Location = new System.Drawing.Point(3, 3);
            this.dgvVerCita.Name = "dgvVerCita";
            this.dgvVerCita.Size = new System.Drawing.Size(699, 292);
            this.dgvVerCita.TabIndex = 2;
            // 
            // tabCreateCita
            // 
            this.tabCreateCita.Controls.Add(this.lblNuevaCita_Hora);
            this.tabCreateCita.Controls.Add(this.listNuevaCita_Hora);
            this.tabCreateCita.Controls.Add(this.lblNuevaCita_Motivo);
            this.tabCreateCita.Controls.Add(this.btnNuevaCita_Agendar);
            this.tabCreateCita.Controls.Add(this.txtNuevaCita_Motivo);
            this.tabCreateCita.Controls.Add(this.calendarNuevaCita);
            this.tabCreateCita.Location = new System.Drawing.Point(4, 22);
            this.tabCreateCita.Name = "tabCreateCita";
            this.tabCreateCita.Size = new System.Drawing.Size(705, 298);
            this.tabCreateCita.TabIndex = 2;
            this.tabCreateCita.Text = "Nueva Cita";
            this.tabCreateCita.UseVisualStyleBackColor = true;
            // 
            // lblNuevaCita_Hora
            // 
            this.lblNuevaCita_Hora.AutoSize = true;
            this.lblNuevaCita_Hora.Location = new System.Drawing.Point(311, 67);
            this.lblNuevaCita_Hora.Name = "lblNuevaCita_Hora";
            this.lblNuevaCita_Hora.Size = new System.Drawing.Size(30, 13);
            this.lblNuevaCita_Hora.TabIndex = 9;
            this.lblNuevaCita_Hora.Text = "Hora";
            // 
            // listNuevaCita_Hora
            // 
            this.listNuevaCita_Hora.FormattingEnabled = true;
            this.listNuevaCita_Hora.Location = new System.Drawing.Point(314, 90);
            this.listNuevaCita_Hora.Name = "listNuevaCita_Hora";
            this.listNuevaCita_Hora.Size = new System.Drawing.Size(120, 95);
            this.listNuevaCita_Hora.TabIndex = 8;
            // 
            // lblNuevaCita_Motivo
            // 
            this.lblNuevaCita_Motivo.AutoSize = true;
            this.lblNuevaCita_Motivo.Location = new System.Drawing.Point(15, 67);
            this.lblNuevaCita_Motivo.Name = "lblNuevaCita_Motivo";
            this.lblNuevaCita_Motivo.Size = new System.Drawing.Size(39, 13);
            this.lblNuevaCita_Motivo.TabIndex = 7;
            this.lblNuevaCita_Motivo.Text = "Motivo";
            // 
            // btnNuevaCita_Agendar
            // 
            this.btnNuevaCita_Agendar.Location = new System.Drawing.Point(18, 203);
            this.btnNuevaCita_Agendar.Name = "btnNuevaCita_Agendar";
            this.btnNuevaCita_Agendar.Size = new System.Drawing.Size(416, 23);
            this.btnNuevaCita_Agendar.TabIndex = 4;
            this.btnNuevaCita_Agendar.Text = "Agendar cita";
            this.btnNuevaCita_Agendar.UseVisualStyleBackColor = true;
            this.btnNuevaCita_Agendar.Click += new System.EventHandler(this.btnNuevaCita_Agendar_Click);
            // 
            // txtNuevaCita_Motivo
            // 
            this.txtNuevaCita_Motivo.Location = new System.Drawing.Point(18, 90);
            this.txtNuevaCita_Motivo.Multiline = true;
            this.txtNuevaCita_Motivo.Name = "txtNuevaCita_Motivo";
            this.txtNuevaCita_Motivo.Size = new System.Drawing.Size(272, 95);
            this.txtNuevaCita_Motivo.TabIndex = 1;
            // 
            // calendarNuevaCita
            // 
            this.calendarNuevaCita.Location = new System.Drawing.Point(446, 64);
            this.calendarNuevaCita.Name = "calendarNuevaCita";
            this.calendarNuevaCita.TabIndex = 0;
            // 
            // tabReadPaciente
            // 
            this.tabReadPaciente.Controls.Add(this.btnInfoPaciente_Confirmar);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_Password);
            this.tabReadPaciente.Controls.Add(this.lblInfo_NuevaPassword);
            this.tabReadPaciente.Controls.Add(this.btnInfoPaciente_Guardar);
            this.tabReadPaciente.Controls.Add(this.btnInfoPaciente_Vacuna);
            this.tabReadPaciente.Controls.Add(this.btnInfoPaciente_Historial);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_Fecha);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_Sexo);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_TipoSangre);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_Direccion);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_Telefono);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_ApellidoMaterno);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_ApellidoPaterno);
            this.tabReadPaciente.Controls.Add(this.txtInfoPaciente_Nombres);
            this.tabReadPaciente.Controls.Add(this.lblInfo_Nacimiento);
            this.tabReadPaciente.Controls.Add(this.lblInfo_ApellidoMaterno);
            this.tabReadPaciente.Controls.Add(this.lblInfo_ApellidoPaterno);
            this.tabReadPaciente.Controls.Add(this.lblInfo_Nombres);
            this.tabReadPaciente.Controls.Add(this.lblInfo_Direccion);
            this.tabReadPaciente.Controls.Add(this.lblInfo_Telefono);
            this.tabReadPaciente.Controls.Add(this.lblInfo_Sexo);
            this.tabReadPaciente.Controls.Add(this.lblInfo_TipoSangre);
            this.tabReadPaciente.Location = new System.Drawing.Point(4, 22);
            this.tabReadPaciente.Name = "tabReadPaciente";
            this.tabReadPaciente.Size = new System.Drawing.Size(705, 298);
            this.tabReadPaciente.TabIndex = 4;
            this.tabReadPaciente.Text = "Mi Información";
            this.tabReadPaciente.UseVisualStyleBackColor = true;
            // 
            // btnInfoPaciente_Confirmar
            // 
            this.btnInfoPaciente_Confirmar.Location = new System.Drawing.Point(359, 239);
            this.btnInfoPaciente_Confirmar.Name = "btnInfoPaciente_Confirmar";
            this.btnInfoPaciente_Confirmar.Size = new System.Drawing.Size(303, 23);
            this.btnInfoPaciente_Confirmar.TabIndex = 55;
            this.btnInfoPaciente_Confirmar.Text = "Confirmar";
            this.btnInfoPaciente_Confirmar.UseVisualStyleBackColor = true;
            // 
            // txtInfoPaciente_Password
            // 
            this.txtInfoPaciente_Password.Location = new System.Drawing.Point(458, 210);
            this.txtInfoPaciente_Password.Name = "txtInfoPaciente_Password";
            this.txtInfoPaciente_Password.Size = new System.Drawing.Size(204, 20);
            this.txtInfoPaciente_Password.TabIndex = 54;
            this.txtInfoPaciente_Password.UseSystemPasswordChar = true;
            // 
            // lblInfo_NuevaPassword
            // 
            this.lblInfo_NuevaPassword.AutoSize = true;
            this.lblInfo_NuevaPassword.Location = new System.Drawing.Point(356, 213);
            this.lblInfo_NuevaPassword.Name = "lblInfo_NuevaPassword";
            this.lblInfo_NuevaPassword.Size = new System.Drawing.Size(96, 13);
            this.lblInfo_NuevaPassword.TabIndex = 53;
            this.lblInfo_NuevaPassword.Text = "Nueva Contraseña";
            // 
            // btnInfoPaciente_Guardar
            // 
            this.btnInfoPaciente_Guardar.Location = new System.Drawing.Point(16, 239);
            this.btnInfoPaciente_Guardar.Name = "btnInfoPaciente_Guardar";
            this.btnInfoPaciente_Guardar.Size = new System.Drawing.Size(303, 23);
            this.btnInfoPaciente_Guardar.TabIndex = 52;
            this.btnInfoPaciente_Guardar.Text = "Guardar cambios";
            this.btnInfoPaciente_Guardar.UseVisualStyleBackColor = true;
            this.btnInfoPaciente_Guardar.Click += new System.EventHandler(this.btnInfoPaciente_Guardar_Click);
            // 
            // btnInfoPaciente_Vacuna
            // 
            this.btnInfoPaciente_Vacuna.Location = new System.Drawing.Point(359, 56);
            this.btnInfoPaciente_Vacuna.Name = "btnInfoPaciente_Vacuna";
            this.btnInfoPaciente_Vacuna.Size = new System.Drawing.Size(303, 23);
            this.btnInfoPaciente_Vacuna.TabIndex = 50;
            this.btnInfoPaciente_Vacuna.Text = "Ver Vacunas";
            this.btnInfoPaciente_Vacuna.UseVisualStyleBackColor = true;
            this.btnInfoPaciente_Vacuna.Click += new System.EventHandler(this.btnInfoPaciente_Vacuna_Click);
            // 
            // btnInfoPaciente_Historial
            // 
            this.btnInfoPaciente_Historial.Location = new System.Drawing.Point(359, 30);
            this.btnInfoPaciente_Historial.Name = "btnInfoPaciente_Historial";
            this.btnInfoPaciente_Historial.Size = new System.Drawing.Size(303, 23);
            this.btnInfoPaciente_Historial.TabIndex = 49;
            this.btnInfoPaciente_Historial.Text = "Ver Historial";
            this.btnInfoPaciente_Historial.UseVisualStyleBackColor = true;
            this.btnInfoPaciente_Historial.Click += new System.EventHandler(this.btnInfoPaciente_Historial_Click);
            // 
            // txtInfoPaciente_Fecha
            // 
            this.txtInfoPaciente_Fecha.Enabled = false;
            this.txtInfoPaciente_Fecha.Location = new System.Drawing.Point(97, 117);
            this.txtInfoPaciente_Fecha.Name = "txtInfoPaciente_Fecha";
            this.txtInfoPaciente_Fecha.Size = new System.Drawing.Size(223, 20);
            this.txtInfoPaciente_Fecha.TabIndex = 48;
            // 
            // txtInfoPaciente_Sexo
            // 
            this.txtInfoPaciente_Sexo.Enabled = false;
            this.txtInfoPaciente_Sexo.Location = new System.Drawing.Point(205, 91);
            this.txtInfoPaciente_Sexo.Name = "txtInfoPaciente_Sexo";
            this.txtInfoPaciente_Sexo.Size = new System.Drawing.Size(114, 20);
            this.txtInfoPaciente_Sexo.TabIndex = 47;
            // 
            // txtInfoPaciente_TipoSangre
            // 
            this.txtInfoPaciente_TipoSangre.Enabled = false;
            this.txtInfoPaciente_TipoSangre.Location = new System.Drawing.Point(97, 91);
            this.txtInfoPaciente_TipoSangre.Name = "txtInfoPaciente_TipoSangre";
            this.txtInfoPaciente_TipoSangre.Size = new System.Drawing.Size(58, 20);
            this.txtInfoPaciente_TipoSangre.TabIndex = 46;
            // 
            // txtInfoPaciente_Direccion
            // 
            this.txtInfoPaciente_Direccion.Location = new System.Drawing.Point(96, 190);
            this.txtInfoPaciente_Direccion.Multiline = true;
            this.txtInfoPaciente_Direccion.Name = "txtInfoPaciente_Direccion";
            this.txtInfoPaciente_Direccion.Size = new System.Drawing.Size(223, 43);
            this.txtInfoPaciente_Direccion.TabIndex = 31;
            // 
            // txtInfoPaciente_Telefono
            // 
            this.txtInfoPaciente_Telefono.Location = new System.Drawing.Point(96, 164);
            this.txtInfoPaciente_Telefono.Name = "txtInfoPaciente_Telefono";
            this.txtInfoPaciente_Telefono.Size = new System.Drawing.Size(223, 20);
            this.txtInfoPaciente_Telefono.TabIndex = 30;
            // 
            // txtInfoPaciente_ApellidoMaterno
            // 
            this.txtInfoPaciente_ApellidoMaterno.Enabled = false;
            this.txtInfoPaciente_ApellidoMaterno.Location = new System.Drawing.Point(96, 65);
            this.txtInfoPaciente_ApellidoMaterno.Name = "txtInfoPaciente_ApellidoMaterno";
            this.txtInfoPaciente_ApellidoMaterno.Size = new System.Drawing.Size(223, 20);
            this.txtInfoPaciente_ApellidoMaterno.TabIndex = 21;
            // 
            // txtInfoPaciente_ApellidoPaterno
            // 
            this.txtInfoPaciente_ApellidoPaterno.Enabled = false;
            this.txtInfoPaciente_ApellidoPaterno.Location = new System.Drawing.Point(96, 39);
            this.txtInfoPaciente_ApellidoPaterno.Name = "txtInfoPaciente_ApellidoPaterno";
            this.txtInfoPaciente_ApellidoPaterno.Size = new System.Drawing.Size(223, 20);
            this.txtInfoPaciente_ApellidoPaterno.TabIndex = 20;
            // 
            // txtInfoPaciente_Nombres
            // 
            this.txtInfoPaciente_Nombres.Enabled = false;
            this.txtInfoPaciente_Nombres.Location = new System.Drawing.Point(96, 13);
            this.txtInfoPaciente_Nombres.Name = "txtInfoPaciente_Nombres";
            this.txtInfoPaciente_Nombres.Size = new System.Drawing.Size(223, 20);
            this.txtInfoPaciente_Nombres.TabIndex = 19;
            // 
            // lblInfo_Nacimiento
            // 
            this.lblInfo_Nacimiento.AutoSize = true;
            this.lblInfo_Nacimiento.Location = new System.Drawing.Point(30, 120);
            this.lblInfo_Nacimiento.Name = "lblInfo_Nacimiento";
            this.lblInfo_Nacimiento.Size = new System.Drawing.Size(60, 13);
            this.lblInfo_Nacimiento.TabIndex = 43;
            this.lblInfo_Nacimiento.Text = "Nacimiento";
            // 
            // lblInfo_ApellidoMaterno
            // 
            this.lblInfo_ApellidoMaterno.AutoSize = true;
            this.lblInfo_ApellidoMaterno.Location = new System.Drawing.Point(8, 68);
            this.lblInfo_ApellidoMaterno.Name = "lblInfo_ApellidoMaterno";
            this.lblInfo_ApellidoMaterno.Size = new System.Drawing.Size(83, 13);
            this.lblInfo_ApellidoMaterno.TabIndex = 42;
            this.lblInfo_ApellidoMaterno.Text = "ApellidoMaterno";
            // 
            // lblInfo_ApellidoPaterno
            // 
            this.lblInfo_ApellidoPaterno.AutoSize = true;
            this.lblInfo_ApellidoPaterno.Location = new System.Drawing.Point(7, 42);
            this.lblInfo_ApellidoPaterno.Name = "lblInfo_ApellidoPaterno";
            this.lblInfo_ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblInfo_ApellidoPaterno.TabIndex = 41;
            this.lblInfo_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblInfo_Nombres
            // 
            this.lblInfo_Nombres.AutoSize = true;
            this.lblInfo_Nombres.Location = new System.Drawing.Point(35, 16);
            this.lblInfo_Nombres.Name = "lblInfo_Nombres";
            this.lblInfo_Nombres.Size = new System.Drawing.Size(55, 13);
            this.lblInfo_Nombres.TabIndex = 40;
            this.lblInfo_Nombres.Text = "Nombre(s)";
            // 
            // lblInfo_Direccion
            // 
            this.lblInfo_Direccion.AutoSize = true;
            this.lblInfo_Direccion.Location = new System.Drawing.Point(38, 193);
            this.lblInfo_Direccion.Name = "lblInfo_Direccion";
            this.lblInfo_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lblInfo_Direccion.TabIndex = 33;
            this.lblInfo_Direccion.Text = "Dirección";
            // 
            // lblInfo_Telefono
            // 
            this.lblInfo_Telefono.AutoSize = true;
            this.lblInfo_Telefono.Location = new System.Drawing.Point(41, 167);
            this.lblInfo_Telefono.Name = "lblInfo_Telefono";
            this.lblInfo_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblInfo_Telefono.TabIndex = 32;
            this.lblInfo_Telefono.Text = "Teléfono";
            // 
            // lblInfo_Sexo
            // 
            this.lblInfo_Sexo.AutoSize = true;
            this.lblInfo_Sexo.Location = new System.Drawing.Point(168, 94);
            this.lblInfo_Sexo.Name = "lblInfo_Sexo";
            this.lblInfo_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lblInfo_Sexo.TabIndex = 24;
            this.lblInfo_Sexo.Text = "Sexo";
            // 
            // lblInfo_TipoSangre
            // 
            this.lblInfo_TipoSangre.AutoSize = true;
            this.lblInfo_TipoSangre.Location = new System.Drawing.Point(26, 94);
            this.lblInfo_TipoSangre.Name = "lblInfo_TipoSangre";
            this.lblInfo_TipoSangre.Size = new System.Drawing.Size(65, 13);
            this.lblInfo_TipoSangre.TabIndex = 23;
            this.lblInfo_TipoSangre.Text = "Tipo Sangre";
            // 
            // tabReadRecetas
            // 
            this.tabReadRecetas.Controls.Add(this.lblRecetas_Medicamentos);
            this.tabReadRecetas.Controls.Add(this.lblRecetas_Receta);
            this.tabReadRecetas.Controls.Add(this.dgvRecetas_Medicamentos);
            this.tabReadRecetas.Controls.Add(this.cbRecetas_Receta);
            this.tabReadRecetas.Location = new System.Drawing.Point(4, 22);
            this.tabReadRecetas.Name = "tabReadRecetas";
            this.tabReadRecetas.Size = new System.Drawing.Size(705, 298);
            this.tabReadRecetas.TabIndex = 5;
            this.tabReadRecetas.Text = "Mis Recetas";
            this.tabReadRecetas.UseVisualStyleBackColor = true;
            // 
            // lblRecetas_Medicamentos
            // 
            this.lblRecetas_Medicamentos.AutoSize = true;
            this.lblRecetas_Medicamentos.Location = new System.Drawing.Point(8, 51);
            this.lblRecetas_Medicamentos.Name = "lblRecetas_Medicamentos";
            this.lblRecetas_Medicamentos.Size = new System.Drawing.Size(79, 13);
            this.lblRecetas_Medicamentos.TabIndex = 3;
            this.lblRecetas_Medicamentos.Text = "Medicamentos:";
            // 
            // lblRecetas_Receta
            // 
            this.lblRecetas_Receta.AutoSize = true;
            this.lblRecetas_Receta.Location = new System.Drawing.Point(23, 24);
            this.lblRecetas_Receta.Name = "lblRecetas_Receta";
            this.lblRecetas_Receta.Size = new System.Drawing.Size(104, 13);
            this.lblRecetas_Receta.TabIndex = 2;
            this.lblRecetas_Receta.Text = "Seleccionar Receta:";
            // 
            // dgvRecetas_Medicamentos
            // 
            this.dgvRecetas_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecetas_Medicamentos.Location = new System.Drawing.Point(11, 67);
            this.dgvRecetas_Medicamentos.Name = "dgvRecetas_Medicamentos";
            this.dgvRecetas_Medicamentos.Size = new System.Drawing.Size(686, 224);
            this.dgvRecetas_Medicamentos.TabIndex = 1;
            // 
            // cbRecetas_Receta
            // 
            this.cbRecetas_Receta.FormattingEnabled = true;
            this.cbRecetas_Receta.Location = new System.Drawing.Point(133, 21);
            this.cbRecetas_Receta.Name = "cbRecetas_Receta";
            this.cbRecetas_Receta.Size = new System.Drawing.Size(251, 21);
            this.cbRecetas_Receta.TabIndex = 0;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 325);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPaciente";
            this.Text = "Bienvenido, Paciente";
            this.tcMain.ResumeLayout(false);
            this.tabReadCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCita)).EndInit();
            this.tabCreateCita.ResumeLayout(false);
            this.tabCreateCita.PerformLayout();
            this.tabReadPaciente.ResumeLayout(false);
            this.tabReadPaciente.PerformLayout();
            this.tabReadRecetas.ResumeLayout(false);
            this.tabReadRecetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecetas_Medicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabReadCitas;
        private System.Windows.Forms.DataGridView dgvVerCita;
        private System.Windows.Forms.TabPage tabCreateCita;
        private System.Windows.Forms.Label lblNuevaCita_Hora;
        private System.Windows.Forms.ListBox listNuevaCita_Hora;
        private System.Windows.Forms.Label lblNuevaCita_Motivo;
        private System.Windows.Forms.Button btnNuevaCita_Agendar;
        private System.Windows.Forms.TextBox txtNuevaCita_Motivo;
        private System.Windows.Forms.MonthCalendar calendarNuevaCita;
        private System.Windows.Forms.TabPage tabReadPaciente;
        private System.Windows.Forms.Button btnInfoPaciente_Vacuna;
        private System.Windows.Forms.Button btnInfoPaciente_Historial;
        private System.Windows.Forms.TextBox txtInfoPaciente_Fecha;
        private System.Windows.Forms.TextBox txtInfoPaciente_Sexo;
        private System.Windows.Forms.TextBox txtInfoPaciente_TipoSangre;
        private System.Windows.Forms.TextBox txtInfoPaciente_Direccion;
        private System.Windows.Forms.TextBox txtInfoPaciente_Telefono;
        private System.Windows.Forms.TextBox txtInfoPaciente_ApellidoMaterno;
        private System.Windows.Forms.TextBox txtInfoPaciente_ApellidoPaterno;
        private System.Windows.Forms.TextBox txtInfoPaciente_Nombres;
        private System.Windows.Forms.Label lblInfo_Nacimiento;
        private System.Windows.Forms.Label lblInfo_ApellidoMaterno;
        private System.Windows.Forms.Label lblInfo_ApellidoPaterno;
        private System.Windows.Forms.Label lblInfo_Nombres;
        private System.Windows.Forms.Label lblInfo_Direccion;
        private System.Windows.Forms.Label lblInfo_Telefono;
        private System.Windows.Forms.Label lblInfo_Sexo;
        private System.Windows.Forms.Label lblInfo_TipoSangre;
        private System.Windows.Forms.Button btnInfoPaciente_Guardar;
        private System.Windows.Forms.Button btnInfoPaciente_Confirmar;
        private System.Windows.Forms.TextBox txtInfoPaciente_Password;
        private System.Windows.Forms.Label lblInfo_NuevaPassword;
        private System.Windows.Forms.TabPage tabReadRecetas;
        private System.Windows.Forms.Label lblRecetas_Receta;
        private System.Windows.Forms.DataGridView dgvRecetas_Medicamentos;
        private System.Windows.Forms.ComboBox cbRecetas_Receta;
        private System.Windows.Forms.Label lblRecetas_Medicamentos;
    }
}