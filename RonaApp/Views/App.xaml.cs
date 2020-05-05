using RonaApp.Services;
using RonaApp.Services.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RonaApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Convertir el metodo en asincrono para las llamadas a los servicios

        protected override async void OnStartup(StartupEventArgs e)
        {
            await Task.Run(() => { 
                Locator.Register<IPatientsService>(new PatientsService());
                Locator.Register<IUserService>(new UserService());
                Locator.Register<IVirusService>(new VirusService());
            });
            
            base.OnStartup(e);
        }
    }
}
