using RonaApp.ViewModel.Base;
using RonaApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RonaApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() 
        {
            
        }

        
        private RelayCommand _showRegisterViewModelCommand;
        private RelayCommand _showPatientsViewModelCommand;

        public ICommand ShowRegisterViewModelCommand => _showRegisterViewModelCommand;
        public ICommand ShowPatientsViewModelCommand => _showPatientsViewModelCommand;

        protected override void InitCommands()
        {
            _showPatientsViewModelCommand = new RelayCommand(PerformShowPatients);
            _showRegisterViewModelCommand = new RelayCommand(PerformRegisterPatient);

        }

        private void PerformRegisterPatient()
        {
            new RegisterPatientView().Show();
        }

        private void PerformShowPatients()
        {
            new ShowPatientsView().Show();
        }
    }
}
