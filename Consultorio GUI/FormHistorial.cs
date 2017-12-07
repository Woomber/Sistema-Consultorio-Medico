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
        WebServiceSoapClient client;

        public int PacienteActual { get; set; }
        public FormHistorial(int actual)
        {
            InitializeComponent();

            client = new WebServiceSoapClient();

            PacienteActual = actual;


            //aquí se pone en el dgv las exploraciones fisicas del paciente
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {

        }
    }
}
