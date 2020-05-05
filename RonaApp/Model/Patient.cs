using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{
    public class Patient : Person
    {
        
        public Virus VirusAffected { get; set; }
        public int tiempoRegistro { get; set; }
    }
}
