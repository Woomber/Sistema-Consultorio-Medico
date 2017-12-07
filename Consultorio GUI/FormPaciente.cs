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
        WebServiceSoapClient client;

        public int CuentaActual { get; set; }

        public FormPaciente(int actual)
        {
            InitializeComponent();

            client = new WebServiceSoapClient();

            CuentaActual = actual;

            actualizarDatos();
        }

        void actualizarDatos()
        {
            //Actualizar aquí todo lo automático
            //Mostrar información del paciente
        }

        private void btnInfoPaciente_Guardar_Click(object sender, EventArgs e)
        {
            //actualiza teléfono y dirección
        }

        private void btnInfoPaciente_Historial_Click(object sender, EventArgs e)
        {
            //Reemplazar 0 por paciente actual
            FormHistorial form = new FormHistorial(0);
            form.ShowDialog();
        }

        private void btnInfoPaciente_Vacuna_Click(object sender, EventArgs e)
        {
            //Reemplazar 0 por paciente actual, dejar el false
            FormVacunas form = new FormVacunas(0, false);
            form.ShowDialog();
        }
    }
}
