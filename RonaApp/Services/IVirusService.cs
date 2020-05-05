using RonaApp.Model;
using System.Collections.Generic;
using System;
using System.Text;
using System.Collections.ObjectModel;

namespace RonaApp.Services
{
    public interface IVirusService
    {
        
        List<Virus> ListaVirus { get; }
    }
}