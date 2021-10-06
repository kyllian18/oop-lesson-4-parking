using System;
using System.Collections.Generic;
namespace ooplesson4parking.Models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();

        public CarPark()
        {
        }

        public override string ToString()
        {
            return "I am the CarPark";
        }

        public void CalculateCharges()
        {
            foreach (Customer customer in listOfCustomers)
            {
                int calulatedCharge = carParkCharge.CalculateCharge(customer.HoursParked);
                Console.WriteLine($"Calculating charge for customer: the cost is {calulatedCharge} € for registration {customer.Registration}");
            }
        }
    }
}