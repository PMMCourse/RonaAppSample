using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services
{
    public interface IPatientsService
    {
        List<Patient> Patients { get; }
    }
}
