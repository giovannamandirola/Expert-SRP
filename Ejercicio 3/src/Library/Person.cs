using System;
using System.Text;

namespace Library
{
    public class Person
    {
        public string Name { get ; }
        public string Ci { get ; }
        public string Id { get ; }
        public string PhoneNumber { get ; set; }
        public Person(String name, String ci, String id, String phoneNumber)
        {
            this.Name = name;
            this.Ci = ci;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }
        
    }
}