using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RonaApp.ViewModel
{
    public class RegisterPatientViewModel : BaseViewModel
    {
        private readonly IPatientsService _patientsService;

        public RegisterPatientViewModel()
        {
            _patientsService = Locator.Load<IPatientsService>();
        }


        private RelayCommand _registerPatientCommand;
        public ICommand RegisterPatientCommand => _registerPatientCommand;

        public async Task LoadDataAsync()
        {
            IsLoading = true;
            await Task.Run(() => Scenarios = _service.AllScenarios())
            .ContinueWith(t =>
            {
                IsLoading = false;
                if (t.Exception != null)
                {
                    throw t.Exception; //Allow exception to be caught on Application_UnhandledException
                }
            });
        }

        protected override void InitCommands()
        {
            _registerPatientCommand = new RelayCommand(PerformRegisterPatient);
        }

        

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _surname;

        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                RaisePropertyChanged();
            }
        }

        private string _virusName;

        public string VirusName
        {
            get => _virusName;
            set
            {
                _virusName = value;
                RaisePropertyChanged();
            }
        }

       
        private void PerformRegisterPatient()
        {
            var patient = new Patient()
            {
                Name = _name,
                Surname = _surname,
                VirusAffected = GetVirusAffected()
            };

            //PatientsService.Instance.Patients.Add(patient);
            _patientsService.Patients.Add(patient);

            Close();
        }

        private Virus GetVirusAffected()
        {
            switch(VirusName)
            {
                case "Covid":
                    return new COVID();
                case "Flu":
                    return new Flu();
                default:
                    return null;
            }

        }
        private List<Virus> _listaVirus;
        public List<Virus> listaVirus
        {
            get => _listaVirus;
            set => SetValue(ref _listaVirus, value);
        }
        
    }
}
