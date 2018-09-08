namespace Consultorio_GUI
{
    partial class FormSecretario
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
            this.tabVerMedico = new System.Windows.Forms.TabPage();
            this.dgvVerMedico = new System.Windows.Forms.DataGridView();
            this.tabReadCitas = new System.Windows.Forms.TabPage();
            this.dgvVerCita = new System.Windows.Forms.DataGridView();
            this.lblVerCita_Medico = new System.Windows.Forms.Label();
            this.cbVerCita_Medico = new System.Windows.Forms.ComboBox();
            this.tabCreateCitas = new System.Windows.Forms.TabPage();
            this.lblNuevaCita_Hora = new System.Windows.Forms.Label();
            this.listNuevaCita_Hora = new System.Windows.Forms.ListBox();
            this.lblNuevaCita_Motivo = new System.Windows.Forms.Label();
            this.lblNuevaCita_Paciente = new System.Windows.Forms.Label();
            this.lblNuevaCita_Medico = new System.Windows.Forms.Label();
            this.btnNuevaCita_Agendar = new System.Windows.Forms.Button();
            this.cbNuevaCita_Paciente = new System.Windows.Forms.ComboBox();
            this.cbNuevaCita_Medico = new System.Windows.Forms.ComboBox();
            this.txtNuevaCita_Motivo = new System.Windows.Forms.TextBox();
            this.calendarNuevaCita = new System.Windows.Forms.MonthCalendar();
            this.tabCreatePacientes = new System.Windows.Forms.TabPage();
            this.lblNuevoPaciente_Password = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_Username = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_Fecha = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_ApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_Nombres = new System.Windows.Forms.Label();
            this.btnNuevoPaciente_Agregar = new System.Windows.Forms.Button();
            this.calendarNuevoPaciente_Fecha = new System.Windows.Forms.MonthCalendar();
            this.txtNuevoPaciente_Username = new System.Windows.Forms.TextBox();
            this.txtNuevoPaciente_Password = new System.Windows.Forms.TextBox();
            this.cbNuevoPaciente_Medico = new System.Windows.Forms.ComboBox();
            this.lblNuevoPaciente_Medico = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_Direccion = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_Telefono = new System.Windows.Forms.Label();
            this.txtNuevoPaciente_Direccion = new System.Windows.Forms.TextBox();
            this.txtNuevoPaciente_Telefono = new System.Windows.Forms.TextBox();
            this.cbNuevoPaciente_Sexo = new System.Windows.Forms.ComboBox();
            this.lblNuevoPaciente_Sexo = new System.Windows.Forms.Label();
            this.lblNuevoPaciente_TipoSangre = new System.Windows.Forms.Label();
            this.cbNuevoPaciente_TipoSangre = new System.Windows.Forms.ComboBox();
            this.txtNuevoPaciente_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNuevoPaciente_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNuevoPaciente_Nombres = new System.Windows.Forms.TextBox();
            this.tabUpdatePacientes = new System.Windows.Forms.TabPage();
            this.lblAdministrarPacientes_Paciente = new System.Windows.Forms.Label();
            this.btnAdministrarPaciente_Eliminar = new System.Windows.Forms.Button();
            this.cbAdministrarPaciente_Paciente = new System.Windows.Forms.ComboBox();
            this.tabCreateSecretario = new System.Windows.Forms.TabPage();
            this.lblNuevoSecretario_Password = new System.Windows.Forms.Label();
            this.lblNuevoSecretario_Username = new System.Windows.Forms.Label();
            this.lblNuevoSecretario_Fecha = new System.Windows.Forms.Label();
            this.lblNuevoSecretario_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lblNuevoSecretario_ApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNuevoSecretario_Nombres = new System.Windows.Forms.Label();
            this.btnNuevoSecretario_Agregar = new System.Windows.Forms.Button();
            this.calendarNuevoSecretario_Fecha = new System.Windows.Forms.MonthCalendar();
            this.txtNuevoSecretario_Password = new System.Windows.Forms.TextBox();
            this.txtNuevoSecretario_Username = new System.Windows.Forms.TextBox();
            this.cbNuevoSecretario_Turno = new System.Windows.Forms.ComboBox();
            this.lblNuevoSecretario_Turno = new System.Windows.Forms.Label();
            this.lblNuevoSecretario_Telefono = new System.Windows.Forms.Label();
            this.txtNuevoSecretario_Telefono = new System.Windows.Forms.TextBox();
            this.txtNuevoSecretario_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNuevoSecretario_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNuevoSecretario_Nombres = new System.Windows.Forms.TextBox();
            this.tabUpdateSecretario = new System.Windows.Forms.TabPage();
            this.cbAdministrarSecretario_Secretario = new System.Windows.Forms.ComboBox();
            this.lblAdministrarSecretario_Secretario = new System.Windows.Forms.Label();
            this.lblAdministrarSecretario_Fecha = new System.Windows.Forms.Label();
            this.lblAdministrarSecretario_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lblAdministrarSecretario_ApellidoPaterno = new System.Windows.Forms.Label();
            this.lblAdministrarSecretario_Nombres = new System.Windows.Forms.Label();
            this.btnAdministrarSecretario_Modificar = new System.Windows.Forms.Button();
            this.calendarAdministrarSecretario_Fecha = new System.Windows.Forms.MonthCalendar();
            this.cbAdministrarSecretario_Turno = new System.Windows.Forms.ComboBox();
            this.lblAdministrarSecretario_Turno = new System.Windows.Forms.Label();
            this.lblAdministrarSecretario_Telefono = new System.Windows.Forms.Label();
            this.txtAdministrarSecretario_Telefono = new System.Windows.Forms.TextBox();
            this.txtAdministrarSecretario_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtAdministrarSecretario_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtAdministrarSecretario_Nombres = new System.Windows.Forms.TextBox();
            this.tabCreateMedico = new System.Windows.Forms.TabPage();
            this.cbNuevoMedico_Sexo = new System.Windows.Forms.ComboBox();
            this.lblNuevoMedico_Sexo = new System.Windows.Forms.Label();
            this.lblNuevoMedico_Especialidad = new System.Windows.Forms.Label();
            this.txtNuevoMedico_Especialidad = new System.Windows.Forms.TextBox();
            this.lblNuevoMedico_Password = new System.Windows.Forms.Label();
            this.lblNuevoMedico_Username = new System.Windows.Forms.Label();
            this.lblNuevoMedico_Fecha = new System.Windows.Forms.Label();
            this.lblNuevoMedico_ApellidoMaterno = new System.Windows.Forms.Label();
            this.lblNuevoMedico_ApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNuevoMedico_Nombres = new System.Windows.Forms.Label();
            this.btnNuevoMedico_Alta = new System.Windows.Forms.Button();
            this.calendarNuevoMedico_Fecha = new System.Windows.Forms.MonthCalendar();
            this.txtNuevoMedico_Password = new System.Windows.Forms.TextBox();
            this.txtNuevoMedico_Username = new System.Windows.Forms.TextBox();
            this.lblNuevoMedico_Telefono = new System.Windows.Forms.Label();
            this.txtNuevoMedico_Telefono = new System.Windows.Forms.TextBox();
            this.txtNuevoMedico_ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNuevoMedico_ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNuevoMedico_Nombres = new System.Windows.Forms.TextBox();
            this.tabCreateHorario = new System.Windows.Forms.TabPage();
            this.lblHorarios_Medico = new System.Windows.Forms.Label();
            this.cbHorarios_Medico = new System.Windows.Forms.ComboBox();
            this.lblNuevoMedico_hrs = new System.Windows.Forms.Label();
            this.btnHorario_Agregar = new System.Windows.Forms.Button();
            this.lblNuevoMedico_Horarios = new System.Windows.Forms.Label();
            this.nudHorario_Horario = new System.Windows.Forms.NumericUpDown();
            this.cbHorario_DiaSemana = new System.Windows.Forms.ComboBox();
            this.dgvHorarios_Horario = new System.Windows.Forms.DataGridView();
            this.tcMain.SuspendLayout();
            this.tabVerMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMedico)).BeginInit();
            this.tabReadCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCita)).BeginInit();
            this.tabCreateCitas.SuspendLayout();
            this.tabCreatePacientes.SuspendLayout();
            this.tabUpdatePacientes.SuspendLayout();
            this.tabCreateSecretario.SuspendLayout();
            this.tabUpdateSecretario.SuspendLayout();
            this.tabCreateMedico.SuspendLayout();
            this.tabCreateHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorario_Horario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios_Horario)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabVerMedico);
            this.tcMain.Controls.Add(this.tabReadCitas);
            this.tcMain.Controls.Add(this.tabCreateCitas);
            this.tcMain.Controls.Add(this.tabCreatePacientes);
            this.tcMain.Controls.Add(this.tabUpdatePacientes);
            this.tcMain.Controls.Add(this.tabCreateSecretario);
            this.tcMain.Controls.Add(this.tabUpdateSecretario);
            this.tcMain.Controls.Add(this.tabCreateMedico);
            this.tcMain.Controls.Add(this.tabCreateHorario);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(789, 341);
            this.tcMain.TabIndex = 0;
            // 
            // tabVerMedico
            // 
            this.tabVerMedico.Controls.Add(this.dgvVerMedico);
            this.tabVerMedico.Location = new System.Drawing.Point(4, 22);
            this.tabVerMedico.Name = "tabVerMedico";
            this.tabVerMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerMedico.Size = new System.Drawing.Size(781, 315);
            this.tabVerMedico.TabIndex = 0;
            this.tabVerMedico.Text = "Ver Médico";
            this.tabVerMedico.UseVisualStyleBackColor = true;
            // 
            // dgvVerMedico
            // 
            this.dgvVerMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerMedico.Location = new System.Drawing.Point(3, 3);
            this.dgvVerMedico.Name = "dgvVerMedico";
            this.dgvVerMedico.Size = new System.Drawing.Size(775, 309);
            this.dgvVerMedico.TabIndex = 3;
            // 
            // tabReadCitas
            // 
            this.tabReadCitas.Controls.Add(this.dgvVerCita);
            this.tabReadCitas.Controls.Add(this.lblVerCita_Medico);
            this.tabReadCitas.Controls.Add(this.cbVerCita_Medico);
            this.tabReadCitas.Location = new System.Drawing.Point(4, 22);
            this.tabReadCitas.Name = "tabReadCitas";
            this.tabReadCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabReadCitas.Size = new System.Drawing.Size(781, 315);
            this.tabReadCitas.TabIndex = 1;
            this.tabReadCitas.Text = "Ver Citas";
            this.tabReadCitas.UseVisualStyleBackColor = true;
            // 
            // dgvVerCita
            // 
            this.dgvVerCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerCita.Location = new System.Drawing.Point(8, 38);
            this.dgvVerCita.Name = "dgvVerCita";
            this.dgvVerCita.Size = new System.Drawing.Size(720, 271);
            this.dgvVerCita.TabIndex = 2;
            // 
            // lblVerCita_Medico
            // 
            this.lblVerCita_Medico.AutoSize = true;
            this.lblVerCita_Medico.Location = new System.Drawing.Point(6, 14);
            this.lblVerCita_Medico.Name = "lblVerCita_Medico";
            this.lblVerCita_Medico.Size = new System.Drawing.Size(45, 13);
            this.lblVerCita_Medico.TabIndex = 1;
            this.lblVerCita_Medico.Text = "Médico:";
            // 
            // cbVerCita_Medico
            // 
            this.cbVerCita_Medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVerCita_Medico.FormattingEnabled = true;
            this.cbVerCita_Medico.Location = new System.Drawing.Point(56, 11);
            this.cbVerCita_Medico.Name = "cbVerCita_Medico";
            this.cbVerCita_Medico.Size = new System.Drawing.Size(230, 21);
            this.cbVerCita_Medico.TabIndex = 0;
            this.cbVerCita_Medico.SelectedIndexChanged += new System.EventHandler(this.cbReadCita_Medico_SelectedIndexChanged);
            // 
            // tabCreateCitas
            // 
            this.tabCreateCitas.Controls.Add(this.lblNuevaCita_Hora);
            this.tabCreateCitas.Controls.Add(this.listNuevaCita_Hora);
            this.tabCreateCitas.Controls.Add(this.lblNuevaCita_Motivo);
            this.tabCreateCitas.Controls.Add(this.lblNuevaCita_Paciente);
            this.tabCreateCitas.Controls.Add(this.lblNuevaCita_Medico);
            this.tabCreateCitas.Controls.Add(this.btnNuevaCita_Agendar);
            this.tabCreateCitas.Controls.Add(this.cbNuevaCita_Paciente);
            this.tabCreateCitas.Controls.Add(this.cbNuevaCita_Medico);
            this.tabCreateCitas.Controls.Add(this.txtNuevaCita_Motivo);
            this.tabCreateCitas.Controls.Add(this.calendarNuevaCita);
            this.tabCreateCitas.Location = new System.Drawing.Point(4, 22);
            this.tabCreateCitas.Name = "tabCreateCitas";
            this.tabCreateCitas.Size = new System.Drawing.Size(781, 315);
            this.tabCreateCitas.TabIndex = 2;
            this.tabCreateCitas.Text = "Nueva Cita";
            this.tabCreateCitas.UseVisualStyleBackColor = true;
            // 
            // lblNuevaCita_Hora
            // 
            this.lblNuevaCita_Hora.AutoSize = true;
            this.lblNuevaCita_Hora.Location = new System.Drawing.Point(311, 74);
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
            this.lblNuevaCita_Motivo.Location = new System.Drawing.Point(18, 123);
            this.lblNuevaCita_Motivo.Name = "lblNuevaCita_Motivo";
            this.lblNuevaCita_Motivo.Size = new System.Drawing.Size(39, 13);
            this.lblNuevaCita_Motivo.TabIndex = 7;
            this.lblNuevaCita_Motivo.Text = "Motivo";
            // 
            // lblNuevaCita_Paciente
            // 
            this.lblNuevaCita_Paciente.AutoSize = true;
            this.lblNuevaCita_Paciente.Location = new System.Drawing.Point(8, 94);
            this.lblNuevaCita_Paciente.Name = "lblNuevaCita_Paciente";
            this.lblNuevaCita_Paciente.Size = new System.Drawing.Size(49, 13);
            this.lblNuevaCita_Paciente.TabIndex = 6;
            this.lblNuevaCita_Paciente.Text = "Paciente";
            // 
            // lblNuevaCita_Medico
            // 
            this.lblNuevaCita_Medico.AutoSize = true;
            this.lblNuevaCita_Medico.Location = new System.Drawing.Point(15, 67);
            this.lblNuevaCita_Medico.Name = "lblNuevaCita_Medico";
            this.lblNuevaCita_Medico.Size = new System.Drawing.Size(42, 13);
            this.lblNuevaCita_Medico.TabIndex = 5;
            this.lblNuevaCita_Medico.Text = "Médico";
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
            // cbNuevaCita_Paciente
            // 
            this.cbNuevaCita_Paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNuevaCita_Paciente.FormattingEnabled = true;
            this.cbNuevaCita_Paciente.Location = new System.Drawing.Point(63, 91);
            this.cbNuevaCita_Paciente.Name = "cbNuevaCita_Paciente";
            this.cbNuevaCita_Paciente.Size = new System.Drawing.Size(227, 21);
            this.cbNuevaCita_Paciente.TabIndex = 3;
            // 
            // cbNuevaCita_Medico
            // 
            this.cbNuevaCita_Medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNuevaCita_Medico.FormattingEnabled = true;
            this.cbNuevaCita_Medico.Location = new System.Drawing.Point(63, 64);
            this.cbNuevaCita_Medico.Name = "cbNuevaCita_Medico";
            this.cbNuevaCita_Medico.Size = new System.Drawing.Size(227, 21);
            this.cbNuevaCita_Medico.TabIndex = 2;
            this.cbNuevaCita_Medico.SelectedIndexChanged += new System.EventHandler(this.cbNuevaCita_Medico_SelectedIndexChanged);
            // 
            // txtNuevaCita_Motivo
            // 
            this.txtNuevaCita_Motivo.Location = new System.Drawing.Point(63, 120);
            this.txtNuevaCita_Motivo.Multiline = true;
            this.txtNuevaCita_Motivo.Name = "txtNuevaCita_Motivo";
            this.txtNuevaCita_Motivo.Size = new System.Drawing.Size(227, 63);
            this.txtNuevaCita_Motivo.TabIndex = 1;
            // 
            // calendarNuevaCita
            // 
            this.calendarNuevaCita.Location = new System.Drawing.Point(446, 64);
            this.calendarNuevaCita.Name = "calendarNuevaCita";
            this.calendarNuevaCita.TabIndex = 0;
            this.calendarNuevaCita.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarNuevaCita_DateChanged);
            // 
            // tabCreatePacientes
            // 
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Password);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Username);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Fecha);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_ApellidoMaterno);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_ApellidoPaterno);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Nombres);
            this.tabCreatePacientes.Controls.Add(this.btnNuevoPaciente_Agregar);
            this.tabCreatePacientes.Controls.Add(this.calendarNuevoPaciente_Fecha);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_Username);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_Password);
            this.tabCreatePacientes.Controls.Add(this.cbNuevoPaciente_Medico);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Medico);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Direccion);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Telefono);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_Direccion);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_Telefono);
            this.tabCreatePacientes.Controls.Add(this.cbNuevoPaciente_Sexo);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_Sexo);
            this.tabCreatePacientes.Controls.Add(this.lblNuevoPaciente_TipoSangre);
            this.tabCreatePacientes.Controls.Add(this.cbNuevoPaciente_TipoSangre);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_ApellidoMaterno);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_ApellidoPaterno);
            this.tabCreatePacientes.Controls.Add(this.txtNuevoPaciente_Nombres);
            this.tabCreatePacientes.Location = new System.Drawing.Point(4, 22);
            this.tabCreatePacientes.Name = "tabCreatePacientes";
            this.tabCreatePacientes.Size = new System.Drawing.Size(781, 315);
            this.tabCreatePacientes.TabIndex = 4;
            this.tabCreatePacientes.Text = "Nuevo Paciente";
            this.tabCreatePacientes.UseVisualStyleBackColor = true;
            // 
            // lblNuevoPaciente_Password
            // 
            this.lblNuevoPaciente_Password.AutoSize = true;
            this.lblNuevoPaciente_Password.Location = new System.Drawing.Point(396, 230);
            this.lblNuevoPaciente_Password.Name = "lblNuevoPaciente_Password";
            this.lblNuevoPaciente_Password.Size = new System.Drawing.Size(61, 13);
            this.lblNuevoPaciente_Password.TabIndex = 45;
            this.lblNuevoPaciente_Password.Text = "Contraseña";
            // 
            // lblNuevoPaciente_Username
            // 
            this.lblNuevoPaciente_Username.AutoSize = true;
            this.lblNuevoPaciente_Username.Location = new System.Drawing.Point(414, 204);
            this.lblNuevoPaciente_Username.Name = "lblNuevoPaciente_Username";
            this.lblNuevoPaciente_Username.Size = new System.Drawing.Size(43, 13);
            this.lblNuevoPaciente_Username.TabIndex = 44;
            this.lblNuevoPaciente_Username.Text = "Usuario";
            // 
            // lblNuevoPaciente_Fecha
            // 
            this.lblNuevoPaciente_Fecha.AutoSize = true;
            this.lblNuevoPaciente_Fecha.Location = new System.Drawing.Point(364, 30);
            this.lblNuevoPaciente_Fecha.Name = "lblNuevoPaciente_Fecha";
            this.lblNuevoPaciente_Fecha.Size = new System.Drawing.Size(93, 13);
            this.lblNuevoPaciente_Fecha.TabIndex = 43;
            this.lblNuevoPaciente_Fecha.Text = "Fecha Nacimiento";
            // 
            // lblNuevoPaciente_ApellidoMaterno
            // 
            this.lblNuevoPaciente_ApellidoMaterno.AutoSize = true;
            this.lblNuevoPaciente_ApellidoMaterno.Location = new System.Drawing.Point(21, 82);
            this.lblNuevoPaciente_ApellidoMaterno.Name = "lblNuevoPaciente_ApellidoMaterno";
            this.lblNuevoPaciente_ApellidoMaterno.Size = new System.Drawing.Size(83, 13);
            this.lblNuevoPaciente_ApellidoMaterno.TabIndex = 42;
            this.lblNuevoPaciente_ApellidoMaterno.Text = "ApellidoMaterno";
            // 
            // lblNuevoPaciente_ApellidoPaterno
            // 
            this.lblNuevoPaciente_ApellidoPaterno.AutoSize = true;
            this.lblNuevoPaciente_ApellidoPaterno.Location = new System.Drawing.Point(20, 56);
            this.lblNuevoPaciente_ApellidoPaterno.Name = "lblNuevoPaciente_ApellidoPaterno";
            this.lblNuevoPaciente_ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblNuevoPaciente_ApellidoPaterno.TabIndex = 41;
            this.lblNuevoPaciente_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblNuevoPaciente_Nombres
            // 
            this.lblNuevoPaciente_Nombres.AutoSize = true;
            this.lblNuevoPaciente_Nombres.Location = new System.Drawing.Point(48, 30);
            this.lblNuevoPaciente_Nombres.Name = "lblNuevoPaciente_Nombres";
            this.lblNuevoPaciente_Nombres.Size = new System.Drawing.Size(55, 13);
            this.lblNuevoPaciente_Nombres.TabIndex = 40;
            this.lblNuevoPaciente_Nombres.Text = "Nombre(s)";
            // 
            // btnNuevoPaciente_Agregar
            // 
            this.btnNuevoPaciente_Agregar.Location = new System.Drawing.Point(24, 267);
            this.btnNuevoPaciente_Agregar.Name = "btnNuevoPaciente_Agregar";
            this.btnNuevoPaciente_Agregar.Size = new System.Drawing.Size(686, 23);
            this.btnNuevoPaciente_Agregar.TabIndex = 39;
            this.btnNuevoPaciente_Agregar.Text = "Agregar";
            this.btnNuevoPaciente_Agregar.UseVisualStyleBackColor = true;
            this.btnNuevoPaciente_Agregar.Click += new System.EventHandler(this.btnNuevoPaciente_Agregar_Click);
            // 
            // calendarNuevoPaciente_Fecha
            // 
            this.calendarNuevoPaciente_Fecha.Location = new System.Drawing.Point(463, 27);
            this.calendarNuevoPaciente_Fecha.Name = "calendarNuevoPaciente_Fecha";
            this.calendarNuevoPaciente_Fecha.TabIndex = 38;
            // 
            // txtNuevoPaciente_Username
            // 
            this.txtNuevoPaciente_Username.Location = new System.Drawing.Point(462, 201);
            this.txtNuevoPaciente_Username.Name = "txtNuevoPaciente_Username";
            this.txtNuevoPaciente_Username.Size = new System.Drawing.Size(249, 20);
            this.txtNuevoPaciente_Username.TabIndex = 37;
            // 
            // txtNuevoPaciente_Password
            // 
            this.txtNuevoPaciente_Password.Location = new System.Drawing.Point(462, 227);
            this.txtNuevoPaciente_Password.Name = "txtNuevoPaciente_Password";
            this.txtNuevoPaciente_Password.Size = new System.Drawing.Size(248, 20);
            this.txtNuevoPaciente_Password.TabIndex = 36;
            this.txtNuevoPaciente_Password.UseSystemPasswordChar = true;
            // 
            // cbNuevoPaciente_Medico
            // 
            this.cbNuevoPaciente_Medico.FormattingEnabled = true;
            this.cbNuevoPaciente_Medico.Location = new System.Drawing.Point(109, 207);
            this.cbNuevoPaciente_Medico.Name = "cbNuevoPaciente_Medico";
            this.cbNuevoPaciente_Medico.Size = new System.Drawing.Size(223, 21);
            this.cbNuevoPaciente_Medico.TabIndex = 35;
            // 
            // lblNuevoPaciente_Medico
            // 
            this.lblNuevoPaciente_Medico.AutoSize = true;
            this.lblNuevoPaciente_Medico.Location = new System.Drawing.Point(61, 210);
            this.lblNuevoPaciente_Medico.Name = "lblNuevoPaciente_Medico";
            this.lblNuevoPaciente_Medico.Size = new System.Drawing.Size(42, 13);
            this.lblNuevoPaciente_Medico.TabIndex = 34;
            this.lblNuevoPaciente_Medico.Text = "Médico";
            // 
            // lblNuevoPaciente_Direccion
            // 
            this.lblNuevoPaciente_Direccion.AutoSize = true;
            this.lblNuevoPaciente_Direccion.Location = new System.Drawing.Point(51, 161);
            this.lblNuevoPaciente_Direccion.Name = "lblNuevoPaciente_Direccion";
            this.lblNuevoPaciente_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lblNuevoPaciente_Direccion.TabIndex = 33;
            this.lblNuevoPaciente_Direccion.Text = "Dirección";
            // 
            // lblNuevoPaciente_Telefono
            // 
            this.lblNuevoPaciente_Telefono.AutoSize = true;
            this.lblNuevoPaciente_Telefono.Location = new System.Drawing.Point(54, 135);
            this.lblNuevoPaciente_Telefono.Name = "lblNuevoPaciente_Telefono";
            this.lblNuevoPaciente_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblNuevoPaciente_Telefono.TabIndex = 32;
            this.lblNuevoPaciente_Telefono.Text = "Teléfono";
            // 
            // txtNuevoPaciente_Direccion
            // 
            this.txtNuevoPaciente_Direccion.Location = new System.Drawing.Point(109, 158);
            this.txtNuevoPaciente_Direccion.Multiline = true;
            this.txtNuevoPaciente_Direccion.Name = "txtNuevoPaciente_Direccion";
            this.txtNuevoPaciente_Direccion.Size = new System.Drawing.Size(223, 43);
            this.txtNuevoPaciente_Direccion.TabIndex = 31;
            // 
            // txtNuevoPaciente_Telefono
            // 
            this.txtNuevoPaciente_Telefono.Location = new System.Drawing.Point(109, 132);
            this.txtNuevoPaciente_Telefono.Name = "txtNuevoPaciente_Telefono";
            this.txtNuevoPaciente_Telefono.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoPaciente_Telefono.TabIndex = 30;
            // 
            // cbNuevoPaciente_Sexo
            // 
            this.cbNuevoPaciente_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNuevoPaciente_Sexo.FormattingEnabled = true;
            this.cbNuevoPaciente_Sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbNuevoPaciente_Sexo.Location = new System.Drawing.Point(216, 105);
            this.cbNuevoPaciente_Sexo.Name = "cbNuevoPaciente_Sexo";
            this.cbNuevoPaciente_Sexo.Size = new System.Drawing.Size(116, 21);
            this.cbNuevoPaciente_Sexo.TabIndex = 25;
            // 
            // lblNuevoPaciente_Sexo
            // 
            this.lblNuevoPaciente_Sexo.AutoSize = true;
            this.lblNuevoPaciente_Sexo.Location = new System.Drawing.Point(181, 108);
            this.lblNuevoPaciente_Sexo.Name = "lblNuevoPaciente_Sexo";
            this.lblNuevoPaciente_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lblNuevoPaciente_Sexo.TabIndex = 24;
            this.lblNuevoPaciente_Sexo.Text = "Sexo";
            // 
            // lblNuevoPaciente_TipoSangre
            // 
            this.lblNuevoPaciente_TipoSangre.AutoSize = true;
            this.lblNuevoPaciente_TipoSangre.Location = new System.Drawing.Point(38, 108);
            this.lblNuevoPaciente_TipoSangre.Name = "lblNuevoPaciente_TipoSangre";
            this.lblNuevoPaciente_TipoSangre.Size = new System.Drawing.Size(65, 13);
            this.lblNuevoPaciente_TipoSangre.TabIndex = 23;
            this.lblNuevoPaciente_TipoSangre.Text = "Tipo Sangre";
            // 
            // cbNuevoPaciente_TipoSangre
            // 
            this.cbNuevoPaciente_TipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNuevoPaciente_TipoSangre.FormattingEnabled = true;
            this.cbNuevoPaciente_TipoSangre.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.cbNuevoPaciente_TipoSangre.Location = new System.Drawing.Point(109, 105);
            this.cbNuevoPaciente_TipoSangre.Name = "cbNuevoPaciente_TipoSangre";
            this.cbNuevoPaciente_TipoSangre.Size = new System.Drawing.Size(53, 21);
            this.cbNuevoPaciente_TipoSangre.TabIndex = 22;
            // 
            // txtNuevoPaciente_ApellidoMaterno
            // 
            this.txtNuevoPaciente_ApellidoMaterno.Location = new System.Drawing.Point(109, 79);
            this.txtNuevoPaciente_ApellidoMaterno.Name = "txtNuevoPaciente_ApellidoMaterno";
            this.txtNuevoPaciente_ApellidoMaterno.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoPaciente_ApellidoMaterno.TabIndex = 21;
            // 
            // txtNuevoPaciente_ApellidoPaterno
            // 
            this.txtNuevoPaciente_ApellidoPaterno.Location = new System.Drawing.Point(109, 53);
            this.txtNuevoPaciente_ApellidoPaterno.Name = "txtNuevoPaciente_ApellidoPaterno";
            this.txtNuevoPaciente_ApellidoPaterno.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoPaciente_ApellidoPaterno.TabIndex = 20;
            // 
            // txtNuevoPaciente_Nombres
            // 
            this.txtNuevoPaciente_Nombres.Location = new System.Drawing.Point(109, 27);
            this.txtNuevoPaciente_Nombres.Name = "txtNuevoPaciente_Nombres";
            this.txtNuevoPaciente_Nombres.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoPaciente_Nombres.TabIndex = 19;
            // 
            // tabUpdatePacientes
            // 
            this.tabUpdatePacientes.Controls.Add(this.lblAdministrarPacientes_Paciente);
            this.tabUpdatePacientes.Controls.Add(this.btnAdministrarPaciente_Eliminar);
            this.tabUpdatePacientes.Controls.Add(this.cbAdministrarPaciente_Paciente);
            this.tabUpdatePacientes.Location = new System.Drawing.Point(4, 22);
            this.tabUpdatePacientes.Name = "tabUpdatePacientes";
            this.tabUpdatePacientes.Size = new System.Drawing.Size(781, 315);
            this.tabUpdatePacientes.TabIndex = 5;
            this.tabUpdatePacientes.Text = "Administrar Pacientes";
            this.tabUpdatePacientes.UseVisualStyleBackColor = true;
            // 
            // lblAdministrarPacientes_Paciente
            // 
            this.lblAdministrarPacientes_Paciente.AutoSize = true;
            this.lblAdministrarPacientes_Paciente.Location = new System.Drawing.Point(188, 35);
            this.lblAdministrarPacientes_Paciente.Name = "lblAdministrarPacientes_Paciente";
            this.lblAdministrarPacientes_Paciente.Size = new System.Drawing.Size(49, 13);
            this.lblAdministrarPacientes_Paciente.TabIndex = 6;
            this.lblAdministrarPacientes_Paciente.Text = "Paciente";
            // 
            // btnAdministrarPaciente_Eliminar
            // 
            this.btnAdministrarPaciente_Eliminar.Location = new System.Drawing.Point(191, 78);
            this.btnAdministrarPaciente_Eliminar.Name = "btnAdministrarPaciente_Eliminar";
            this.btnAdministrarPaciente_Eliminar.Size = new System.Drawing.Size(321, 23);
            this.btnAdministrarPaciente_Eliminar.TabIndex = 5;
            this.btnAdministrarPaciente_Eliminar.Text = "Eliminar";
            this.btnAdministrarPaciente_Eliminar.UseVisualStyleBackColor = true;
            this.btnAdministrarPaciente_Eliminar.Click += new System.EventHandler(this.btnAdministrarPaciente_Eliminar_Click);
            // 
            // cbAdministrarPaciente_Paciente
            // 
            this.cbAdministrarPaciente_Paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdministrarPaciente_Paciente.FormattingEnabled = true;
            this.cbAdministrarPaciente_Paciente.Location = new System.Drawing.Point(191, 51);
            this.cbAdministrarPaciente_Paciente.Name = "cbAdministrarPaciente_Paciente";
            this.cbAdministrarPaciente_Paciente.Size = new System.Drawing.Size(321, 21);
            this.cbAdministrarPaciente_Paciente.TabIndex = 0;
            // 
            // tabCreateSecretario
            // 
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_Password);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_Username);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_Fecha);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_ApellidoMaterno);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_ApellidoPaterno);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_Nombres);
            this.tabCreateSecretario.Controls.Add(this.btnNuevoSecretario_Agregar);
            this.tabCreateSecretario.Controls.Add(this.calendarNuevoSecretario_Fecha);
            this.tabCreateSecretario.Controls.Add(this.txtNuevoSecretario_Password);
            this.tabCreateSecretario.Controls.Add(this.txtNuevoSecretario_Username);
            this.tabCreateSecretario.Controls.Add(this.cbNuevoSecretario_Turno);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_Turno);
            this.tabCreateSecretario.Controls.Add(this.lblNuevoSecretario_Telefono);
            this.tabCreateSecretario.Controls.Add(this.txtNuevoSecretario_Telefono);
            this.tabCreateSecretario.Controls.Add(this.txtNuevoSecretario_ApellidoMaterno);
            this.tabCreateSecretario.Controls.Add(this.txtNuevoSecretario_ApellidoPaterno);
            this.tabCreateSecretario.Controls.Add(this.txtNuevoSecretario_Nombres);
            this.tabCreateSecretario.Location = new System.Drawing.Point(4, 22);
            this.tabCreateSecretario.Name = "tabCreateSecretario";
            this.tabCreateSecretario.Size = new System.Drawing.Size(781, 315);
            this.tabCreateSecretario.TabIndex = 6;
            this.tabCreateSecretario.Text = "Nuevo Secretario";
            this.tabCreateSecretario.UseVisualStyleBackColor = true;
            // 
            // lblNuevoSecretario_Password
            // 
            this.lblNuevoSecretario_Password.AutoSize = true;
            this.lblNuevoSecretario_Password.Location = new System.Drawing.Point(400, 226);
            this.lblNuevoSecretario_Password.Name = "lblNuevoSecretario_Password";
            this.lblNuevoSecretario_Password.Size = new System.Drawing.Size(61, 13);
            this.lblNuevoSecretario_Password.TabIndex = 68;
            this.lblNuevoSecretario_Password.Text = "Contraseña";
            // 
            // lblNuevoSecretario_Username
            // 
            this.lblNuevoSecretario_Username.AutoSize = true;
            this.lblNuevoSecretario_Username.Location = new System.Drawing.Point(418, 200);
            this.lblNuevoSecretario_Username.Name = "lblNuevoSecretario_Username";
            this.lblNuevoSecretario_Username.Size = new System.Drawing.Size(43, 13);
            this.lblNuevoSecretario_Username.TabIndex = 67;
            this.lblNuevoSecretario_Username.Text = "Usuario";
            // 
            // lblNuevoSecretario_Fecha
            // 
            this.lblNuevoSecretario_Fecha.AutoSize = true;
            this.lblNuevoSecretario_Fecha.Location = new System.Drawing.Point(368, 26);
            this.lblNuevoSecretario_Fecha.Name = "lblNuevoSecretario_Fecha";
            this.lblNuevoSecretario_Fecha.Size = new System.Drawing.Size(93, 13);
            this.lblNuevoSecretario_Fecha.TabIndex = 66;
            this.lblNuevoSecretario_Fecha.Text = "Fecha Nacimiento";
            // 
            // lblNuevoSecretario_ApellidoMaterno
            // 
            this.lblNuevoSecretario_ApellidoMaterno.AutoSize = true;
            this.lblNuevoSecretario_ApellidoMaterno.Location = new System.Drawing.Point(25, 78);
            this.lblNuevoSecretario_ApellidoMaterno.Name = "lblNuevoSecretario_ApellidoMaterno";
            this.lblNuevoSecretario_ApellidoMaterno.Size = new System.Drawing.Size(83, 13);
            this.lblNuevoSecretario_ApellidoMaterno.TabIndex = 65;
            this.lblNuevoSecretario_ApellidoMaterno.Text = "ApellidoMaterno";
            // 
            // lblNuevoSecretario_ApellidoPaterno
            // 
            this.lblNuevoSecretario_ApellidoPaterno.AutoSize = true;
            this.lblNuevoSecretario_ApellidoPaterno.Location = new System.Drawing.Point(24, 52);
            this.lblNuevoSecretario_ApellidoPaterno.Name = "lblNuevoSecretario_ApellidoPaterno";
            this.lblNuevoSecretario_ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblNuevoSecretario_ApellidoPaterno.TabIndex = 64;
            this.lblNuevoSecretario_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblNuevoSecretario_Nombres
            // 
            this.lblNuevoSecretario_Nombres.AutoSize = true;
            this.lblNuevoSecretario_Nombres.Location = new System.Drawing.Point(52, 26);
            this.lblNuevoSecretario_Nombres.Name = "lblNuevoSecretario_Nombres";
            this.lblNuevoSecretario_Nombres.Size = new System.Drawing.Size(55, 13);
            this.lblNuevoSecretario_Nombres.TabIndex = 63;
            this.lblNuevoSecretario_Nombres.Text = "Nombre(s)";
            // 
            // btnNuevoSecretario_Agregar
            // 
            this.btnNuevoSecretario_Agregar.Location = new System.Drawing.Point(28, 260);
            this.btnNuevoSecretario_Agregar.Name = "btnNuevoSecretario_Agregar";
            this.btnNuevoSecretario_Agregar.Size = new System.Drawing.Size(687, 23);
            this.btnNuevoSecretario_Agregar.TabIndex = 62;
            this.btnNuevoSecretario_Agregar.Text = "Agregar";
            this.btnNuevoSecretario_Agregar.UseVisualStyleBackColor = true;
            this.btnNuevoSecretario_Agregar.Click += new System.EventHandler(this.btnNuevoSecretario_Agregar_Click);
            // 
            // calendarNuevoSecretario_Fecha
            // 
            this.calendarNuevoSecretario_Fecha.Location = new System.Drawing.Point(467, 23);
            this.calendarNuevoSecretario_Fecha.Name = "calendarNuevoSecretario_Fecha";
            this.calendarNuevoSecretario_Fecha.TabIndex = 61;
            // 
            // txtNuevoSecretario_Password
            // 
            this.txtNuevoSecretario_Password.Location = new System.Drawing.Point(467, 223);
            this.txtNuevoSecretario_Password.Name = "txtNuevoSecretario_Password";
            this.txtNuevoSecretario_Password.Size = new System.Drawing.Size(249, 20);
            this.txtNuevoSecretario_Password.TabIndex = 60;
            this.txtNuevoSecretario_Password.UseSystemPasswordChar = true;
            // 
            // txtNuevoSecretario_Username
            // 
            this.txtNuevoSecretario_Username.Location = new System.Drawing.Point(467, 197);
            this.txtNuevoSecretario_Username.Name = "txtNuevoSecretario_Username";
            this.txtNuevoSecretario_Username.Size = new System.Drawing.Size(248, 20);
            this.txtNuevoSecretario_Username.TabIndex = 59;
            // 
            // cbNuevoSecretario_Turno
            // 
            this.cbNuevoSecretario_Turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNuevoSecretario_Turno.FormattingEnabled = true;
            this.cbNuevoSecretario_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno"});
            this.cbNuevoSecretario_Turno.Location = new System.Drawing.Point(113, 154);
            this.cbNuevoSecretario_Turno.Name = "cbNuevoSecretario_Turno";
            this.cbNuevoSecretario_Turno.Size = new System.Drawing.Size(223, 21);
            this.cbNuevoSecretario_Turno.TabIndex = 58;
            // 
            // lblNuevoSecretario_Turno
            // 
            this.lblNuevoSecretario_Turno.AutoSize = true;
            this.lblNuevoSecretario_Turno.Location = new System.Drawing.Point(72, 157);
            this.lblNuevoSecretario_Turno.Name = "lblNuevoSecretario_Turno";
            this.lblNuevoSecretario_Turno.Size = new System.Drawing.Size(35, 13);
            this.lblNuevoSecretario_Turno.TabIndex = 56;
            this.lblNuevoSecretario_Turno.Text = "Turno";
            // 
            // lblNuevoSecretario_Telefono
            // 
            this.lblNuevoSecretario_Telefono.AutoSize = true;
            this.lblNuevoSecretario_Telefono.Location = new System.Drawing.Point(58, 131);
            this.lblNuevoSecretario_Telefono.Name = "lblNuevoSecretario_Telefono";
            this.lblNuevoSecretario_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblNuevoSecretario_Telefono.TabIndex = 55;
            this.lblNuevoSecretario_Telefono.Text = "Teléfono";
            // 
            // txtNuevoSecretario_Telefono
            // 
            this.txtNuevoSecretario_Telefono.Location = new System.Drawing.Point(113, 128);
            this.txtNuevoSecretario_Telefono.Name = "txtNuevoSecretario_Telefono";
            this.txtNuevoSecretario_Telefono.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoSecretario_Telefono.TabIndex = 53;
            // 
            // txtNuevoSecretario_ApellidoMaterno
            // 
            this.txtNuevoSecretario_ApellidoMaterno.Location = new System.Drawing.Point(113, 75);
            this.txtNuevoSecretario_ApellidoMaterno.Name = "txtNuevoSecretario_ApellidoMaterno";
            this.txtNuevoSecretario_ApellidoMaterno.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoSecretario_ApellidoMaterno.TabIndex = 48;
            // 
            // txtNuevoSecretario_ApellidoPaterno
            // 
            this.txtNuevoSecretario_ApellidoPaterno.Location = new System.Drawing.Point(113, 49);
            this.txtNuevoSecretario_ApellidoPaterno.Name = "txtNuevoSecretario_ApellidoPaterno";
            this.txtNuevoSecretario_ApellidoPaterno.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoSecretario_ApellidoPaterno.TabIndex = 47;
            // 
            // txtNuevoSecretario_Nombres
            // 
            this.txtNuevoSecretario_Nombres.Location = new System.Drawing.Point(113, 23);
            this.txtNuevoSecretario_Nombres.Name = "txtNuevoSecretario_Nombres";
            this.txtNuevoSecretario_Nombres.Size = new System.Drawing.Size(223, 20);
            this.txtNuevoSecretario_Nombres.TabIndex = 46;
            // 
            // tabUpdateSecretario
            // 
            this.tabUpdateSecretario.Controls.Add(this.cbAdministrarSecretario_Secretario);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_Secretario);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_Fecha);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_ApellidoMaterno);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_ApellidoPaterno);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_Nombres);
            this.tabUpdateSecretario.Controls.Add(this.btnAdministrarSecretario_Modificar);
            this.tabUpdateSecretario.Controls.Add(this.calendarAdministrarSecretario_Fecha);
            this.tabUpdateSecretario.Controls.Add(this.cbAdministrarSecretario_Turno);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_Turno);
            this.tabUpdateSecretario.Controls.Add(this.lblAdministrarSecretario_Telefono);
            this.tabUpdateSecretario.Controls.Add(this.txtAdministrarSecretario_Telefono);
            this.tabUpdateSecretario.Controls.Add(this.txtAdministrarSecretario_ApellidoMaterno);
            this.tabUpdateSecretario.Controls.Add(this.txtAdministrarSecretario_ApellidoPaterno);
            this.tabUpdateSecretario.Controls.Add(this.txtAdministrarSecretario_Nombres);
            this.tabUpdateSecretario.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateSecretario.Name = "tabUpdateSecretario";
            this.tabUpdateSecretario.Size = new System.Drawing.Size(781, 315);
            this.tabUpdateSecretario.TabIndex = 7;
            this.tabUpdateSecretario.Text = "Administrar Secretario";
            this.tabUpdateSecretario.UseVisualStyleBackColor = true;
            // 
            // cbAdministrarSecretario_Secretario
            // 
            this.cbAdministrarSecretario_Secretario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdministrarSecretario_Secretario.FormattingEnabled = true;
            this.cbAdministrarSecretario_Secretario.Location = new System.Drawing.Point(25, 51);
            this.cbAdministrarSecretario_Secretario.Name = "cbAdministrarSecretario_Secretario";
            this.cbAdministrarSecretario_Secretario.Size = new System.Drawing.Size(308, 21);
            this.cbAdministrarSecretario_Secretario.TabIndex = 87;
            this.cbAdministrarSecretario_Secretario.SelectedIndexChanged += new System.EventHandler(this.cbAdministrarSecretario_Secretario_SelectedIndexChanged);
            // 
            // lblAdministrarSecretario_Secretario
            // 
            this.lblAdministrarSecretario_Secretario.AutoSize = true;
            this.lblAdministrarSecretario_Secretario.Location = new System.Drawing.Point(21, 35);
            this.lblAdministrarSecretario_Secretario.Name = "lblAdministrarSecretario_Secretario";
            this.lblAdministrarSecretario_Secretario.Size = new System.Drawing.Size(94, 13);
            this.lblAdministrarSecretario_Secretario.TabIndex = 86;
            this.lblAdministrarSecretario_Secretario.Text = "Secretario a Editar";
            // 
            // lblAdministrarSecretario_Fecha
            // 
            this.lblAdministrarSecretario_Fecha.AutoSize = true;
            this.lblAdministrarSecretario_Fecha.Location = new System.Drawing.Point(366, 35);
            this.lblAdministrarSecretario_Fecha.Name = "lblAdministrarSecretario_Fecha";
            this.lblAdministrarSecretario_Fecha.Size = new System.Drawing.Size(93, 13);
            this.lblAdministrarSecretario_Fecha.TabIndex = 83;
            this.lblAdministrarSecretario_Fecha.Text = "Fecha Nacimiento";
            // 
            // lblAdministrarSecretario_ApellidoMaterno
            // 
            this.lblAdministrarSecretario_ApellidoMaterno.AutoSize = true;
            this.lblAdministrarSecretario_ApellidoMaterno.Location = new System.Drawing.Point(22, 148);
            this.lblAdministrarSecretario_ApellidoMaterno.Name = "lblAdministrarSecretario_ApellidoMaterno";
            this.lblAdministrarSecretario_ApellidoMaterno.Size = new System.Drawing.Size(83, 13);
            this.lblAdministrarSecretario_ApellidoMaterno.TabIndex = 82;
            this.lblAdministrarSecretario_ApellidoMaterno.Text = "ApellidoMaterno";
            // 
            // lblAdministrarSecretario_ApellidoPaterno
            // 
            this.lblAdministrarSecretario_ApellidoPaterno.AutoSize = true;
            this.lblAdministrarSecretario_ApellidoPaterno.Location = new System.Drawing.Point(21, 122);
            this.lblAdministrarSecretario_ApellidoPaterno.Name = "lblAdministrarSecretario_ApellidoPaterno";
            this.lblAdministrarSecretario_ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblAdministrarSecretario_ApellidoPaterno.TabIndex = 81;
            this.lblAdministrarSecretario_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblAdministrarSecretario_Nombres
            // 
            this.lblAdministrarSecretario_Nombres.AutoSize = true;
            this.lblAdministrarSecretario_Nombres.Location = new System.Drawing.Point(49, 96);
            this.lblAdministrarSecretario_Nombres.Name = "lblAdministrarSecretario_Nombres";
            this.lblAdministrarSecretario_Nombres.Size = new System.Drawing.Size(55, 13);
            this.lblAdministrarSecretario_Nombres.TabIndex = 80;
            this.lblAdministrarSecretario_Nombres.Text = "Nombre(s)";
            // 
            // btnAdministrarSecretario_Modificar
            // 
            this.btnAdministrarSecretario_Modificar.Location = new System.Drawing.Point(25, 260);
            this.btnAdministrarSecretario_Modificar.Name = "btnAdministrarSecretario_Modificar";
            this.btnAdministrarSecretario_Modificar.Size = new System.Drawing.Size(308, 23);
            this.btnAdministrarSecretario_Modificar.TabIndex = 79;
            this.btnAdministrarSecretario_Modificar.Text = "Modificar";
            this.btnAdministrarSecretario_Modificar.UseVisualStyleBackColor = true;
            this.btnAdministrarSecretario_Modificar.Click += new System.EventHandler(this.btnAdministrarSecretario_Modificar_Click);
            // 
            // calendarAdministrarSecretario_Fecha
            // 
            this.calendarAdministrarSecretario_Fecha.Location = new System.Drawing.Point(465, 32);
            this.calendarAdministrarSecretario_Fecha.Name = "calendarAdministrarSecretario_Fecha";
            this.calendarAdministrarSecretario_Fecha.TabIndex = 78;
            // 
            // cbAdministrarSecretario_Turno
            // 
            this.cbAdministrarSecretario_Turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdministrarSecretario_Turno.FormattingEnabled = true;
            this.cbAdministrarSecretario_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno"});
            this.cbAdministrarSecretario_Turno.Location = new System.Drawing.Point(110, 224);
            this.cbAdministrarSecretario_Turno.Name = "cbAdministrarSecretario_Turno";
            this.cbAdministrarSecretario_Turno.Size = new System.Drawing.Size(223, 21);
            this.cbAdministrarSecretario_Turno.TabIndex = 75;
            // 
            // lblAdministrarSecretario_Turno
            // 
            this.lblAdministrarSecretario_Turno.AutoSize = true;
            this.lblAdministrarSecretario_Turno.Location = new System.Drawing.Point(69, 227);
            this.lblAdministrarSecretario_Turno.Name = "lblAdministrarSecretario_Turno";
            this.lblAdministrarSecretario_Turno.Size = new System.Drawing.Size(35, 13);
            this.lblAdministrarSecretario_Turno.TabIndex = 74;
            this.lblAdministrarSecretario_Turno.Text = "Turno";
            // 
            // lblAdministrarSecretario_Telefono
            // 
            this.lblAdministrarSecretario_Telefono.AutoSize = true;
            this.lblAdministrarSecretario_Telefono.Location = new System.Drawing.Point(55, 201);
            this.lblAdministrarSecretario_Telefono.Name = "lblAdministrarSecretario_Telefono";
            this.lblAdministrarSecretario_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblAdministrarSecretario_Telefono.TabIndex = 73;
            this.lblAdministrarSecretario_Telefono.Text = "Teléfono";
            // 
            // txtAdministrarSecretario_Telefono
            // 
            this.txtAdministrarSecretario_Telefono.Location = new System.Drawing.Point(110, 198);
            this.txtAdministrarSecretario_Telefono.Name = "txtAdministrarSecretario_Telefono";
            this.txtAdministrarSecretario_Telefono.Size = new System.Drawing.Size(223, 20);
            this.txtAdministrarSecretario_Telefono.TabIndex = 72;
            // 
            // txtAdministrarSecretario_ApellidoMaterno
            // 
            this.txtAdministrarSecretario_ApellidoMaterno.Location = new System.Drawing.Point(110, 145);
            this.txtAdministrarSecretario_ApellidoMaterno.Name = "txtAdministrarSecretario_ApellidoMaterno";
            this.txtAdministrarSecretario_ApellidoMaterno.Size = new System.Drawing.Size(223, 20);
            this.txtAdministrarSecretario_ApellidoMaterno.TabIndex = 71;
            // 
            // txtAdministrarSecretario_ApellidoPaterno
            // 
            this.txtAdministrarSecretario_ApellidoPaterno.Location = new System.Drawing.Point(110, 119);
            this.txtAdministrarSecretario_ApellidoPaterno.Name = "txtAdministrarSecretario_ApellidoPaterno";
            this.txtAdministrarSecretario_ApellidoPaterno.Size = new System.Drawing.Size(223, 20);
            this.txtAdministrarSecretario_ApellidoPaterno.TabIndex = 70;
            // 
            // txtAdministrarSecretario_Nombres
            // 
            this.txtAdministrarSecretario_Nombres.Location = new System.Drawing.Point(110, 93);
            this.txtAdministrarSecretario_Nombres.Name = "txtAdministrarSecretario_Nombres";
            this.txtAdministrarSecretario_Nombres.Size = new System.Drawing.Size(223, 20);
            this.txtAdministrarSecretario_Nombres.TabIndex = 69;
            // 
            // tabCreateMedico
            // 
            this.tabCreateMedico.Controls.Add(this.cbNuevoMedico_Sexo);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Sexo);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Especialidad);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_Especialidad);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Password);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Username);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Fecha);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_ApellidoMaterno);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_ApellidoPaterno);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Nombres);
            this.tabCreateMedico.Controls.Add(this.btnNuevoMedico_Alta);
            this.tabCreateMedico.Controls.Add(this.calendarNuevoMedico_Fecha);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_Password);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_Username);
            this.tabCreateMedico.Controls.Add(this.lblNuevoMedico_Telefono);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_Telefono);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_ApellidoMaterno);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_ApellidoPaterno);
            this.tabCreateMedico.Controls.Add(this.txtNuevoMedico_Nombres);
            this.tabCreateMedico.Location = new System.Drawing.Point(4, 22);
            this.tabCreateMedico.Name = "tabCreateMedico";
            this.tabCreateMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateMedico.Size = new System.Drawing.Size(781, 315);
            this.tabCreateMedico.TabIndex = 8;
            this.tabCreateMedico.Text = "Nuevo Médico";
            this.tabCreateMedico.UseVisualStyleBackColor = true;
            // 
            // cbNuevoMedico_Sexo
            // 
            this.cbNuevoMedico_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNuevoMedico_Sexo.FormattingEnabled = true;
            this.cbNuevoMedico_Sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbNuevoMedico_Sexo.Location = new System.Drawing.Point(112, 147);
            this.cbNuevoMedico_Sexo.Name = "cbNuevoMedico_Sexo";
            this.cbNuevoMedico_Sexo.Size = new System.Drawing.Size(247, 21);
            this.cbNuevoMedico_Sexo.TabIndex = 89;
            // 
            // lblNuevoMedico_Sexo
            // 
            this.lblNuevoMedico_Sexo.AutoSize = true;
            this.lblNuevoMedico_Sexo.Location = new System.Drawing.Point(74, 150);
            this.lblNuevoMedico_Sexo.Name = "lblNuevoMedico_Sexo";
            this.lblNuevoMedico_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lblNuevoMedico_Sexo.TabIndex = 88;
            this.lblNuevoMedico_Sexo.Text = "Sexo";
            // 
            // lblNuevoMedico_Especialidad
            // 
            this.lblNuevoMedico_Especialidad.AutoSize = true;
            this.lblNuevoMedico_Especialidad.Location = new System.Drawing.Point(39, 122);
            this.lblNuevoMedico_Especialidad.Name = "lblNuevoMedico_Especialidad";
            this.lblNuevoMedico_Especialidad.Size = new System.Drawing.Size(67, 13);
            this.lblNuevoMedico_Especialidad.TabIndex = 87;
            this.lblNuevoMedico_Especialidad.Text = "Especialidad";
            // 
            // txtNuevoMedico_Especialidad
            // 
            this.txtNuevoMedico_Especialidad.Location = new System.Drawing.Point(112, 119);
            this.txtNuevoMedico_Especialidad.Name = "txtNuevoMedico_Especialidad";
            this.txtNuevoMedico_Especialidad.Size = new System.Drawing.Size(247, 20);
            this.txtNuevoMedico_Especialidad.TabIndex = 86;
            // 
            // lblNuevoMedico_Password
            // 
            this.lblNuevoMedico_Password.AutoSize = true;
            this.lblNuevoMedico_Password.Location = new System.Drawing.Point(45, 203);
            this.lblNuevoMedico_Password.Name = "lblNuevoMedico_Password";
            this.lblNuevoMedico_Password.Size = new System.Drawing.Size(61, 13);
            this.lblNuevoMedico_Password.TabIndex = 85;
            this.lblNuevoMedico_Password.Text = "Contraseña";
            // 
            // lblNuevoMedico_Username
            // 
            this.lblNuevoMedico_Username.AutoSize = true;
            this.lblNuevoMedico_Username.Location = new System.Drawing.Point(63, 177);
            this.lblNuevoMedico_Username.Name = "lblNuevoMedico_Username";
            this.lblNuevoMedico_Username.Size = new System.Drawing.Size(43, 13);
            this.lblNuevoMedico_Username.TabIndex = 84;
            this.lblNuevoMedico_Username.Text = "Usuario";
            // 
            // lblNuevoMedico_Fecha
            // 
            this.lblNuevoMedico_Fecha.AutoSize = true;
            this.lblNuevoMedico_Fecha.Location = new System.Drawing.Point(425, 48);
            this.lblNuevoMedico_Fecha.Name = "lblNuevoMedico_Fecha";
            this.lblNuevoMedico_Fecha.Size = new System.Drawing.Size(93, 13);
            this.lblNuevoMedico_Fecha.TabIndex = 83;
            this.lblNuevoMedico_Fecha.Text = "Fecha Nacimiento";
            // 
            // lblNuevoMedico_ApellidoMaterno
            // 
            this.lblNuevoMedico_ApellidoMaterno.AutoSize = true;
            this.lblNuevoMedico_ApellidoMaterno.Location = new System.Drawing.Point(23, 70);
            this.lblNuevoMedico_ApellidoMaterno.Name = "lblNuevoMedico_ApellidoMaterno";
            this.lblNuevoMedico_ApellidoMaterno.Size = new System.Drawing.Size(83, 13);
            this.lblNuevoMedico_ApellidoMaterno.TabIndex = 82;
            this.lblNuevoMedico_ApellidoMaterno.Text = "ApellidoMaterno";
            // 
            // lblNuevoMedico_ApellidoPaterno
            // 
            this.lblNuevoMedico_ApellidoPaterno.AutoSize = true;
            this.lblNuevoMedico_ApellidoPaterno.Location = new System.Drawing.Point(22, 44);
            this.lblNuevoMedico_ApellidoPaterno.Name = "lblNuevoMedico_ApellidoPaterno";
            this.lblNuevoMedico_ApellidoPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblNuevoMedico_ApellidoPaterno.TabIndex = 81;
            this.lblNuevoMedico_ApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblNuevoMedico_Nombres
            // 
            this.lblNuevoMedico_Nombres.AutoSize = true;
            this.lblNuevoMedico_Nombres.Location = new System.Drawing.Point(50, 18);
            this.lblNuevoMedico_Nombres.Name = "lblNuevoMedico_Nombres";
            this.lblNuevoMedico_Nombres.Size = new System.Drawing.Size(55, 13);
            this.lblNuevoMedico_Nombres.TabIndex = 80;
            this.lblNuevoMedico_Nombres.Text = "Nombre(s)";
            // 
            // btnNuevoMedico_Alta
            // 
            this.btnNuevoMedico_Alta.Location = new System.Drawing.Point(6, 266);
            this.btnNuevoMedico_Alta.Name = "btnNuevoMedico_Alta";
            this.btnNuevoMedico_Alta.Size = new System.Drawing.Size(766, 23);
            this.btnNuevoMedico_Alta.TabIndex = 79;
            this.btnNuevoMedico_Alta.Text = "Dar de alta";
            this.btnNuevoMedico_Alta.UseVisualStyleBackColor = true;
            this.btnNuevoMedico_Alta.Click += new System.EventHandler(this.btnNuevoMedico_Alta_Click);
            // 
            // calendarNuevoMedico_Fecha
            // 
            this.calendarNuevoMedico_Fecha.Location = new System.Drawing.Point(521, 39);
            this.calendarNuevoMedico_Fecha.Name = "calendarNuevoMedico_Fecha";
            this.calendarNuevoMedico_Fecha.TabIndex = 78;
            // 
            // txtNuevoMedico_Password
            // 
            this.txtNuevoMedico_Password.Location = new System.Drawing.Point(112, 200);
            this.txtNuevoMedico_Password.Name = "txtNuevoMedico_Password";
            this.txtNuevoMedico_Password.Size = new System.Drawing.Size(249, 20);
            this.txtNuevoMedico_Password.TabIndex = 77;
            this.txtNuevoMedico_Password.UseSystemPasswordChar = true;
            // 
            // txtNuevoMedico_Username
            // 
            this.txtNuevoMedico_Username.Location = new System.Drawing.Point(112, 174);
            this.txtNuevoMedico_Username.Name = "txtNuevoMedico_Username";
            this.txtNuevoMedico_Username.Size = new System.Drawing.Size(248, 20);
            this.txtNuevoMedico_Username.TabIndex = 76;
            // 
            // lblNuevoMedico_Telefono
            // 
            this.lblNuevoMedico_Telefono.AutoSize = true;
            this.lblNuevoMedico_Telefono.Location = new System.Drawing.Point(57, 96);
            this.lblNuevoMedico_Telefono.Name = "lblNuevoMedico_Telefono";
            this.lblNuevoMedico_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lblNuevoMedico_Telefono.TabIndex = 73;
            this.lblNuevoMedico_Telefono.Text = "Teléfono";
            // 
            // txtNuevoMedico_Telefono
            // 
            this.txtNuevoMedico_Telefono.Location = new System.Drawing.Point(112, 93);
            this.txtNuevoMedico_Telefono.Name = "txtNuevoMedico_Telefono";
            this.txtNuevoMedico_Telefono.Size = new System.Drawing.Size(247, 20);
            this.txtNuevoMedico_Telefono.TabIndex = 72;
            // 
            // txtNuevoMedico_ApellidoMaterno
            // 
            this.txtNuevoMedico_ApellidoMaterno.Location = new System.Drawing.Point(111, 67);
            this.txtNuevoMedico_ApellidoMaterno.Name = "txtNuevoMedico_ApellidoMaterno";
            this.txtNuevoMedico_ApellidoMaterno.Size = new System.Drawing.Size(248, 20);
            this.txtNuevoMedico_ApellidoMaterno.TabIndex = 71;
            // 
            // txtNuevoMedico_ApellidoPaterno
            // 
            this.txtNuevoMedico_ApellidoPaterno.Location = new System.Drawing.Point(111, 41);
            this.txtNuevoMedico_ApellidoPaterno.Name = "txtNuevoMedico_ApellidoPaterno";
            this.txtNuevoMedico_ApellidoPaterno.Size = new System.Drawing.Size(248, 20);
            this.txtNuevoMedico_ApellidoPaterno.TabIndex = 70;
            // 
            // txtNuevoMedico_Nombres
            // 
            this.txtNuevoMedico_Nombres.Location = new System.Drawing.Point(111, 15);
            this.txtNuevoMedico_Nombres.Name = "txtNuevoMedico_Nombres";
            this.txtNuevoMedico_Nombres.Size = new System.Drawing.Size(248, 20);
            this.txtNuevoMedico_Nombres.TabIndex = 69;
            // 
            // tabCreateHorario
            // 
            this.tabCreateHorario.Controls.Add(this.dgvHorarios_Horario);
            this.tabCreateHorario.Controls.Add(this.lblHorarios_Medico);
            this.tabCreateHorario.Controls.Add(this.cbHorarios_Medico);
            this.tabCreateHorario.Controls.Add(this.lblNuevoMedico_hrs);
            this.tabCreateHorario.Controls.Add(this.btnHorario_Agregar);
            this.tabCreateHorario.Controls.Add(this.lblNuevoMedico_Horarios);
            this.tabCreateHorario.Controls.Add(this.nudHorario_Horario);
            this.tabCreateHorario.Controls.Add(this.cbHorario_DiaSemana);
            this.tabCreateHorario.Location = new System.Drawing.Point(4, 22);
            this.tabCreateHorario.Name = "tabCreateHorario";
            this.tabCreateHorario.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateHorario.Size = new System.Drawing.Size(781, 315);
            this.tabCreateHorario.TabIndex = 9;
            this.tabCreateHorario.Text = "Horarios Médico";
            this.tabCreateHorario.UseVisualStyleBackColor = true;
            // 
            // lblHorarios_Medico
            // 
            this.lblHorarios_Medico.AutoSize = true;
            this.lblHorarios_Medico.Location = new System.Drawing.Point(129, 64);
            this.lblHorarios_Medico.Name = "lblHorarios_Medico";
            this.lblHorarios_Medico.Size = new System.Drawing.Size(42, 13);
            this.lblHorarios_Medico.TabIndex = 101;
            this.lblHorarios_Medico.Text = "Médico";
            // 
            // cbHorarios_Medico
            // 
            this.cbHorarios_Medico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarios_Medico.FormattingEnabled = true;
            this.cbHorarios_Medico.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cbHorarios_Medico.Location = new System.Drawing.Point(128, 80);
            this.cbHorarios_Medico.Name = "cbHorarios_Medico";
            this.cbHorarios_Medico.Size = new System.Drawing.Size(241, 21);
            this.cbHorarios_Medico.TabIndex = 100;
            this.cbHorarios_Medico.SelectedIndexChanged += new System.EventHandler(this.cbHorarios_Medico_SelectedIndexChanged);
            // 
            // lblNuevoMedico_hrs
            // 
            this.lblNuevoMedico_hrs.AutoSize = true;
            this.lblNuevoMedico_hrs.Location = new System.Drawing.Point(241, 180);
            this.lblNuevoMedico_hrs.Name = "lblNuevoMedico_hrs";
            this.lblNuevoMedico_hrs.Size = new System.Drawing.Size(21, 13);
            this.lblNuevoMedico_hrs.TabIndex = 99;
            this.lblNuevoMedico_hrs.Text = "hrs";
            // 
            // btnHorario_Agregar
            // 
            this.btnHorario_Agregar.Location = new System.Drawing.Point(129, 204);
            this.btnHorario_Agregar.Name = "btnHorario_Agregar";
            this.btnHorario_Agregar.Size = new System.Drawing.Size(240, 23);
            this.btnHorario_Agregar.TabIndex = 98;
            this.btnHorario_Agregar.Text = "Agregar";
            this.btnHorario_Agregar.UseVisualStyleBackColor = true;
            this.btnHorario_Agregar.Click += new System.EventHandler(this.btnHorario_Agregar_Click);
            // 
            // lblNuevoMedico_Horarios
            // 
            this.lblNuevoMedico_Horarios.AutoSize = true;
            this.lblNuevoMedico_Horarios.Location = new System.Drawing.Point(125, 135);
            this.lblNuevoMedico_Horarios.Name = "lblNuevoMedico_Horarios";
            this.lblNuevoMedico_Horarios.Size = new System.Drawing.Size(46, 13);
            this.lblNuevoMedico_Horarios.TabIndex = 97;
            this.lblNuevoMedico_Horarios.Text = "Horarios";
            // 
            // nudHorario_Horario
            // 
            this.nudHorario_Horario.Location = new System.Drawing.Point(128, 178);
            this.nudHorario_Horario.Name = "nudHorario_Horario";
            this.nudHorario_Horario.Size = new System.Drawing.Size(107, 20);
            this.nudHorario_Horario.TabIndex = 95;
            // 
            // cbHorario_DiaSemana
            // 
            this.cbHorario_DiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario_DiaSemana.FormattingEnabled = true;
            this.cbHorario_DiaSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cbHorario_DiaSemana.Location = new System.Drawing.Point(128, 151);
            this.cbHorario_DiaSemana.Name = "cbHorario_DiaSemana";
            this.cbHorario_DiaSemana.Size = new System.Drawing.Size(241, 21);
            this.cbHorario_DiaSemana.TabIndex = 94;
            // 
            // dgvHorarios_Horario
            // 
            this.dgvHorarios_Horario.AllowUserToAddRows = false;
            this.dgvHorarios_Horario.AllowUserToDeleteRows = false;
            this.dgvHorarios_Horario.AllowUserToResizeRows = false;
            this.dgvHorarios_Horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios_Horario.Location = new System.Drawing.Point(417, 20);
            this.dgvHorarios_Horario.Name = "dgvHorarios_Horario";
            this.dgvHorarios_Horario.Size = new System.Drawing.Size(257, 274);
            this.dgvHorarios_Horario.TabIndex = 102;
            // 
            // FormSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 345);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSecretario";
            this.Text = "Bienvenido, Secretario";
            this.tcMain.ResumeLayout(false);
            this.tabVerMedico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerMedico)).EndInit();
            this.tabReadCitas.ResumeLayout(false);
            this.tabReadCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCita)).EndInit();
            this.tabCreateCitas.ResumeLayout(false);
            this.tabCreateCitas.PerformLayout();
            this.tabCreatePacientes.ResumeLayout(false);
            this.tabCreatePacientes.PerformLayout();
            this.tabUpdatePacientes.ResumeLayout(false);
            this.tabUpdatePacientes.PerformLayout();
            this.tabCreateSecretario.ResumeLayout(false);
            this.tabCreateSecretario.PerformLayout();
            this.tabUpdateSecretario.ResumeLayout(false);
            this.tabUpdateSecretario.PerformLayout();
            this.tabCreateMedico.ResumeLayout(false);
            this.tabCreateMedico.PerformLayout();
            this.tabCreateHorario.ResumeLayout(false);
            this.tabCreateHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorario_Horario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios_Horario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabVerMedico;
        private System.Windows.Forms.TabPage tabReadCitas;
        private System.Windows.Forms.TabPage tabCreateCitas;
        private System.Windows.Forms.DataGridView dgvVerMedico;
        private System.Windows.Forms.DataGridView dgvVerCita;
        private System.Windows.Forms.Label lblVerCita_Medico;
        private System.Windows.Forms.ComboBox cbVerCita_Medico;
        private System.Windows.Forms.TabPage tabCreatePacientes;
        private System.Windows.Forms.TabPage tabUpdatePacientes;
        private System.Windows.Forms.TabPage tabCreateSecretario;
        private System.Windows.Forms.TabPage tabUpdateSecretario;
        private System.Windows.Forms.ComboBox cbNuevaCita_Medico;
        private System.Windows.Forms.TextBox txtNuevaCita_Motivo;
        private System.Windows.Forms.MonthCalendar calendarNuevaCita;
        private System.Windows.Forms.Button btnNuevaCita_Agendar;
        private System.Windows.Forms.ComboBox cbNuevaCita_Paciente;
        private System.Windows.Forms.Label lblNuevaCita_Motivo;
        private System.Windows.Forms.Label lblNuevaCita_Paciente;
        private System.Windows.Forms.Label lblNuevaCita_Medico;
        private System.Windows.Forms.MonthCalendar calendarNuevoPaciente_Fecha;
        private System.Windows.Forms.TextBox txtNuevoPaciente_Username;
        private System.Windows.Forms.TextBox txtNuevoPaciente_Password;
        private System.Windows.Forms.ComboBox cbNuevoPaciente_Medico;
        private System.Windows.Forms.Label lblNuevoPaciente_Medico;
        private System.Windows.Forms.Label lblNuevoPaciente_Direccion;
        private System.Windows.Forms.Label lblNuevoPaciente_Telefono;
        private System.Windows.Forms.TextBox txtNuevoPaciente_Direccion;
        private System.Windows.Forms.TextBox txtNuevoPaciente_Telefono;
        private System.Windows.Forms.ComboBox cbNuevoPaciente_Sexo;
        private System.Windows.Forms.Label lblNuevoPaciente_Sexo;
        private System.Windows.Forms.Label lblNuevoPaciente_TipoSangre;
        private System.Windows.Forms.ComboBox cbNuevoPaciente_TipoSangre;
        private System.Windows.Forms.TextBox txtNuevoPaciente_ApellidoMaterno;
        private System.Windows.Forms.TextBox txtNuevoPaciente_ApellidoPaterno;
        private System.Windows.Forms.TextBox txtNuevoPaciente_Nombres;
        private System.Windows.Forms.Label lblNuevoPaciente_ApellidoMaterno;
        private System.Windows.Forms.Label lblNuevoPaciente_ApellidoPaterno;
        private System.Windows.Forms.Label lblNuevoPaciente_Nombres;
        private System.Windows.Forms.Button btnNuevoPaciente_Agregar;
        private System.Windows.Forms.Button btnAdministrarPaciente_Eliminar;
        private System.Windows.Forms.ComboBox cbAdministrarPaciente_Paciente;
        private System.Windows.Forms.Label lblNuevoPaciente_Password;
        private System.Windows.Forms.Label lblNuevoPaciente_Username;
        private System.Windows.Forms.Label lblNuevoPaciente_Fecha;
        private System.Windows.Forms.Label lblAdministrarPacientes_Paciente;
        private System.Windows.Forms.Label lblNuevoSecretario_Password;
        private System.Windows.Forms.Label lblNuevoSecretario_Username;
        private System.Windows.Forms.Label lblNuevoSecretario_Fecha;
        private System.Windows.Forms.Label lblNuevoSecretario_ApellidoMaterno;
        private System.Windows.Forms.Label lblNuevoSecretario_ApellidoPaterno;
        private System.Windows.Forms.Label lblNuevoSecretario_Nombres;
        private System.Windows.Forms.Button btnNuevoSecretario_Agregar;
        private System.Windows.Forms.MonthCalendar calendarNuevoSecretario_Fecha;
        private System.Windows.Forms.TextBox txtNuevoSecretario_Password;
        private System.Windows.Forms.TextBox txtNuevoSecretario_Username;
        private System.Windows.Forms.ComboBox cbNuevoSecretario_Turno;
        private System.Windows.Forms.Label lblNuevoSecretario_Turno;
        private System.Windows.Forms.Label lblNuevoSecretario_Telefono;
        private System.Windows.Forms.TextBox txtNuevoSecretario_Telefono;
        private System.Windows.Forms.TextBox txtNuevoSecretario_ApellidoMaterno;
        private System.Windows.Forms.TextBox txtNuevoSecretario_ApellidoPaterno;
        private System.Windows.Forms.TextBox txtNuevoSecretario_Nombres;
        private System.Windows.Forms.ComboBox cbAdministrarSecretario_Secretario;
        private System.Windows.Forms.Label lblAdministrarSecretario_Secretario;
        private System.Windows.Forms.Label lblAdministrarSecretario_Fecha;
        private System.Windows.Forms.Label lblAdministrarSecretario_ApellidoMaterno;
        private System.Windows.Forms.Label lblAdministrarSecretario_ApellidoPaterno;
        private System.Windows.Forms.Label lblAdministrarSecretario_Nombres;
        private System.Windows.Forms.Button btnAdministrarSecretario_Modificar;
        private System.Windows.Forms.MonthCalendar calendarAdministrarSecretario_Fecha;
        private System.Windows.Forms.ComboBox cbAdministrarSecretario_Turno;
        private System.Windows.Forms.Label lblAdministrarSecretario_Turno;
        private System.Windows.Forms.Label lblAdministrarSecretario_Telefono;
        private System.Windows.Forms.TextBox txtAdministrarSecretario_Telefono;
        private System.Windows.Forms.TextBox txtAdministrarSecretario_ApellidoMaterno;
        private System.Windows.Forms.TextBox txtAdministrarSecretario_ApellidoPaterno;
        private System.Windows.Forms.TextBox txtAdministrarSecretario_Nombres;
        private System.Windows.Forms.ListBox listNuevaCita_Hora;
        private System.Windows.Forms.Label lblNuevaCita_Hora;
        private System.Windows.Forms.TabPage tabCreateMedico;
        private System.Windows.Forms.Label lblNuevoMedico_Especialidad;
        private System.Windows.Forms.TextBox txtNuevoMedico_Especialidad;
        private System.Windows.Forms.Label lblNuevoMedico_Password;
        private System.Windows.Forms.Label lblNuevoMedico_Username;
        private System.Windows.Forms.Label lblNuevoMedico_Fecha;
        private System.Windows.Forms.Label lblNuevoMedico_ApellidoMaterno;
        private System.Windows.Forms.Label lblNuevoMedico_ApellidoPaterno;
        private System.Windows.Forms.Label lblNuevoMedico_Nombres;
        private System.Windows.Forms.Button btnNuevoMedico_Alta;
        private System.Windows.Forms.MonthCalendar calendarNuevoMedico_Fecha;
        private System.Windows.Forms.TextBox txtNuevoMedico_Password;
        private System.Windows.Forms.TextBox txtNuevoMedico_Username;
        private System.Windows.Forms.Label lblNuevoMedico_Telefono;
        private System.Windows.Forms.TextBox txtNuevoMedico_Telefono;
        private System.Windows.Forms.TextBox txtNuevoMedico_ApellidoMaterno;
        private System.Windows.Forms.TextBox txtNuevoMedico_ApellidoPaterno;
        private System.Windows.Forms.TextBox txtNuevoMedico_Nombres;
        private System.Windows.Forms.TabPage tabCreateHorario;
        private System.Windows.Forms.Label lblHorarios_Medico;
        private System.Windows.Forms.ComboBox cbHorarios_Medico;
        private System.Windows.Forms.Label lblNuevoMedico_hrs;
        private System.Windows.Forms.Button btnHorario_Agregar;
        private System.Windows.Forms.Label lblNuevoMedico_Horarios;
        private System.Windows.Forms.NumericUpDown nudHorario_Horario;
        private System.Windows.Forms.ComboBox cbHorario_DiaSemana;
        private System.Windows.Forms.ComboBox cbNuevoMedico_Sexo;
        private System.Windows.Forms.Label lblNuevoMedico_Sexo;
        private System.Windows.Forms.DataGridView dgvHorarios_Horario;
    }
}