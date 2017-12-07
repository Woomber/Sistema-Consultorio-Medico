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
    public partial class FormInterrogatorio : Form
    {
        WebServiceSoapClient client;

        public int PacienteActual { get; set; }

        public FormInterrogatorio(int actual)
        {
            InitializeComponent();

            client = new WebServiceSoapClient();

            PacienteActual = actual;

            // Si ya existe un interrogatorio, mostrarlo
            leerInterrogatorio();
        }

        void leerInterrogatorio()
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*
             * Si ya hay interrogatorio, actualizar
             * Si no, crear 
             */
        }
    }
}
