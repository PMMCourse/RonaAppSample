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
        }

        BaseViewModel ViewModel
        {
            get;
        }

        public void Dispose()
        {
            this.Loaded -= BaseLoaded;
        }
    }
}
