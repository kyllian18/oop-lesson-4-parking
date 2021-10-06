using System;
using System.Collections.Generic;
namespace ooplesson4parking.Models
{
    public class CarPark
    {
        private List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();

        public CarPark()
        {
        }

        public override string ToString()
        {
            return "I am the CarPark";
        }

        public void AddCustomer(Customer customer)
        {
            listOfCustomers.Add(customer);
        }

        public void CalculateCharges()
        {
            foreach (Customer customer in listOfCustomers)
            {
                decimal calulatedCharge = carParkCharge.CalculateCharge(customer.HoursParked);
                Console.WriteLine($"Calculating charge for customer: the cost is {calulatedCharge.ToString("0.##")} € for registration {customer.Registration}");
            }
        }
    }
}