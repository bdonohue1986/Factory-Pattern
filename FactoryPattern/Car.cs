using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : ILocksmith
    {
        public void Opendoor()
        {
            Console.WriteLine($"Opens Car door");
        }

        public void MakeKey()
        {
            Console.WriteLine($"Makes Car Key");
        }
        public void ChangeLock()
        {
            Console.WriteLine("Sorry we dont change locks on Cars.");
           
        }
    }
}
