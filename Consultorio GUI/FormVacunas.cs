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

        List<VacunaPaciente> vacunas;
        List<Vacuna> listaVacunas;
        int[] IDs;

        //Actual es paciente actual
        //from Doctor = true si se entra desde médico
        // false si se entra desde paciente
        public FormVacunas(int actual, bool fromDoctor)
        {
            InitializeComponent();
            client = new WebService1SoapClient();
            PacienteActual = actual;
            if (!fromDoctor){
                btnAgregar.Visible = false;
                cbAgregar.Visible = false;
                lblAgregar.Visible = false;
            }
            listaVacunas = client.readVacuna().ToList();


            
            var q = from datos in client.readPaciente().ToList()
                    where datos.ID == PacienteActual
                    select datos;
            List < Paciente > x = q.ToList();
            txtPaciente.Text = x[0].nombre + " " + x[0].apellidoPaterno + " " +  x[0].apellidoMaterno;
            load();
            load_combo();
            //Cargar las vacunas al cb

        }
        void load_combo()
        {
            cbAgregar.Items.Clear();
            if(IDs != null) Array.Clear(IDs,0,IDs.Length);
            
            vacunas = client.readVacunaPaciente().ToList();
            var q = from lista in listaVacunas
                    join vacuna in vacunas on lista.ID equals vacuna.ID_Vacuna
                    where vacuna.ID_Paciente == PacienteActual
                    select lista.ID;
            
            int[] listaID = q.ToArray();    
            List<Vacuna> faltantes = client.readVacuna().ToList().Where(
                x => !listaID.Contains(x.ID)
                ).ToList();
            if (faltantes == null) return;
            IDs = new int[faltantes.Count()];
            int i = 0;
            foreach(Vacuna falta in faltantes)
            {
                cbAgregar.Items.Add(falta.nombre);
                IDs[i] = falta.ID;
                i++;
            }
        }
        void load()
        {
            vacunas = client.readVacunaPaciente().ToList();
            var q = from lista in listaVacunas
                    join vacuna in vacunas on lista.ID equals vacuna.ID_Vacuna
                    where vacuna.ID_Paciente == PacienteActual
                    select new {Vacuna = lista.nombre };
            dgvVacuna.DataSource = q.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            client.createVacunaPaciente(PacienteActual, IDs[cbAgregar.SelectedIndex]);
            load();
            load_combo();
        }
    }
}
