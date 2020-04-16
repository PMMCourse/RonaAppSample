using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Pass { get; set; }
        public Boolean PermisoAgregar { get; set; }
        public Boolean PermisoVisualizar { get; set; }

        public Usuario(string username, string pass, bool permisoAgregar, bool permisoVisualizar)
        {
            Username = username;
            Pass = pass;
            PermisoAgregar = permisoAgregar;
            PermisoVisualizar = permisoVisualizar;
        }
    }
}
