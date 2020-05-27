using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Model
{
    public class Patient : Person
    {
        
        public Virus VirusAffected { get; set; }

        DateTime tiempoRegistro = 0;
        TimeSpan intervalo = tiempoRegistro;

        public Patient(Virus virusAffected, DateTime TiempoRegistro)
        {
            this.VirusAffected = virusAffected;
            this.tiempoRegistro =TiempoRegistro;
            this.intervalo = TiempoRegistro;

        }
        public Patient()
        {

        }
        public TimeSpan valorPacientes()
        {
            Console.WriteLine("{0,-35},{1,20}", "Value of Minutes Component: ", intervalo.Minutes);
        }
    }
}
