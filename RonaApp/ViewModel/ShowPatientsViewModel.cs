using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
using RonaApp.ViewModel.Base;
using RonaApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace RonaApp.ViewModel
{
    public class ShowPatientsViewModel : BaseViewModel
    {

        private RelayCommand _filtrarPacientes;
        public ICommand FiltrarPacientesCommand => _filtrarPacientes;

        protected override void InitCommands()
        {
            _filtrarPacientes = new RelayCommand(PerformFiltrarPacientes);
        }

        private readonly IPatientsService _patientsService;

        private List<Patient> _patients;

        public List<Patient> Patients
        {
            get => _patients;
            set
            {
                _patients = value;
                RaisePropertyChanged();
            }
        }

        private List<Patient> _filteredPatients;

        public List<Patient> FilteredPatients
        {
            get => _filteredPatients;
            set
            {
                _filteredPatients = value;
                RaisePropertyChanged();
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
        }

        private void PerformFiltrarPacientes()
        {
            if (TxtBusqueda != null)
            {
                var consulta = Patients.Select(o => o).Where(o => o.Name.Contains(TxtBusqueda) || o.Surname.Contains(TxtBusqueda)).ToList();
                FilteredPatients = consulta;
            }else
            {
                FilteredPatients = Patients;
            }
            
        }
    }
}
