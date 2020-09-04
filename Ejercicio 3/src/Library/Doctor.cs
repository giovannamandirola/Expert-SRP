using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Name { get ; }
        public string Especialidad { get ; }
        public Doctor(String name, String especialidad)
        {
            this.Name = name;
            this.Especialidad = especialidad;
        }
        
    }
}