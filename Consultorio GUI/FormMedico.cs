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
    public partial class FormMedico : Form
    {
        WebService1SoapClient client;
        public int CuentaActual { get; set; }
        public int RecetaActual { get; set; }
        private Medico medico;
        private List<Horario> horarios;

        public FormMedico(int actual)
        {
            InitializeComponent();
            client = new WebService1SoapClient();
            CuentaActual = actual;
            actualizarDatos();
        }

        void actualizarDatos()
        {

        }

        private void btnInfoPaciente_Interrogatorio_Click(object sender, EventArgs e)
        {
            //Poner el paciente seleccionado en el 0
            FormInterrogatorio form = new FormInterrogatorio(Convert.ToInt32(cbInfoPaciente_Medico.SelectedValue));
            form.ShowDialog();
        }

        private void btnInfoPaciente_Vacuna_Click(object sender, EventArgs e)
        {
            FormVacunas form = new FormVacunas(Convert.ToInt32(cbInfoPaciente_Medico.SelectedValue), true);
            form.ShowDialog();
        }

        private void btnNuevaReceta_AgregarMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                client.createMedicamentoReceta(txtNuevaReceta_Medicamento.Text, txtNuevaReceta_Dosis.Text, txtNuevaReceta_Horario.Text, RecetaActual);
                List<MedicamentoReceta> medicamentos=client.readMedicamentoReceta().Where(x => x.ID_Receta == RecetaActual).ToList();
                var filtroMedicamento = from x in medicamentos select new { Nombre = x.medicamento, Dosis = x.dosis, Horario = x.horario };
                dgvNuevaReceta_Medicamentos.DataSource = filtroMedicamento.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear medicamento");
            }
        }

        private void btnNuevaReceta_Crear_Click(object sender, EventArgs e)
        {
            try
            {
                RecetaActual=client.createReceta(medico.ID, Convert.ToInt32(cbNuevaReceta_Paciente.SelectedValue), false, txtNuevaReceta_Recomendaciones.Text);
                dgvNuevaReceta_Medicamentos.DataSource = null;
                btnNuevaReceta_AgregarMedicamento.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear una nueva receta");
            }

        }

        private void btnInfoPaciente_Historial_Click(object sender, EventArgs e)
        {
            FormHistorial form = new FormHistorial(Convert.ToInt32(cbInfoPaciente_Medico.SelectedValue));
            form.ShowDialog();

        }

        private void btnExp_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                client.createExpFisica(txtExp_Estudios.Text,txtEvolucion.Text,Convert.ToDouble(nudExp_Temperatura.Value),
                                        Convert.ToInt32(nudExp_FrecCardiaca.Value), Convert.ToInt32(nudExp_FrecRespiratoria.Value),
                                        Convert.ToDouble(nudExp_Estatura.Value), Convert.ToDouble(nudExp_Peso.Value),
                                        Convert.ToDouble(nudExp_PerToraxIns.Value), Convert.ToDouble(nudExp_PerToraxExp.Value),
                                        Convert.ToDouble(nudExp_PerAbdomen.Value), Convert.ToDouble(nudExp_PreSis.Value),
                                        Convert.ToDouble(nudExp_PreDias.Value), Convert.ToInt32(cbExp_Cita.SelectedValue),
                                        txtExp_Odontograma.Text);
                nudExp_Estatura.Value = 0;
                nudExp_FrecCardiaca.Value = 0;
                nudExp_FrecRespiratoria.Value = 0;
                nudExp_PerAbdomen.Value = 0;
                nudExp_PerToraxExp.Value = 0;
                nudExp_PerToraxIns.Value = 0;
                nudExp_Peso.Value = 0;
                nudExp_PreDias.Value = 0;
                nudExp_PreSis.Value = 0;
                nudExp_Temperatura.Value = 0;
                txtEvolucion.Text = "";
                txtExp_Estudios.Text = "";
                txtExp_Odontograma.Text = "";
                MessageBox.Show("Datos introducidos correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al introducir datos");
            }
        }

        private void actualizarTab0()
        {
            medico = client.readMedico().Where(x => x.ID_Cuenta == CuentaActual).FirstOrDefault();
            List<Cita> citas = client.readCita().Where(x => x.ID_Medico == medico.ID).ToList();
            List<Paciente> pacientes = client.readPaciente().ToList();
            List<Horario> horarios = client.readHorario().ToList();
            var filtroCitas = from x in citas
                              join y in pacientes on x.ID_Paciente equals y.ID
                              join z in horarios on x.ID_Horario equals z.ID
                              select new { Paciente = y.nombre + " " + y.apellidoPaterno, Fecha = x.fecha, Hora = z.hora + ":00-" + (z.hora + 1) + ":00", Descripcion = x.descripcion };
            dgvVerCita.DataSource = filtroCitas.ToList();
        }
        private void actualizarTab1()
        {
            List<Paciente> pacientes = client.readPaciente().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroPaciente = from x in pacientes
                                 select new { Nombre = x.nombre + " " + x.apellidoPaterno + " " + x.apellidoMaterno, ID = x.ID };
            cbNuevaCita_Paciente.ValueMember = "Nombre";
            cbNuevaCita_Paciente.ValueMember = "ID";
            cbNuevaCita_Paciente.DataSource = filtroPaciente.ToList();
            horarios = client.readHorario().Where(x => x.ID_Medico == medico.ID).ToList();
        }
        private string day()
        {
            string result = " ";
            switch (calendarNuevaCita.SelectionStart.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    result = "D";
                    break;
                case DayOfWeek.Monday:
                    result = "L";
                    break;
                case DayOfWeek.Tuesday:
                    result = "M";
                    break;
                case DayOfWeek.Wednesday:
                    result = "X";
                    break;
                case DayOfWeek.Thursday:
                    result = "J";
                    break;
                case DayOfWeek.Friday:
                    result = "V";
                    break;
                case DayOfWeek.Saturday:
                    result = "S";
                    break;
            }
            return result;
        }
        private void actualizarTab2()
        {
            List<Paciente> pacientes = client.readPaciente().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroPaciente = from x in pacientes
                                 select new { Nombre = x.nombre + " " + x.apellidoPaterno + " " + x.apellidoMaterno, ID = x.ID };
            cbAdministrarCita_Paciente.ValueMember = "Nombre";
            cbAdministrarCita_Paciente.ValueMember = "ID";
            cbAdministrarCita_Paciente.DataSource = filtroPaciente.ToList();
        }
        private void actualizarTab3()
        {
            List<Paciente> pacientes = client.readPaciente().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroPaciente = from x in pacientes
                                 select new { Nombre = x.nombre + " " + x.apellidoPaterno + " " + x.apellidoMaterno, ID = x.ID };
            cbInfoPaciente_Medico.ValueMember = "Nombre";
            cbInfoPaciente_Medico.ValueMember = "ID";
            cbInfoPaciente_Medico.DataSource = filtroPaciente.ToList();
        }
        private void actualizarTab4()
        {
            List<Paciente> pacientes = client.readPaciente().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroPaciente = from x in pacientes
                                 select new { Nombre = x.nombre + " " + x.apellidoPaterno + " " + x.apellidoMaterno, ID = x.ID };
            cbExp_Paciente.ValueMember = "Nombre";
            cbExp_Paciente.ValueMember = "ID";
            cbExp_Paciente.DataSource = filtroPaciente.ToList();
        }
        private void actualizarTab5()
        {
            List<Paciente> pacientes = client.readPaciente().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroPaciente = from x in pacientes
                                 select new { Nombre = x.nombre + " " + x.apellidoPaterno + " " + x.apellidoMaterno, ID = x.ID };
            cbNuevaReceta_Paciente.ValueMember = "Nombre";
            cbNuevaReceta_Paciente.ValueMember = "ID";
            cbNuevaReceta_Paciente.DataSource = filtroPaciente.ToList();
        }
        private void FormMedico_Load(object sender, EventArgs e)
        {
            actualizarTab0();
        }

        private void tcMain_Click(object sender, EventArgs e)
        {
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    actualizarTab0();
                    break;
                case 1:
                    actualizarTab1();
                    break;
                case 2:
                    actualizarTab2();
                    break;
                case 3:
                    actualizarTab3();
                    break;
                case 4:
                    actualizarTab4();
                    break;
                case 5:
                    actualizarTab5();
                    break;
            }
        }

        private void calendarNuevaCita_DateChanged(object sender, DateRangeEventArgs e)
        {
            var fitlradoHorario = from x in horarios
                                  where x.dia == day()
                                  select new { Hora = x.hora + ":00-" + x.hora + ":00", ID = x.ID };
            listNuevaCita_Hora.DisplayMember = "Hora";
            listNuevaCita_Hora.ValueMember = "ID";
            listNuevaCita_Hora.DataSource = fitlradoHorario.ToList();
        }

        private void btnNuevaCita_Agendar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = calendarNuevaCita.SelectionStart.Date;
                int hora = Convert.ToInt32(cbNuevaCita_Paciente.SelectedValue);
                var comprobar = client.readCita().Where(x => x.fecha == fecha && x.Horario.hora == hora);
                if (comprobar != null)
                {
                    client.createCita(fecha, txtNuevaCita_Motivo.Text, false, hora, medico.ID, Convert.ToInt32(listNuevaCita_Hora.SelectedValue));
                    txtNuevaCita_Motivo.Text = "";
                    MessageBox.Show("Cita asignada correctamente");
                }
                else
                {
                    MessageBox.Show("Espacio ocupado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la cita");
            }
        }

        private void cbAdministrarCita_Paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            horarios = client.readHorario().ToList();
            List<Cita> Citas = client.readCita().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroCitas = from x in Citas
                              where x.ID_Paciente == Convert.ToInt32(cbAdministrarCita_Paciente.SelectedValue)
                              join y in horarios on x.ID_Horario equals y.ID
                              select new { Hora = x.fecha.Day + "/" + x.fecha.Month + "/" + x.fecha.Year + "   " + y.hora + ":00-" + (y.hora + 1) + ":00", ID = x.ID };
            cbAdministrarCita_Cita.DisplayMember = "hora";
            cbAdministrarCita_Cita.ValueMember = "ID";
            cbAdministrarCita_Cita.DataSource = filtroCitas.ToList();
        }

        private void btnAdministrarCita_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.deleteCita(Convert.ToInt32(cbAdministrarCita_Cita.SelectedValue)) == false)
                {
                    horarios = client.readHorario().ToList();
                    List<Cita> Citas = client.readCita().Where(x => x.ID_Medico == medico.ID).ToList();
                    var filtroCitas = from x in Citas
                                      where x.ID_Paciente == Convert.ToInt32(cbAdministrarCita_Paciente.SelectedValue)
                                      join y in horarios on x.ID_Horario equals y.ID
                                      select new { Hora = x.fecha.Day + "/" + x.fecha.Month + "/" + x.fecha.Year + "   " + y.hora + ":00-" + (y.hora + 1) + ":00", ID = x.ID };
                    cbAdministrarCita_Cita.DisplayMember = "hora";
                    cbAdministrarCita_Cita.ValueMember = "ID";
                    cbAdministrarCita_Cita.DataSource = filtroCitas.ToList();
                    MessageBox.Show("Error al aliminar");
                }
                else
                {
                    MessageBox.Show("Eliminado correctamente");
                    actualizarTab2();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void cbInfoPaciente_Medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = client.readPaciente().Where(x => x.ID == Convert.ToInt32(cbInfoPaciente_Medico.SelectedValue)).LastOrDefault();
                txtInfoPaciente_Nombres.Text = paciente.nombre;
                txtInfoPaciente_ApellidoPaterno.Text = paciente.apellidoPaterno;
                txtInfoPaciente_ApellidoMaterno.Text = paciente.apellidoMaterno;
                txtInfoPaciente_Direccion.Text = paciente.direccion;
                txtInfoPaciente_Fecha.Text = paciente.fechaNacimiento.ToShortDateString();
                txtInfoPaciente_Sexo.Text = paciente.sexo;
                txtInfoPaciente_Telefono.Text = paciente.telefono;
                txtInfoPaciente_TipoSangre.Text = paciente.tipoSangre;
            }
            catch (Exception)
            {

            }
        }

        private void cbExp_Paciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            horarios = client.readHorario().ToList();
            List<Cita> Citas = client.readCita().Where(x => x.ID_Medico == medico.ID).ToList();
            var filtroCitas = from x in Citas
                              where x.ID_Paciente == Convert.ToInt32(cbAdministrarCita_Paciente.SelectedValue)
                              join y in horarios on x.ID_Horario equals y.ID
                              select new { Hora = x.fecha.Day + "/" + x.fecha.Month + "/" + x.fecha.Year + "   " + y.hora + ":00-" + (y.hora + 1) + ":00", ID = x.ID };
            cbExp_Cita.DisplayMember = "hora";
            cbExp_Cita.ValueMember = "ID";
            cbExp_Cita.DataSource = filtroCitas.ToList();
        }

        private void cbNuevaReceta_Paciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
