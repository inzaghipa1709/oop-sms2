using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Excptn{
    public class Program{
        public static void Main(string[] args){
            try
            {

                TryCatch.DoBilling(null, "AAA");
            }
            catch (Exception e)
            {

                Console.WriteLine("Jalan saja");
            }

            int result = SimpleUnitTest.Add(0, 2);
            int result1 = result;
        }
    }
}