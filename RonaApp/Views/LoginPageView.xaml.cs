using RonaApp.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RonaApp.Views
{
    /// <summary>
    /// Lógica de interacción para LoginPageView.xaml
    /// </summary>
    public partial class LoginPageView : Page
    {
        public LoginPageView()
        {
            InitializeComponent();

            //Conectamos con el ViewModel del LoginPage que hemos creado

            DataContext = new LoginPageViewModel();
        }
    }
}
