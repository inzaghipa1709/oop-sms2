using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan5
{
    public class BaseClass
    {
        public virtual string GetMethodOwnerName()
        {
            return "Base Class";
        }
    }
    public class ChildClass : BaseClass
    {
        public new virtual string GetMethodOwnerName()
        {
            return "ChildClass";
        }
    }
    public class SecondChild : ChildClass
    {
        public override string GetMethodOwnerName()
        {
            return "Second level Child";
        }
    }

}
