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

            carPark.AddCustomer(new Customer("a", 2));
            carPark.AddCustomer(new Customer("b", 3));
            carPark.AddCustomer(new Customer("c", 4));
            carPark.AddCustomer(new Customer("d", 5));
            carPark.AddCustomer(new Customer("e", 6));
            carPark.AddCustomer(new Customer("f", 7));

            carPark.CalculateCharges();

            Customer customer = new Customer("g", 8);
            CarParkCharge carParkCharge = new CarParkCharge();

            // Call the ToString Method
            //Console.WriteLine(carPark.ToString());
            //Console.WriteLine(customer.ToString());
            //Console.WriteLine(carParkCharge.ToString());
        }
    }
}