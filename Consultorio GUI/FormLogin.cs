﻿using System;
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
    public partial class FormLogin : Form
    {
        WebServiceSoapClient client;

        public int TipoCuenta { get; set; }
        public int CuentaActual { get; set; }

        public FormLogin()
        {
            InitializeComponent();

            client = new WebServiceSoapClient();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Checar usuario y contraseña

            //Cambiar por la lectura del tipo de usuario
            TipoCuenta = 3;

            //Cambiar por la lectura del id de cuenta actual
            CuentaActual = 1;

            switch (TipoCuenta)
            {
                // MEDICO
                case 1:
                    FormMedico formMedico = new FormMedico(CuentaActual);
                    formMedico.Show();
                    formMedico.FormClosed += (s, args) => this.Close();
                    break;

                // SECRETARIO
                case 2:
                    FormSecretario formSecretario = new FormSecretario(CuentaActual);
                    formSecretario.Show();
                    formSecretario.FormClosed += (s, args) => this.Close();
                    break;

                // PACIENTE
                case 3:
                    FormPaciente formPaciente = new FormPaciente(CuentaActual);
                    formPaciente.Show();
                    formPaciente.FormClosed += (s, args) => this.Close();
                    break;
                default:
                    MessageBox.Show("Usuario Incorrecto");
                    return;
            }
            this.Hide();

        }
    }
}
