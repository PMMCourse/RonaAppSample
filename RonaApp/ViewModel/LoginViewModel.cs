using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace RonaApp.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {

        //EJERCICIO 3
        //No sabía si era necesario registrar el usuario
        protected override void InitCommands()
        {
            _showMenuPageAndVerifyCommand = new RelayCommand(PerformMenu);
        }

        public LoginViewModel()
        {
            InitCommands();
        }

        //private string _user;
        private string _password;
        private RelayCommand _showMenuPageAndVerifyCommand;

        /*
        public string User
        {
           get => _user;
           set => SetValue(ref _user, value);
        }  */    
        
        public string Password
        {
            get => _password;
            set => SetValue(ref _password, value);
        }
        public ICommand ShowMenuPageAndVerifyCommand => _showMenuPageAndVerifyCommand;

        private void PerformMenu()
        {
            if (_password == "hardcodeada")
            {
                new MainWindow().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Porfavor ingresa una contraseña que sea correcta", "¡Alerta!", MessageBoxButton.OK);               
            }
            
        }
    }
}
