﻿using RonaApp.Services;
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
        protected override void OnStartup(StartupEventArgs e)
        {
            Locator.Register<IVirusService>(new VirusService());
            Locator.Register<ILoginService>(new LoginService());
            Locator.Register<IPatientsService>(new PatientsService());
            base.OnStartup(e);
        }
    }
}
