using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Pertemuan2_Value
    {
        public void Main()
        {
            double i = 100.3;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);
        }

        public void ChangeValue(double x)
        {
            x = 200.4;
            Console.WriteLine(x);
        }
    }


}
