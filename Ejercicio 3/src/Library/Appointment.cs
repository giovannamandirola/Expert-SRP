using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public String Fecha { get ; set; }
        public string Lugar { get ; set; }
        public Appointment(String fecha, String lugar)
        {
            this.Fecha = fecha;
            this.Lugar = lugar;
        }

    }
}        
