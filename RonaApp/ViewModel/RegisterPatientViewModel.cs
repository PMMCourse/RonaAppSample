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

                //Cambio Covid por COVID para que sea igual el nombre del virus de registro que el que devuelve cuando muestra el paciente

                //Parte del ejercicio 7
                //Añado Ebola a la lista de los virus disponibles

                case "COVID":
                    return new COVID();
                case "Flu":
                    return new Flu();
                case "Ebola":
                    return new Ebola();
                default:
                    return null;
            }
        }
    }
}
