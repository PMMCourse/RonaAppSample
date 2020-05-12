using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
using RonaApp.ViewModel.Base;
using RonaApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace RonaApp.ViewModel
{
    public class ShowPatientsViewModel : BaseViewModel
    {

        private RelayCommand _filtrarPacientes;
        private RelayCommand<object> _limpiarfiltrarPacientes;
        public ICommand FiltrarPacientesCommand => _filtrarPacientes;
        public ICommand LimpiarFiltrarPacientesCommand => _limpiarfiltrarPacientes;

        protected override void InitCommands()
        {
            _filtrarPacientes = new RelayCommand(PerformFiltrarPacientes);
            _limpiarfiltrarPacientes = new RelayCommand<object>(ResetformFiltrarPacientes);
        }

        private readonly IPatientsService _patientsService;

        private ObservableCollection<Patient> _observablePatients= new ObservableCollection<Patient>();
        public ObservableCollection<Patient> ObservablePatients
        {
            get
            {
                return _observablePatients;
            }
            set
            {
                _observablePatients = value;
                RaisePropertyChanged("ObservablePatients");
            }
        }

        private List<Patient> _patients;

        public List<Patient> Patients
        {
            get => _patients;
            set
            {
                _patients = value;
                RaisePropertyChanged("Patients");
            }
        }
      
        private List<Patient> _filteredPatients;

        public List<Patient> FilteredPatients
        {
            get => _filteredPatients;
            set
            {
                _filteredPatients = value;
                RaisePropertyChanged("FilteredPatients");
            }
        }

        private String? txtBusqueda;
        public String? TxtBusqueda
        {
            get { return txtBusqueda; }
            set { txtBusqueda = value; }
        }


        public ShowPatientsViewModel()
        {
            _patientsService = Locator.Load<IPatientsService>();
        }



        public override void OnLoaded()
        {
            base.OnLoaded();
            Patients = _patientsService.Patients;
            FilteredPatients = Patients;
            ObservablePatients = new ObservableCollection<Patient>(FilteredPatients as List<Patient>);
            iniciarReloj();
        }

        

        private void PerformFiltrarPacientes()
        {
            if (TxtBusqueda != null)
            {
                var consulta = Patients.Select(o => o).Where(o => o.Name.Contains(TxtBusqueda) || o.Surname.Contains(TxtBusqueda)).ToList();
                FilteredPatients = consulta;
            }
            else
            {
                FilteredPatients = Patients;
            }
            ObservablePatients = new ObservableCollection<Patient>(FilteredPatients as List<Patient>);
        }

        private void ResetformFiltrarPacientes(object txtBuscar)
        {
            (txtBuscar as TextBox).Text = string.Empty;
            TxtBusqueda = "";
            ObservablePatients = new ObservableCollection<Patient>(Patients as List<Patient>);
        }

        public void iniciarReloj()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += new EventHandler(timer_Elapsed);
            timer.Start();
        }
        void timer_Elapsed(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            if (Patients.Count > 0)
            {
                for (int i = 0; i < Patients.Count; i++)
                {
                    TimeSpan Diferencia = ahora - Patients[i].horaEntrada;
                    Patients[i].tiempoRegistro = Diferencia;
                }
                PerformFiltrarPacientes();
            }
        }


    }
}
