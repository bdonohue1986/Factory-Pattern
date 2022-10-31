using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface ILocksmith
    {
        public void Opendoor();

        public void MakeKey();

        public void ChangeLock();
    }
}
