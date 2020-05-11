using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using RonaApp.Model;


namespace RonaApp.Services
{
    public class UserService : IUserService
    {
        public List<User> usuarios { get; private set; } = new List<User>();
        
        public UserService()
        {
            usuarios.Add(new User { username = "Fran", passwd = "123", rol = "rw" });
            usuarios.Add(new User { username = "Chema", passwd = "1234", rol = "w" });
            usuarios.Add(new User { username = "Otro", passwd = "1234", rol = "r" });
        }
        
       

    }
}
