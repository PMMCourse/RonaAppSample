using RonaApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace RonaApp.Views.Base
{
    public class BaseView : Window 
    {
        public BaseView()
        {
            this.Loaded += BaseLoaded;
        }

        private void BaseLoaded(object sender, RoutedEventArgs e)
        {
            ViewModel?.OnLoaded();
            ViewModel.RequestToClose += ViewModelRequestToClose;
        }

        private void ViewModelRequestToClose(object sender, EventArgs e)
        {
            this.Close();
        }

        BaseViewModel ViewModel
        {
            get => (BaseViewModel)DataContext;
        }

        public void Dispose()
        {
            this.Loaded -= BaseLoaded;
        }
    }
}
