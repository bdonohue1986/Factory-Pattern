using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class NewCaller
    {
        public static ILocksmith NewCust()
        {
            Console.WriteLine("Do you need service for you House, Car, Or Business");
            var response = Console.ReadLine();
            switch (response.ToLower())
            {
                case "house":
                    return new House();
                case "car":
                    return new Car();
                case "business":
                    return new Business();
                default:
                    return new Car();

            }
        }

    }
}
