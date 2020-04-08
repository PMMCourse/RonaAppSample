using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.ViewModel
{
    public class ShowPatientsViewModel : BaseViewModel
    {
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

        public ShowPatientsViewModel()
        {
            _patientsService = Locator.Load<IPatientsService>();
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            Patients = _patientsService.Patients;
        }

        protected override void InitCommands()
        {
            
        }
    }
}
