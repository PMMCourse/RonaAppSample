using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RonaApp.Services
{
    public class VirusService : IVirusService
    {
       
        public List<Virus> ListaVirus { get; private set; } = new List<Virus>();

        public VirusService()
        {
            ListaVirus.Add(new Virus { Name = "Covid" });
            ListaVirus.Add(new Virus { Name = "Flu" });
            ListaVirus.Add(new Virus { Name = "GripeA" });
        }
    }
}
