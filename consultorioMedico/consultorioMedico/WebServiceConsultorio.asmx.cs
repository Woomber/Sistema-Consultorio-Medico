using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace consultorioMedico
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        consulmedicoEntities Entidades;
        public WebService1()
        {
            Entidades = new consulmedicoEntities();
        }


        //---------------------------------------CRUD cita-------------------------------------
        [WebMethod]
        public bool createCita(int ID, DateTime fecha, string descripcion, bool status, int ID_Paciente, int ID_Medico, int ID_Horario)
        {
            try
            {
                Cita cita = new Cita();
                cita.ID = ID;
                cita.fecha = fecha;
                cita.descripcion = descripcion;
                cita.status = status;
                cita.ID_Paciente = ID_Paciente;
                cita.ID_Medico = ID_Medico;
                cita.ID_Horario = ID_Horario;
                Entidades.Cita.Add(cita);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Cita> readCita()
        {
            return Entidades.Cita.ToList();
        }
        [WebMethod]
        public bool updateCita(int ID, DateTime fecha, string descripcion, bool status, int ID_Paciente, int ID_Medico, int ID_Horario)
        {
            try
            {
                Cita cita = Entidades.Cita.Where(x=>x.ID==ID).FirstOrDefault();
                cita.fecha = fecha;
                cita.descripcion = descripcion;
                cita.status = status;
                cita.ID_Paciente = ID_Paciente;
                cita.ID_Medico = ID_Medico;
                cita.ID_Horario = ID_Horario;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteCita(int ID)
        {
            try
            {
                Cita cita = Entidades.Cita.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Cita.Remove(cita);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //-------------------------------CRUD cuenta---------------------------------------------
        [WebMethod]
        public bool createCuenta(int ID, string username, string password, int tipo)
        {
            try
            {
                Cuenta cuenta = new Cuenta();
                TipoCuenta tipoCuenta = Entidades.TipoCuenta.Where(x=>x.ID==tipo).FirstOrDefault();
                cuenta.ID = ID;
                cuenta.username = username;
                cuenta.password = password;
                cuenta.TipoCuenta = tipoCuenta;
                Entidades.Cuenta.Add(cuenta);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public Cuenta readCuenta(string username, string password)
        {
            try
            {
                return Entidades.Cuenta.Where(x => x.username == username && x.password == password).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateCuenta(int ID, string username, string password, int tipo)
        {
            try
            {
                Cuenta cuenta = Entidades.Cuenta.Where(x => x.ID == ID).FirstOrDefault();
                TipoCuenta tipoCuenta = Entidades.TipoCuenta.Where(x => x.ID == tipo).FirstOrDefault();
                cuenta.username = username;
                cuenta.password = password;
                cuenta.TipoCuenta = tipoCuenta;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteCuenta(int ID)
        {
            try
            {
                Cuenta cuenta = Entidades.Cuenta.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Cuenta.Remove(cuenta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //-------------------------------CRUD ExpFisica---------------------------------------------
        [WebMethod]
        public bool createExpFisica
         (int ID, string estudios, string evolucion, double temperatura, int frecCardiaca, 
         int frecRespiratoria, double estatura, double peso, double perToraxIns, double perToraExp, 
         double perAbdomen, double presionSis, double presionDias, int ID_Cita, string odontograma)
        {
            try
            {
                ExpFisica expFisica = new ExpFisica();
                expFisica.ID = ID;
                expFisica.estudios = estudios;
                expFisica.evolucion = evolucion;
                expFisica.temperatura = temperatura;
                expFisica.frecCardiaca = frecCardiaca;
                expFisica.frecRespiratoria = frecRespiratoria;
                expFisica.estatura = estatura;
                expFisica.peso = peso;
                expFisica.perToraxIns = perToraxIns;
                expFisica.perToraxExp = perToraExp;
                expFisica.perAbdomen = perAbdomen;
                expFisica.presionSis = presionSis;
                expFisica.presionDias = presionDias;
                expFisica.ID_Cita = ID_Cita;
                expFisica.odontograma = odontograma;
                Entidades.ExpFisica.Add(expFisica);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<ExpFisica> readExpFisica()
        {
            try
            {
                return Entidades.ExpFisica.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateExpFisica
         (int ID, string estudios, string evolucion, double temperatura, int frecCardiaca,
         int frecRespiratoria, double estatura, double peso, double perToraxIns, double perToraExp,
         double perAbdomen, double presionSis, double presionDias, int ID_Cita, string odontograma)
        {
            try
            {
                ExpFisica expFisica= Entidades.ExpFisica.Where(x => x.ID == ID).FirstOrDefault();
                expFisica.estudios = estudios;
                expFisica.evolucion = evolucion;
                expFisica.temperatura = temperatura;
                expFisica.frecCardiaca = frecCardiaca;
                expFisica.frecRespiratoria = frecRespiratoria;
                expFisica.estatura = estatura;
                expFisica.peso = peso;
                expFisica.perToraxIns = perToraxIns;
                expFisica.perToraxExp = perToraExp;
                expFisica.perAbdomen = perAbdomen;
                expFisica.presionSis = presionSis;
                expFisica.presionDias = presionDias;
                expFisica.ID_Cita = ID_Cita;
                expFisica.odontograma = odontograma;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteExpFisica(int ID)
        {
            try
            {
                ExpFisica cuenta = Entidades.ExpFisica.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.ExpFisica.Remove(cuenta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD horario---------------------------------------------
        [WebMethod]
        public bool createHorario(int ID, int ID_Medico, string dia, int hora)
        {
            try
            {
                Horario horario = new Horario();
                horario.ID = ID;
                horario.ID_Medico = ID_Medico;
                horario.dia = dia;
                horario.hora = hora;
                Entidades.Horario.Add(horario);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Horario> readHorario()
        {
            try
            {
                return Entidades.Horario.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateHorario(int ID, int ID_Medico, string dia, int hora)
        {
            try
            {
                Horario horario = Entidades.Horario.Where(x => x.ID == ID).FirstOrDefault();
                horario.ID = ID;
                horario.ID_Medico = ID_Medico;
                horario.dia = dia;
                horario.hora = hora;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteHorario(int ID)
        {
            try
            {
                Horario horario= Entidades.Horario.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Horario.Remove(horario);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD Interrogatorio---------------------------------------------
        [WebMethod]
        public bool createInterrogatorio
         (int ID, string alimentacion, bool deporte, bool drogas, bool toma,
          bool fuma, bool enfMental, bool enfCorazon, bool cancer, bool diabetes, bool enfCerVas, int idPaciente)
        {
            try
            {
                Interrogatorio interrogatorio = new Interrogatorio();
                Paciente paciente = Entidades.Paciente.Where(x => x.ID == idPaciente).FirstOrDefault();
                interrogatorio.ID = ID;
                interrogatorio.alimentacion = alimentacion;
                interrogatorio.deporte = deporte;
                interrogatorio.drogas = drogas;
                interrogatorio.toma = toma;
                interrogatorio.fuma = fuma;
                interrogatorio.enfMental = enfMental;
                interrogatorio.enfCorazon = enfCorazon;
                interrogatorio.cancer = cancer;
                interrogatorio.diabetes = diabetes;
                interrogatorio.enfCerVas = enfCerVas;
                interrogatorio.Paciente = paciente;
                Entidades.Interrogatorio.Add(interrogatorio);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Interrogatorio> readInterrogatorio()
        {
            try
            {
                return Entidades.Interrogatorio.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateInterrogatorio
         (int ID, string alimentacion, bool deporte, bool drogas, bool toma,
          bool fuma, bool enfMental, bool enfCorazon, bool cancer, bool diabetes, bool enfCerVas, int idPaciente)
        {
            try
            {
                Interrogatorio interrogatorio = Entidades.Interrogatorio.Where(x => x.ID == ID).FirstOrDefault();
                Paciente paciente = Entidades.Paciente.Where(x => x.ID == idPaciente).FirstOrDefault();
                interrogatorio.alimentacion = alimentacion;
                interrogatorio.deporte = deporte;
                interrogatorio.drogas = drogas;
                interrogatorio.toma = toma;
                interrogatorio.fuma = fuma;
                interrogatorio.enfMental = enfMental;
                interrogatorio.enfCorazon = enfCorazon;
                interrogatorio.cancer = cancer;
                interrogatorio.diabetes = diabetes;
                interrogatorio.enfCerVas = enfCerVas;
                interrogatorio.Paciente = paciente;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteInterrogatorio(int ID)
        {
            try
            {
                Interrogatorio interrogatorio = Entidades.Interrogatorio.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Interrogatorio.Remove(interrogatorio);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD MedicamentoReceta---------------------------------------------
        [WebMethod]
        public bool createMedicamentoReceta(int ID, string medicamento, string dosis, string horario, int idReceta)
        {
            try
            {
                MedicamentoReceta medicamentoReceta = new MedicamentoReceta();
                medicamentoReceta.ID = ID;
                medicamentoReceta.medicamento = medicamento;
                medicamentoReceta.dosis = dosis;
                medicamentoReceta.horario = horario;
                medicamentoReceta.ID_Receta = idReceta;
                Entidades.MedicamentoReceta.Add(medicamentoReceta);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<MedicamentoReceta> readMedicamentoReceta()
        {
            try
            {
                return Entidades.MedicamentoReceta.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateMedicamentoReceta(int ID, string medicamento, string dosis, string horario, int idReceta)
        {
            try
            {
                MedicamentoReceta medicamentoReceta = Entidades.MedicamentoReceta.Where(x => x.ID == ID).FirstOrDefault();
                medicamentoReceta.medicamento = medicamento;
                medicamentoReceta.dosis = dosis;
                medicamentoReceta.horario = horario;
                medicamentoReceta.ID_Receta = idReceta;                
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteMedicamentoReceta(int ID)
        {
            try
            {
                MedicamentoReceta medicamentoReceta = Entidades.MedicamentoReceta.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.MedicamentoReceta.Remove(medicamentoReceta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD Medico---------------------------------------------
        [WebMethod]
        public bool createMedico
            (int ID, int idCuenta, string nombre, string apellidoMaterno, string apellidoPaterno,
            DateTime fechaNacimiento, string sexo, string telefono, string especialidad)
        {
            try
            {
                Medico medico = new Medico();
                medico.ID = ID;
                medico.ID_Cuenta = idCuenta;
                medico.nombre = nombre;
                medico.apellidoMaterno = apellidoMaterno;
                medico.apellidoPaterno = apellidoPaterno;
                medico.fechaNacimiento = fechaNacimiento;
                medico.sexo = sexo;
                medico.telefono = telefono;
                medico.especialidad = especialidad;
                Entidades.Medico.Add(medico);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Medico> readMedico()
        {
            try
            {
                return Entidades.Medico.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateMedico
            (int ID, int idCuenta, string nombre, string apellidoMaterno, string apellidoPaterno,
            DateTime fechaNacimiento, string sexo, string telefono, string especialidad)
        {
            try
            {
                Medico medico = Entidades.Medico.Where(x => x.ID == ID).FirstOrDefault();
                medico.ID_Cuenta = idCuenta;
                medico.nombre = nombre;
                medico.apellidoMaterno = apellidoMaterno;
                medico.apellidoPaterno = apellidoPaterno;
                medico.fechaNacimiento = fechaNacimiento;
                medico.sexo = sexo;
                medico.telefono = telefono;
                medico.especialidad = especialidad;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteMedico(int ID)
        {
            try
            {
                Medico medico = Entidades.Medico.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Medico.Remove(medico);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD MedicoSecretario---------------------------------------------
        [WebMethod]
        public bool createMedicoSecretario(int ID, int idMedico, int idSecretario)
        {
            try
            {
                MedicoSecretario medicoSecretario = new MedicoSecretario();
                medicoSecretario.ID = ID;
                medicoSecretario.ID_Medico = idMedico;
                medicoSecretario.ID_Secretario = idSecretario;
                Entidades.MedicoSecretario.Add(medicoSecretario);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<MedicoSecretario> readMedicoSecretario()
        {
            try
            {
                return Entidades.MedicoSecretario.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateMedicoSecretario(int ID, int idMedico, int idSecretario)
        {
            try
            {
                MedicoSecretario medicoSecretario = Entidades.MedicoSecretario.Where(x => x.ID == ID).FirstOrDefault();
                medicoSecretario.ID_Medico = idMedico;
                medicoSecretario.ID_Secretario = idSecretario;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteMedicoSecretario(int ID)
        {
            try
            {
                MedicoSecretario medicoSecretario = Entidades.MedicoSecretario.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.MedicoSecretario.Remove(medicoSecretario);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD Paciente---------------------------------------------
        [WebMethod]
        public bool createPaciente
            (int ID, int idCuenta, string nombre, string apellidoMaterno, string apellidoPaterno,
            string tipoSangre, DateTime fechaNacimiento, string sexo, string telefono, string direccion, int idMedico)
        {
            try
            {
                Paciente paciente = new Paciente();
                paciente.ID = ID;
                paciente.ID_Cuenta = idCuenta;
                paciente.nombre = nombre;
                paciente.apellidoMaterno = apellidoMaterno;
                paciente.apellidoPaterno = apellidoPaterno;
                paciente.tipoSangre = tipoSangre;
                paciente.fechaNacimiento = fechaNacimiento;
                paciente.sexo = sexo;
                paciente.telefono = telefono;
                paciente.direccion = direccion;
                paciente.ID_Medico = idMedico;
                Entidades.Paciente.Add(paciente);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Paciente> readPaciente()
        {
            try
            {
                return Entidades.Paciente.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updatePaciente
            (int ID, int idCuenta, string nombre, string apellidoMaterno, string apellidoPaterno,
            string tipoSangre, DateTime fechaNacimiento, string sexo, string telefono, string direccion, int idMedico)
        {
            try
            {
                Paciente paciente = Entidades.Paciente.Where(x => x.ID == ID).FirstOrDefault();
                paciente.ID_Cuenta = idCuenta;
                paciente.nombre = nombre;
                paciente.apellidoMaterno = apellidoMaterno;
                paciente.apellidoPaterno = apellidoPaterno;
                paciente.tipoSangre = tipoSangre;
                paciente.fechaNacimiento = fechaNacimiento;
                paciente.sexo = sexo;
                paciente.telefono = telefono;
                paciente.direccion = direccion;
                paciente.ID_Medico = idCuenta;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deletePaciente(int ID)
        {
            try
            {
                Paciente paciente = Entidades.Paciente.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Paciente.Remove(paciente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD Receta---------------------------------------------
        [WebMethod]
        public bool createReceta(int ID, int idMedico, int idPaciente, bool status, string recomendaciones)
        {
            try
            {
                Receta receta = new Receta();
                receta.ID = ID;
                receta.ID_Medico = idMedico;
                receta.ID_Paciente = idPaciente;
                receta.status = status;
                receta.recomendaciones = recomendaciones;
                Entidades.Receta.Add(receta);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Receta> readReceta()
        {
            try
            {
                return Entidades.Receta.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateReceta(int ID, int idMedico, int idPaciente, bool status, string recomendaciones)
        {
            try
            {
                Receta receta = Entidades.Receta.Where(x => x.ID == ID).FirstOrDefault();
                receta.ID_Medico = idMedico;
                receta.ID_Paciente = idPaciente;
                receta.status = status;
                receta.recomendaciones = recomendaciones;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteReceta(int ID)
        {
            try
            {
                Receta receta = Entidades.Receta.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Receta.Remove(receta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        //-------------------------------CRUD Secretario---------------------------------------------
        [WebMethod]
        public bool createSecretario
            (int ID, int idCuenta, string nombre, string apellidoMaterno, string apellidoPaterno,
             DateTime fechaNacimiento, string telefono, string turno)
        {
            try
            {
                Secretario secretario = new Secretario();
                secretario.ID = ID;
                secretario.ID_Cuenta = idCuenta;
                secretario.nombre = nombre;
                secretario.apellidoMaterno = apellidoMaterno;
                secretario.apellidoPaterno = apellidoPaterno;
                secretario.fechaNacimiento = fechaNacimiento;
                secretario.telefono = telefono;
                secretario.turno = turno;
                Entidades.Secretario.Add(secretario);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Secretario> readSecreatrio()
        {
            try
            {
                return Entidades.Secretario.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateSecretario
            (int ID, int idCuenta, string nombre, string apellidoMaterno, string apellidoPaterno,
             DateTime fechaNacimiento, string telefono, string turno)
        {
            try
            {
                Secretario secretario = Entidades.Secretario.Where(x => x.ID == ID).FirstOrDefault();
                secretario.ID_Cuenta = idCuenta;
                secretario.nombre = nombre;
                secretario.apellidoMaterno = apellidoMaterno;
                secretario.apellidoPaterno = apellidoPaterno;
                secretario.fechaNacimiento = fechaNacimiento;
                secretario.telefono = telefono;
                secretario.turno = turno;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteSecretario(int ID)
        {
            try
            {
                Secretario secretario = Entidades.Secretario.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Secretario.Remove(secretario);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD TipoCuenta---------------------------------------------
        [WebMethod]
        public bool createTipoCuenta(int ID, string nombre)
        {
            try
            {
                TipoCuenta tipoCuenta = new TipoCuenta();
                tipoCuenta.ID = ID;
                tipoCuenta.nombre = nombre;
                Entidades.TipoCuenta.Add(tipoCuenta);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<TipoCuenta> readTipoCuenta()
        {
            try
            {
                return Entidades.TipoCuenta.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateTipoCuenta(int ID, string nombre)
        {
            try
            {
                TipoCuenta tipoCuenta = Entidades.TipoCuenta.Where(x => x.ID == ID).FirstOrDefault();
                tipoCuenta.nombre=nombre;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteTipoCuenta(int ID)
        {
            try
            {
                TipoCuenta tipoCuenta = Entidades.TipoCuenta.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.TipoCuenta.Remove(tipoCuenta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD vacuna---------------------------------------------
        [WebMethod]
        public bool createVacuna(int ID, string nombre)
        {
            try
            {
                Vacuna vacuna = new Vacuna();
                vacuna.ID = ID;
                vacuna.nombre = nombre;
                Entidades.Vacuna.Add(vacuna);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<Vacuna> readVacuna()
        {
            try
            {
                return Entidades.Vacuna.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateVacuna(int ID, string nombre)
        {
            try
            {
                Vacuna vacuna = Entidades.Vacuna.Where(x => x.ID == ID).FirstOrDefault();
                vacuna.nombre = nombre;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteVacuna(int ID)
        {
            try
            {
                Vacuna vacuna = Entidades.Vacuna.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.Vacuna.Remove(vacuna);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        //-------------------------------CRUD vacunaPaciente---------------------------------------------
        [WebMethod]
        public bool createVacunaPaciente(int ID, int idPaciente, int idVacuna)
        {
            try
            {
                VacunaPaciente vacunaPaciente = new VacunaPaciente();
                vacunaPaciente.ID = ID;
                vacunaPaciente.ID_Paciente = idPaciente;
                vacunaPaciente.ID_Vacuna = idVacuna;
                Entidades.VacunaPaciente.Add(vacunaPaciente);
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public List<VacunaPaciente> readVacunaPaciente()
        {
            try
            {
                return Entidades.VacunaPaciente.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        [WebMethod]
        public bool updateVacunaPaciente(int ID, int idPaciente, int idVacuna)
        {
            try
            {
                VacunaPaciente vacunaPaciente = Entidades.VacunaPaciente.Where(x => x.ID == ID).FirstOrDefault();
                vacunaPaciente.ID_Vacuna = idVacuna;
                vacunaPaciente.ID_Paciente = idPaciente;
                if (Entidades.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        [WebMethod]
        public bool deleteVacunaPaciente(int ID)
        {
            try
            {
                VacunaPaciente vacunaPaciente = Entidades.VacunaPaciente.Where(x => x.ID == ID).FirstOrDefault();
                Entidades.VacunaPaciente.Remove(vacunaPaciente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
