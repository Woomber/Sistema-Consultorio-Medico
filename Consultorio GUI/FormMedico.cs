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
        WebServiceSoapClient client;

        public int CuentaActual { get; set; }

        public int RecetaActual { get; set; }

        public FormMedico(int actual)
        {
            InitializeComponent();

            client = new WebServiceSoapClient();

            CuentaActual = actual;

            actualizarDatos();
        }

        void actualizarDatos()
        {
            //Actualizar aquí todo lo automático
        }

        private void btnInfoPaciente_Interrogatorio_Click(object sender, EventArgs e)
        {
            //Poner el paciente seleccionado en el 0
            FormInterrogatorio form = new FormInterrogatorio(0);
            form.ShowDialog();
        }

        private void btnInfoPaciente_Vacuna_Click(object sender, EventArgs e)
        {
            //poner el paciente seleccionado, dejar el true
            FormVacunas form = new FormVacunas(0, true);
            form.ShowDialog();
        }

        private void btnNuevaReceta_AgregarMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaReceta_Crear_Click(object sender, EventArgs e)
        {

            //Crear receta nueva y cambiar la receta actual a la nueva

            btnNuevaReceta_AgregarMedicamento.Enabled = true;

        }

        private void btnInfoPaciente_Historial_Click(object sender, EventArgs e)
        {
            //Poner el paciente seleccionado en el 0
            FormHistorial form = new FormHistorial(0);
            form.ShowDialog();

        }

        private void btnExp_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
