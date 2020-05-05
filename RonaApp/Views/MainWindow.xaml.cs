using RonaApp.ViewModel;
using RonaApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RonaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            //MessageBox.Show(UserRol.Permiso);
            switch (UserRol.Permiso)
            {
                case "r": 
                    BotonRegistro.IsEnabled=false;
                    break;
                case "w":
                    BotonLista.IsEnabled = false;
                    break;
            }
            
        }
        //Ejer1: He añadido el metodo .Click al boton, para que abra la siguiente vista.
        private void abrirvistaregistro(object sender, RoutedEventArgs e)
        {
            Views.RegisterPatientView VistaRegistro = new Views.RegisterPatientView();
            VistaRegistro.Show();
        }
        //Ejer1: He añadido el metodo .Click al boton, para que abra la siguiente vista.
        private void abrirvistapacientes(object sender, RoutedEventArgs e)
        {
            Views.ShowPatientsView MostrarPacientes = new Views.ShowPatientsView();
           MostrarPacientes.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            UserRol.Permiso = "";
            LoginView Login = new LoginView();
            Login.Show();
            Close();
        }
    }
}
