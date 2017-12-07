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
        WebServiceSoapClient client;

        public int CuentaActual { get; set; }

        public FormSecretario(int actual)
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

        private void cbReadCita_Medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aquí actualizar el datagrid con el elemento seleccionado
        }

        private void btnNuevaCita_Agendar_Click(object sender, EventArgs e)
        {

        }
    }
}
