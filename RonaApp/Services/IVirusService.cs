using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services.Base
{
    public interface IVirusService
    {
        List<Virus> AllVirus { get; }
    }
}
