using System;
using ooplesson4parking.Models;
namespace ooplesson4parking.Test
{
    public class Driver
    {
        public Driver()
        {
        }

        public void CreateObjects()
        {
            CarPark carPark = new CarPark();

            carPark.listOfCustomers.Add(new Customer("a", 2));
            carPark.listOfCustomers.Add(new Customer("b", 3));
            carPark.listOfCustomers.Add(new Customer("c", 4));
            carPark.listOfCustomers.Add(new Customer("d", 5));
            carPark.listOfCustomers.Add(new Customer("e", 6));
            carPark.listOfCustomers.Add(new Customer("f", 7));

            carPark.CalculateCharges();

            Customer customer = new Customer("g", 8);
            CarParkCharge carParkCharge = new CarParkCharge();

            // Call the ToString Method
            Console.WriteLine(carPark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carParkCharge.ToString());
        }
    }
}