using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services
{
    public class LoginService : ILoginService
    {
        public List<Usuario> Users { get; private set; } = new List<Usuario>();        
    }
}
