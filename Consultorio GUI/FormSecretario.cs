using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consultorio_GUI.WebService;

namespace Consultorio_GUI
{
    public partial class FormSecretario : Form
    {
        WebService1SoapClient client;

        public int CuentaActual { get; set; }


        List<Medico> medicos;
        List<Paciente> pacientes;
        List<Secretario> secretarios;
        List<Cita> citas;

        public FormSecretario(int actual)
        {
            InitializeComponent();

            client = new WebService1SoapClient();

            CuentaActual = actual;

            actualizarDatos();
        }

        void leerTablas() {
            medicos = client.readMedico().ToList();
            pacientes = client.readPaciente().ToList();
            secretarios = client.readSecreatrio().ToList();
        }

        void actualizarDatos()
        {
            //Actualizar
            leerTablas();

            dgvVerMedico.DataSource = (from x in medicos
                                      select new
                                      {
                                          ApellidoPaterno = x.apellidoPaterno,
                                          ApellidoMaterno = x.apellidoMaterno,
                                          Nombre = x.nombre,
                                          FechaNacimiento = x.fechaNacimiento,
                                          Sexo = x.sexo,
                                          Teléfono = x.telefono,
                                          Especialidad = x.especialidad
                                      }).ToList();

            // Data sources

            cbNuevaCita_Medico.DataSource = medicos;
            cbNuevoPaciente_Medico.DataSource = medicos;
            cbVerCita_Medico.DataSource = medicos;
            cbHorarios_Medico.DataSource = medicos;

            cbAdministrarPaciente_Paciente.DataSource = pacientes;
            cbNuevaCita_Paciente.DataSource = pacientes;

            cbAdministrarSecretario_Secretario.DataSource = secretarios;

            //Display members

            string displayMember = "ApellidoPaterno";

            cbNuevaCita_Medico.DisplayMember = displayMember;
            cbNuevoPaciente_Medico.DisplayMember = displayMember;
            cbVerCita_Medico.DisplayMember = displayMember;
            cbHorarios_Medico.DisplayMember = displayMember;

            cbAdministrarPaciente_Paciente.DisplayMember = displayMember;
            cbNuevaCita_Paciente.DisplayMember = displayMember;

            cbAdministrarSecretario_Secretario.DisplayMember = displayMember;


        }

        void actualizarCitas()
        {
            try
            {
                int idMedico = (cbVerCita_Medico.SelectedItem as Medico).ID;
                citas = client.readCita().Where(x => x.ID_Medico == idMedico).ToList();
                dgvVerCita.DataSource = (from c in citas
                                         join p in pacientes on c.ID_Paciente equals p.ID
                                         join m in medicos on c.ID_Medico equals m.ID
                                         join h in client.readHorario() on c.ID_Horario equals h.ID
                                         select new
                                         {
                                             Fecha = c.fecha,
                                             Hora = h.hora,
                                             Paciente = p.nombre + " " + p.apellidoPaterno + " " + p.apellidoMaterno,
                                             Médico = m.nombre + " " + m.apellidoPaterno + " " + m.apellidoMaterno,
                                             Descripción = c.descripcion
                                         }).ToList();

            }
            catch (Exception)
            {

            }
        }

        private void cbReadCita_Medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarCitas();
            
        }

        private void btnAdministrarPaciente_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente eliminado = cbAdministrarPaciente_Paciente.SelectedItem as Paciente;
                client.deletePaciente(eliminado.ID);

                actualizarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible eliminar.");
            }
           
        }

        private void btnNuevoPaciente_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNuevoPaciente_Username == null || txtNuevoPaciente_Password == null ||
                    cbNuevoPaciente_TipoSangre.SelectedItem == null || cbNuevoPaciente_Sexo.SelectedItem == null ||
                    cbNuevoPaciente_Medico.SelectedItem == null) return;

                int cuenta = client.createCuenta(
                    txtNuevoPaciente_Username.Text,
                    txtNuevoPaciente_Password.Text,
                    3);

                Medico medico = cbNuevoPaciente_Medico.SelectedItem as Medico;

                client.createPaciente(
                    cuenta,
                    txtNuevoPaciente_Nombres.Text,
                    txtNuevoPaciente_ApellidoMaterno.Text,
                    txtNuevoPaciente_ApellidoPaterno.Text,
                    cbNuevoPaciente_TipoSangre.Text,
                    calendarNuevoPaciente_Fecha.SelectionStart,
                    cbNuevoPaciente_Sexo.Text,
                    txtNuevoPaciente_Telefono.Text,
                    txtNuevoPaciente_Direccion.Text,
                    medico.ID
                    );
                actualizarDatos();
                MessageBox.Show("Agregado.");
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible Agregar.");
            }

            
        }

        private void cbAdministrarSecretario_Secretario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Secretario modificado = cbAdministrarSecretario_Secretario.SelectedItem as Secretario;

                txtAdministrarSecretario_ApellidoPaterno.Text = modificado.apellidoPaterno;
                txtAdministrarSecretario_ApellidoMaterno.Text = modificado.apellidoMaterno;
                txtAdministrarSecretario_Nombres.Text = modificado.nombre;
                txtAdministrarSecretario_Telefono.Text = modificado.telefono;
                cbAdministrarSecretario_Turno.SelectedText = modificado.turno;



            }
            catch (Exception)
            {

            }
        }

        private void btnAdministrarSecretario_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Secretario modificado = cbAdministrarSecretario_Secretario.SelectedItem as Secretario;

                client.updateSecretario(
                    modificado.ID,
                    modificado.ID_Cuenta,
                    txtAdministrarSecretario_Nombres.Text,
                    txtAdministrarSecretario_ApellidoMaterno.Text,
                    txtAdministrarSecretario_ApellidoPaterno.Text,
                    calendarAdministrarSecretario_Fecha.SelectionStart,
                    txtAdministrarSecretario_Telefono.Text,
                    cbAdministrarSecretario_Turno.Text

                    );

                actualizarDatos();
                MessageBox.Show("Modificado.");
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible Modificar.");
            }
        }

        private void btnNuevoSecretario_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoSecretario_Username == null || txtNuevoSecretario_Password == null ||
                    cbNuevoSecretario_Turno.SelectedItem == null) return;

                int cuenta = client.createCuenta(
                    txtNuevoSecretario_Username.Text,
                    txtNuevoSecretario_Password.Text,
                    2
                    );
                client.createSecretario(
                 cuenta,
                 txtNuevoSecretario_Nombres.Text,
                 txtNuevoSecretario_ApellidoMaterno.Text,
                 txtNuevoSecretario_ApellidoPaterno.Text,
                 calendarNuevoSecretario_Fecha.SelectionStart,
                 txtNuevoSecretario_Telefono.Text,
                 cbNuevoSecretario_Turno.Text
                 );

                actualizarDatos();
                MessageBox.Show("Agregado.");
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible Agregar.");
            }
        }


        void actualizarHorarios()
        {
            Medico medico = cbHorarios_Medico.SelectedItem as Medico;

            Dictionary<string, string> dia = new Dictionary<string, string>();
            dia.Add("L", "Lunes");
            dia.Add("M", "Martes");
            dia.Add("X", "Miércoles");
            dia.Add("J", "Jueves");
            dia.Add("V", "Viernes");
            dia.Add("S", "Sábado");
            dia.Add("D", "Domingo");

            dgvHorarios_Horario.DataSource = (from x in client.readHorario().Where(x => x.ID_Medico == medico.ID).ToList()
                                             select new
                                             {
                                                 Día = dia[x.dia],
                                                 Hora = x.hora + ":00"
                                             }).ToList();
        }

        private void cbHorarios_Medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarHorarios();
        }

        private void btnNuevoMedico_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                int cuenta = client.createCuenta(
                    txtNuevoMedico_Username.Text,
                    txtNuevoMedico_Password.Text,
                    1
                    );

                client.createMedico(
                    cuenta,
                    txtNuevoMedico_Nombres.Text,
                    txtNuevoMedico_ApellidoMaterno.Text,
                    txtNuevoMedico_ApellidoPaterno.Text,
                    calendarNuevoMedico_Fecha.SelectionStart,
                    cbNuevoMedico_Sexo.Text,
                    txtNuevoMedico_Telefono.Text,
                    txtNuevoMedico_Especialidad.Text
                    );

                actualizarDatos();
                MessageBox.Show("Agregado.");
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible Agregar.");
            }
        }

        private void btnHorario_Agregar_Click(object sender, EventArgs e)
        {

            try
            {
                Medico medico = cbHorarios_Medico.SelectedItem as Medico;
                string dia;

                switch (cbHorario_DiaSemana.SelectedIndex)
                {
                    default: dia = "L"; break;
                    case 1: dia = "M"; break;
                    case 2: dia = "X"; break;
                    case 3: dia = "J"; break;
                    case 4: dia = "V"; break;
                    case 5: dia = "S"; break;
                    case 6: dia = "D"; break;

                }

                client.createHorario(medico.ID, dia, (int)nudHorario_Horario.Value);
                actualizarHorariosCita();
                actualizarHorarios();
                
            }
            catch (Exception)
            {

            }
           
        }

        void actualizarHorariosCita()
        {
            try
            {
                Medico medico = cbNuevaCita_Medico.SelectedItem as Medico;
                string dia;

                switch (calendarNuevaCita.SelectionStart.DayOfWeek)
                {
                    case DayOfWeek.Monday: dia = "L"; break;
                    case DayOfWeek.Tuesday: dia = "M"; break;
                    case DayOfWeek.Wednesday: dia = "X"; break;
                    case DayOfWeek.Thursday: dia = "J"; break;
                    case DayOfWeek.Friday: dia = "V"; break;
                    case DayOfWeek.Saturday: dia = "S"; break;
                    default: dia = "D"; break;
                }

                cbNuevaCita_Paciente.DataSource = pacientes.Where(x => x.ID_Medico == medico.ID).ToList();

                listNuevaCita_Hora.DataSource = client.readHorario().Where(x => x.ID_Medico == medico.ID && x.dia == dia).ToList();
                listNuevaCita_Hora.DisplayMember = "hora";
            }
            catch (Exception)
            {
                cbNuevaCita_Paciente.DataSource = null;
            }
        }

        private void cbNuevaCita_Medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarHorariosCita();
            
        }

        private void btnNuevaCita_Agendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listNuevaCita_Hora.SelectedItem == null) return;


                Medico medico = cbNuevaCita_Medico.SelectedItem as Medico;
                Paciente paciente = cbNuevaCita_Paciente.SelectedItem as Paciente;
                Horario horario = listNuevaCita_Hora.SelectedItem as Horario;

                client.createCita(
                    calendarNuevaCita.SelectionStart,
                    txtNuevaCita_Motivo.Text,
                    true,
                    paciente.ID,
                    medico.ID,
                    horario.ID
                    );
                MessageBox.Show("Cita agendada.");
                
                actualizarCitas();
            }
            catch (Exception)
            {
                MessageBox.Show("No fue posible agendar la cita.");
            }
        }

        private void calendarNuevaCita_DateChanged(object sender, DateRangeEventArgs e)
        {
            actualizarHorariosCita();
        }
    }
}
