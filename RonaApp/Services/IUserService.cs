using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services
{
    public interface IUserService
    {
        List<User> usuarios { get; }
    }
}
