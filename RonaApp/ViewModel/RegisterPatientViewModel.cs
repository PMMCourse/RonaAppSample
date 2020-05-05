using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace RonaApp.ViewModel
{
    public class RegisterPatientViewModel : BaseViewModel
    {
        private readonly IVirusService _virusService;

        //private readonly IPatientsService _patientsService;
        private IPatientsService _patientsService;


        public RegisterPatientViewModel()
        {
            _patientsService = Locator.Load<IPatientsService>();
            _virusService = Locator.Load<IVirusService>();
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
                RaisePropertyChanged("Name");
            }
        }

        private string _surname;

        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                RaisePropertyChanged("Surname");
            }
        }



        private Virus _virus;

        public Virus _Virus
        {
            get { return _virus; }
            set { 
                    _virus = value;
                    RaisePropertyChanged();
                }
        }

        private List<Virus> _listavirus;

        public List<Virus> ListaVirus
        {
            get => _listavirus;
            set {
                    _listavirus = value;
                    RaisePropertyChanged();
                }
        }

        
        private void PerformRegisterPatient()
        {
            var patient = new Patient()
            {
                Name = _name,
                Surname = _surname,
                VirusAffected = _Virus,
                tiempoRegistro = 0
            };

            //PatientsService.Instance.Patients.Add(patient);
            _patientsService.Patients.Add(patient);

            

            Close();
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            ListaVirus = _virusService.ListaVirus;
        }

    }
}
