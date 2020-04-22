using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services
{
    public class VirusListService : IVirusListService
    {
        public List<Virus> Viruses { get; private set; } = new List<Virus>();
    }
}
