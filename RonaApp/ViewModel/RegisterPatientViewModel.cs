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
        private readonly IVirusService _virusService;

        public RegisterPatientViewModel()
        {
            _patientsService = Locator.Load<IPatientsService>();
            _virusService = Locator.Load<IVirusService>();
            _virusService.AllVirus.Add(new COVID());
            
        }
        private List<Virus> _allVirus;
        public List<Virus> AllVirus
        {
            get => _allVirus;
            set => SetValue(ref _allVirus, value);
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
            set => SetValue(ref _name,value);
        }

        private string _surname;

        public string Surname
        {
            get => _surname;
            set => SetValue(ref _surname, value);
        }

        private string _virusName;

        public string VirusName
        {
            get => _virusName;
            set => SetValue(ref _virusName, value);
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
                case "Malaria":
                    return new Malaria();
                default:
                    return null;
            }
        }
    }
}
