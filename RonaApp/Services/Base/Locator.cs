using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services.Base
{
    public static class Locator
    {
        private static Dictionary<Type, object> _serviceLocator = new Dictionary<Type, object>();

        public static void Register<T>(object implentation)
        {
            _serviceLocator[typeof(T)] = implentation;
        }

        public static T Load<T>()
        {
            return (T)_serviceLocator[typeof(T)];
        }
    }
}
