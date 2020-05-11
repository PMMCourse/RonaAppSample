using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using RonaApp.Model;
using RonaApp.Services.Base;
using System.Windows.Input;
using System.Windows;
using RonaApp.Services;
using System.Linq;
using System.Windows.Controls;

namespace RonaApp.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IUserService _userservice;
        private RelayCommand<object> _loginUserCommand;
        public ICommand LoginUserCommand => _loginUserCommand;

        protected override void InitCommands()
        {
          _loginUserCommand = new RelayCommand<object>(VerifyUserLogin);
        }

        private List<User> _usuarios;

        public List<User> Usuarios
        {
            get => _usuarios;
            set
            {
                _usuarios = value;
                RaisePropertyChanged();
            }
        }

        private String _username;

        public String Username
        {
            get { return _username; }
            set {
                _username = value;
                RaisePropertyChanged("Username");
            }
        }

        private PasswordBox _passwd;

        public PasswordBox Passwd
        {
            get { return _passwd; }
            set {
                _passwd = Passwd;
                RaisePropertyChanged("Passwd");
            }
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            Usuarios = _userservice.usuarios;
        }

        public LoginViewModel()
        {
            _userservice = Locator.Load<IUserService>();
        }

        private void VerifyUserLogin(object passBox)
        {
            var Passwd = (PasswordBox)passBox;
            var consulta = Usuarios.Select(o => o).Where(o => o.username == Username && o.passwd == Passwd.Password).ToList();
            if (consulta.Count == 1)
            {
                foreach(var user in consulta)
                {
                    UserRol.Permiso = user.rol;
                }
                RonaApp.MainWindow VistaPrincipal = new RonaApp.MainWindow();
                VistaPrincipal.Show();
                Close();
            } else {
                MessageBox.Show("Login incorrecto", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

    //Constante con la que se determinan los permisos de cada usuario
    public static class UserRol
    {
        public static String Permiso { get; set; }
    }



}
