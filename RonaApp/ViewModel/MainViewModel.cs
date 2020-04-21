using RonaApp.ViewModel.Base;
using RonaApp.Views;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
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

        //Ejer2: Método SetValue
        //Recibe una variable privada, la iguala al valor recibido y notifica que se ha realizado el cambio.

        protected void SetValue<T>(ref T PrivateValue, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(PrivateValue, value))
            {
                return;
            }
            PrivateValue = value;
            RaisePropertyChanged(propertyName);
        }

    }
}
