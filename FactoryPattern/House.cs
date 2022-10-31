using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class House : ILocksmith
    {
        public void Opendoor()
        {
            Console.WriteLine($"Opens house door at ");
        }

        public void MakeKey()
        {
            Console.WriteLine($"Makes House Key");
        }
        public void ChangeLock()
        {
            Console.WriteLine("How Many Locks would you like changed");
            var answer = Console.ReadLine();
           Console.WriteLine($"{answer} Locks to be changed no problem");
        }
    }
}
