using RonaApp.ViewModel;
using RonaApp.Views.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RonaApp.Views
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
    }
}
