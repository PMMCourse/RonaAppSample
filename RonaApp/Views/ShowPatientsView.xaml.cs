using RonaApp.Model;
using RonaApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace RonaApp.Views
{
    /// <summary>D:\Projects\Fesac\MVVMRona\RonaApp\RonaApp\Views\ShowPatientsView.xaml.cs
    /// Interaction logic for ShowPatientsView.xaml
    /// </summary>
    public partial class ShowPatientsView
    {
        public ShowPatientsView()
        {
            InitializeComponent();
            DataContext = new ShowPatientsViewModel();

        }

    }
}
