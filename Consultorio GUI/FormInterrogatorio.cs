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
        WebService1SoapClient client;
        List<Interrogatorio> Interrogatorios;


        public int PacienteActual { get; set; }

        public FormInterrogatorio(int actual)
        {
            InitializeComponent();

            client = new WebService1SoapClient();

            PacienteActual = actual;

            List<Paciente> actualP = client.readPaciente().ToList();
            var r = from aP in actualP
                    where aP.ID == PacienteActual
                    select aP;
            actualP = r.ToList();

            txtPaciente.Text = actualP[0].nombre + " " + actualP[0].apellidoPaterno + " " + actualP[0].apellidoMaterno;
            Interrogatorios = client.readInterrogatorio().ToList();
            var q = from uno in Interrogatorios
                    where uno.ID_Paciente == PacienteActual
                    select uno;
            var lista = q.ToList();
            Interrogatorios = lista;
            
            
            if(lista.Count() != 0){
                cbAlimentacion.SelectedIndex = cbAlimentacion.FindStringExact(lista[0].alimentacion);
                checkDeporte.Checked = lista[0].deporte;
                checkDrogas.Checked = lista[0].drogas;
                checkCancer.Checked = lista[0].cancer;
                checkCerVas.Checked = lista[0].enfCerVas;
                checkCorazon.Checked = lista[0].enfCorazon;
                checkDiabetes.Checked = lista[0].diabetes;
                checkToma.Checked = lista[0].toma;
                checkFuma.Checked = lista[0].fuma;
                CheckMental.Checked = lista[0].enfMental;
                checkRinon.Checked = lista[0].enfRinon;
            }
            leerInterrogatorio();
        }

        void leerInterrogatorio()
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(Interrogatorios.Count() != 0)
            {
                client.updateInterrogatorio(Interrogatorios[0].ID, cbAlimentacion.SelectedIndex.ToString(), checkDeporte.Checked, checkDrogas.Checked, checkToma.Checked,
                    checkFuma.Checked, CheckMental.Checked, checkCorazon.Checked, checkCancer.Checked, checkDiabetes.Checked, checkCerVas.Checked, PacienteActual);
            }
            else
            {
                client.createInterrogatorio(cbAlimentacion.SelectedItem.ToString(), checkDeporte.Checked, checkDrogas.Checked, checkToma.Checked,
                    checkFuma.Checked, CheckMental.Checked, checkCorazon.Checked, checkCancer.Checked, checkDiabetes.Checked, checkCerVas.Checked, PacienteActual);
            }
            /*
             * Si ya hay interrogatorio, actualizar
             * Si no, crear 
             */
        }
    }
}
