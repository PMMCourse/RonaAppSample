using RonaApp.Model;
using RonaApp.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services
{
    public class VirusService : IVirusService
    {
        public List<Virus> AllVirus { get; } = new List<Virus>();
    }
}
