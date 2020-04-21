using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{
    public class Usuario
    {
        //Ejercicio 4
        public string User { get; set; }
        public string Password { get; set; }
        public string Permisos { get; set; } //Los permisos son cadenas de texto y a la hora de verificar la contraseña, se comparará si se trata de un permiso u otro.
    }
}
