using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan9
{
    internal class Lat0SingleThreading
    {       
        static public void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 1 :" + i.ToString());
                Thread.Sleep(500);
            }
        }

        static public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2 :" + i.ToString());
                Thread.Sleep(5000);
            }
        }

    }
}
