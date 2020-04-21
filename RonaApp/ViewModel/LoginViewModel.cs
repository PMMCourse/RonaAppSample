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
    public class LoginViewModel : BaseViewModel
    {
        private readonly IPatientsService _patientsService;

        public LoginViewModel()
        {
            _patientsService = Locator.Load<IPatientsService>();
        }


        private RelayCommand _loginCommand;
        public ICommand LoginCommand => _loginCommand;

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
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = "hardcodeada";
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
    }
}
