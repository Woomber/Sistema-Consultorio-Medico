//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consultorioMedico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medico
    {
        public Medico()
        {
            this.Cita = new List<Cita>();
            this.Horario = new List<Horario>();
            this.MedicoSecretario = new List<MedicoSecretario>();
            this.Paciente = new List<Paciente>();
            this.Receta = new List<Receta>();
        }
    
        public int ID { get; set; }
        public int ID_Cuenta { get; set; }
        public string nombre { get; set; }
        public string apellidoMaterno { get; set; }
        public string apellidoPaterno { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string especialidad { get; set; }
    
        public   List<Cita> Cita { get; set; }
        public   Cuenta Cuenta { get; set; }
        public   List<Horario> Horario { get; set; }
        public   List<MedicoSecretario> MedicoSecretario { get; set; }
        public   List<Paciente> Paciente { get; set; }
        public   List<Receta> Receta { get; set; }
    }
}
