using RonaApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RonaApp.Services
{
    public class PatientsService : IPatientsService
    {
        public List<Patient> Patients { get; private set; } = new List<Patient>();
      

}
