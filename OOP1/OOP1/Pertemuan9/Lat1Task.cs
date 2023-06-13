using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan9
{
    public class Lat1Task
    {
        async static public void Method1()
        {
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Loop : {0}",
                    J.ToString());
                Thread.Sleep(1500);
            }
        }

        public static async Task RunAsync()
        {
            await Task.Run(() => { Method1(); } );
        }
    }
}
