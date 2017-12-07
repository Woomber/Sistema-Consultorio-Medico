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
        //de por mientras
        public int pacienteactual;

        public FormPaciente(int actual)
        {
            InitializeComponent();

            client = new WebServiceSoapClient();

            CuentaActual = actual;

            actualizarDatos();
        }
        
        void actualizarDatos()
        {
            WebService.WebServiceSoapClient x = new WebServiceSoapClient();
          //  List<modeloPaciente> pa = x.readPaciente().ToList();

           /*xtInfoPaciente_Nombres.DataSource = pa;
            txtInfoPaciente_ApellidoPaterno.Text = pa.;
            txtInfoPaciente_ApellidoMaterno.Text = na.apellidoMaterno;
            txtInfoPaciente_TipoSangre.Text = na.tipoSangre;
            txtInfoPaciente_Sexo.Text = na.sexo;
 /          txtInfoPaciente_Fecha.Text = na.fechaNacimiento;

           int idmedico = pa.idMedico;
            List<modeloCita> res = x.readCita(idmedico,pacienteactual);
            dgvVerCita.DataSource = res;
            //Actualizar aquí todo lo automático
            //Mostrar información del paciente*/
        }

        private void btnInfoPaciente_Guardar_Click(object sender, EventArgs e)
        {
            WebService.WebServiceSoapClient x = new WebServiceSoapClient();

            string nom = txtInfoPaciente_Nombres.Text;
            string apep = txtInfoPaciente_ApellidoPaterno.Text;
            string apem = txtInfoPaciente_ApellidoMaterno.Text;
            string sang = txtInfoPaciente_TipoSangre.Text;
            string sex = txtInfoPaciente_Sexo.Text;
         //   DateTime fech = new DateTime(txtInfoPaciente_Fecha.);//. o partir
            string tel = txtInfoPaciente_Telefono.Text;
            string dire = txtInfoPaciente_Direccion.Text;


            //bool res = x.updatePaciente(pacienteactual, nom, apep, apem, sang, fech, sex, tel, dire);//que es username?
/*            if (res == true)
            {
                MessageBox.Show("Datos modificados");
            }
            else
            {
                MessageBox.Show("Error al cambiar datos");
            }*/
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

        private void btnNuevaCita_Agendar_Click(object sender, EventArgs e)
        {
            WebService.WebServiceSoapClient x = new WebServiceSoapClient();//ir?

            string mo = txtNuevaCita_Motivo.Text;
            int hor = listNuevaCita_Hora.SelectedIndex;//no se me ocurrio otra cosa
            DateTime fecha = calendarNuevaCita.SelectionStart;
            bool res = x.createCita(hor, 1, pacienteactual, true, mo, fecha);
        }

        private void btnInfoPaciente_Confirmar_Click(object sender, EventArgs e)
        {
            WebService.WebServiceSoapClient x = new WebServiceSoapClient();
            string contra = txtInfoPaciente_Password.Text;
            string userna = txtInfoPaciente_Nombres.Text;
            bool res = x.updateCuenta(3, contra, userna, "Paciente");//de donde el id
            if (res == true)
            {
                MessageBox.Show("Contraseña modificada");
            }
            else
            {
                MessageBox.Show("Error al modificar contraseña");
            }
        }//ya?

        private void cbRecetas_Receta_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebService.WebServiceSoapClient x = new WebServiceSoapClient();

            modeloReceta selec = cbRecetas_Receta.SelectedItem as modeloReceta;

            List<modeloReceta> yu = x.readReceta();
        }
    }
}
