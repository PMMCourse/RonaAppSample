using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace RonaApp.ViewModel.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event EventHandler RequestToClose;

        public BaseViewModel()
        {
            InitCommands();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }      
        }

        public virtual void OnLoaded()
        { }

        public virtual void Close()
        {
            RequestToClose?.Invoke(this, new EventArgs());
        }

        protected void SetValue<T>(ref T backingField , T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return;
            }
            backingField = value;
            RaisePropertyChanged(propertyName);
        }

        protected abstract void InitCommands();


    }
}
