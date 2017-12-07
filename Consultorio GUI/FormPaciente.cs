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
    public partial class FormPaciente : Form
    {
        WebService1SoapClient client;

        List<Paciente> uno;
        List<Cita> dos;
        List<Horario> horarios;

        public int CuentaActual { get; set; }
        //de por mientras
        public int pacienteactual;

        public FormPaciente(int actual)
        {
            InitializeComponent();

            client = new WebService1SoapClient();

            CuentaActual = actual;

            actualizarDatos();

           uno = client.readPaciente().Where(y=>y.ID_Cuenta==CuentaActual).ToList();

            horarios = client.readHorario().ToList();
            
            listNuevaCita_Hora.DisplayMember = "hora";
        }

        void actualizarDatos()
        {
            txtInfoPaciente_Nombres.Text = uno[0].nombre;
            txtInfoPaciente_ApellidoPaterno.Text = uno[0].apellidoPaterno;
            txtInfoPaciente_ApellidoMaterno.Text = uno[0].apellidoMaterno;
            txtInfoPaciente_TipoSangre.Text = uno[0].tipoSangre;
            txtInfoPaciente_Sexo.Text = uno[0].sexo;
            txtInfoPaciente_Fecha.Text = Convert.ToString(uno[0].fechaNacimiento);

            List<Cita> dos = client.readCita().ToList();
            var d = from u in dos
                    where u.ID_Paciente == uno[0].ID
                    select u;
            
            dgvVerCita.DataSource = d.ToList();
            //Actualizar aquí todo lo automático
            //Mostrar información del paciente
        }

        private void btnInfoPaciente_Guardar_Click(object sender, EventArgs e)
        {
            WebService.WebService1SoapClient x = new WebService1SoapClient();

            string tel = txtInfoPaciente_Telefono.Text;
            string dire = txtInfoPaciente_Direccion.Text;

           bool res = client.updatePaciente(uno[0].ID, uno[0].ID_Cuenta, uno[0].nombre, uno[0].apellidoMaterno, uno[0].apellidoPaterno, uno[0].tipoSangre, uno[0].fechaNacimiento, uno[0].sexo,tel,dire, uno[0].ID_Medico);
           if (res == true)
            {
                MessageBox.Show("Datos modificados");
            }
            else
            {
                MessageBox.Show("Error al cambiar datos");
            }
        }

        private void btnInfoPaciente_Historial_Click(object sender, EventArgs e)
        {
            //Reemplazar 0 por paciente actual
            FormHistorial form = new FormHistorial(uno[0].ID);
            form.ShowDialog();
        }

        private void btnInfoPaciente_Vacuna_Click(object sender, EventArgs e)
        {
            //Reemplazar 0 por paciente actual, dejar el false
            FormVacunas form = new FormVacunas(uno[0].ID, false);
            form.ShowDialog();
        }

        private void btnNuevaCita_Agendar_Click(object sender, EventArgs e)
        {

            string mo = txtNuevaCita_Motivo.Text;
            Horario hor = listNuevaCita_Hora.SelectedItem as Horario;
            DateTime fecha = calendarNuevaCita.SelectionStart;

            dos = client.readCita().Where(y => y.ID_Paciente == uno[0].ID).ToList();
            int res = client.createCita(fecha, mo, true, uno[0].ID, uno[0].ID_Medico, hor.ID);
        }

        private void cbRecetas_Receta_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebService.WebService1SoapClient x = new WebService1SoapClient();

            Receta selec = cbRecetas_Receta.SelectedItem as Receta;
            dgvRecetas_Medicamentos.DataSource = x.readMedicamentoReceta();
        }

        private void calendarNuevaCita_DateChanged(object sender, DateRangeEventArgs e)
        {
            Dictionary<DayOfWeek, string> fechas = new Dictionary<DayOfWeek, string>();

            fechas.Add(DayOfWeek.Monday, "L");
            fechas.Add(DayOfWeek.Tuesday, "M");
            fechas.Add(DayOfWeek.Wednesday, "X");
            fechas.Add(DayOfWeek.Thursday, "J");
            fechas.Add(DayOfWeek.Friday, "V");
            fechas.Add(DayOfWeek.Saturday, "S");
            fechas.Add(DayOfWeek.Sunday, "D");

            listNuevaCita_Hora.DataSource = horarios.Where(x => x.ID_Medico == uno[0].ID_Medico && x.dia == fechas[calendarNuevaCita.SelectionStart.DayOfWeek]).ToList();
        }
    }
}
