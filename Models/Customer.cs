using System;
namespace ooplesson4parking.Models
{
    public class Customer
    {
        public string Registration { get; set; }

        public int HoursParked { get; set; }

        public Customer(string _registration, int _hoursParked)
        {
            Registration = _registration;
            HoursParked = _hoursParked;
        }

        public override string ToString()
        {
            return "I am the Customer";
        }
    }
}