using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RonaApp.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {

        }

        private RelayCommand _loginMethod;

        public ICommand LoginMethodCommand => _loginMethod;
        protected override void InitCommands()
        {
            
        }

        private void Autentification()
        {
            /*if (pswd.text) --------> este es el fallo, no consigo que entienda que pswd es el nombre del textBox
            {

            }
            */
        }
    }
}
