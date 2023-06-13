using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan5
{
    public class X
    {
        public virtual int A()
        {
            return 10;
        }
    }
    public class Y : X
    {
        public override int A()
        {
            return 20;
        }

        public int AccessMyMethodThenAccessBaseMethod()
        {
            return A() + base.A();
        }
    }
}
