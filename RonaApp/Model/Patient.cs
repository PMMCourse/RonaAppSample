using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{
    public class Patient : Person
    {
        
        public Virus VirusAffected { get; set; }

        public DateTime horaEntrada { get; set; }

        public TimeSpan tiempoRegistro { get; set; }
        public string tiempoFormato {
            get { return (string) tiempoRegistro.ToString(@"hh\:mm"); }
        }
    }
}
