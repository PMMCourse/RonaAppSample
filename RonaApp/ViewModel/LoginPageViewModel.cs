using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RonaApp.ViewModel
{
    public class LoginPageViewModel : BaseViewModel
    {

        //Ejer3: Aquí viene toda la lógica que hace funcionar el LoginPage

        private RelayCommand LoginCommand;

        protected override void InitCommands()
        {
            LoginCommand = new RelayCommand(OnSubmit);
        }

        public LoginPageViewModel()
        {
            InitCommands();
        }

        private string _username;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                RaisePropertyChanged();
            }
        }

        private string _pass;

        public string Pass
        {
            get => _pass;
            set
            {
                _pass = value;
                RaisePropertyChanged();
            }
        }

        public void OnSubmit()
        {
            if (!string.IsNullOrEmpty(Username))
            {
                MessagingCenter.Send(this, "LoginAlert", "Message");
            }
            else if (_username == "xema" && _pass == "hardcodeada")
            {
                new MainWindow().Show();
                Close();
            }
        }


    }
}