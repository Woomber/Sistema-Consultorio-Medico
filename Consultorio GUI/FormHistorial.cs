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
    public partial class FormHistorial : Form
    {
        WebService1SoapClient client;

        public int PacienteActual { get; set; }
        public FormHistorial(int actual)
        {
            InitializeComponent();

            client = new WebService1SoapClient();

            PacienteActual = actual;
            List<ExpFisica> Exploraciones = client.readExpFisica().ToList();
            List<Cita> Citas = client.readCita().ToList();
            var q = from exploracion in Exploraciones
                    join cita in Citas on exploracion.ID_Cita equals cita.ID
                    where cita.ID_Paciente == actual
                    select new { Cita = exploracion.Cita, Estatura = exploracion.estatura,
                        Evolucion = exploracion.evolucion, Estudios = exploracion.estudios, FrecuenciaCardiaca = exploracion.frecCardiaca,
                        FrecuenciaRespiratoria = exploracion.frecRespiratoria, Odontograma = exploracion.odontograma, PerimetroAbdomen = exploracion.perAbdomen,
                        PerimetroToxicoExpirar = exploracion.perToraxExp, PerimetroToraxicoInspirar = exploracion.perToraxIns, Peso = exploracion.peso, PresionDias = exploracion.presionDias,
                        Presion = exploracion.presionSis, Temperatura = exploracion.temperatura
                    };


            dgvHistorial.DataSource = q.ToList();


            //aquí se pone en el dgv las exploraciones fisicas del paciente
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {

        }
    }
}
