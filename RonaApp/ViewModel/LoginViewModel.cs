using RonaApp.Model;
using RonaApp.Services;
using RonaApp.Services.Base;
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
        private readonly ILoginService _loginService;

        //EJERCICIO 3        

        protected override void InitCommands()
        {
            _showMenuPageAndVerifyCommand = new RelayCommand(PerformMenu);
        }

        public LoginViewModel()
        {
            _loginService = Locator.Load<ILoginService>();

            //No se si es el sitio adecuado para inicializar los usuarios.
            //Y no se si es demasiado cutre, o estaría bien.
            _loginService.Users.Add(new Usuario()
            {
                UserName = "Jose" , 
                Password = "hardcodeada" , 
                Permisos = "Agregar" 
            });
            _loginService.Users.Add(new Usuario()
            {
                UserName = "Juan",
                Password = "hardcodeada",
                Permisos = "Visualizar"
            });
            _loginService.Users.Add(new Usuario()
            {
                UserName = "Marcos",
                Password = "hardcodeada",
                Permisos = "Ambos"
            });
        }

        private string _user;
        private string _password;
        private RelayCommand _showMenuPageAndVerifyCommand;
               
        public string User
        {
           get => _user;
           set => SetValue(ref _user, value);
        }     
        
        public string Password
        {
            get => _password;
            set => SetValue(ref _password, value);
        }
        public ICommand ShowMenuPageAndVerifyCommand => _showMenuPageAndVerifyCommand;

        private void PerformMenu()
        {
            foreach (var user in _loginService.Users)
            {
                if (_user == user.UserName)
                {                    
                    if (_password == "hardcodeada")
                    {
                        //Me falta Cambiar la vista según el tipo de permiso tenga el usuario
                        if (user.Permisos == "Visualizar")
                        {
                            new MainWindow().Show();
                            Close();
                        }
                        if (user.Permisos == "Agregar")
                        {
                            new MainWindow().Show();
                            Close();
                        }
                        else
                        {
                            new MainWindow().Show();
                            Close();
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Porfavor ingresa una contraseña que sea correcta", "¡Alerta!", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Introduce un Usuario valido");
                }
            }
        }
    }
}
