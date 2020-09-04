using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public Appointment Appointment { get ; set; }
        public Doctor Doctor { get ; set; }
        public Person Person { get ; set; }
        
        public string CreateAppointment (Appointment appointment, Doctor doctor, Person person)
        {
            AppointmentService a= new AppointmentService();
            StringBuilder stringBuilder = new StringBuilder();
            this.Appointment = appointment;
            this.Doctor = doctor;
            this.Person = person;
            return stringBuilder.Append("Appoinment Scheduled").ToString();

        }

    }
}
