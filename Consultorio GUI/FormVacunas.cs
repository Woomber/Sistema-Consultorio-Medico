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
    public partial class FormVacunas : Form
    {
        WebService1SoapClient client;

        public int PacienteActual { get; set; }

        //Actual es paciente actual
        //from Doctor = true si se entra desde médico
        // false si se entra desde paciente
        public FormVacunas(int actual, bool fromDoctor)
        {
            InitializeComponent();

            client = new WebService1SoapClient();

            PacienteActual = actual;

            if (!fromDoctor)
            {
                btnAgregar.Visible = false;
                cbAgregar.Visible = false;
                lblAgregar.Visible = false;
            }


            //Cargar las vacunas al cb

        }
    }
}
