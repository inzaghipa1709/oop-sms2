using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan11
{
    internal class Linq1
    {
        public static void Start()
        {
            int[] numbers = {2,3,4,5,5,5,5,3 };
            var lowNums = from num in numbers
                          where num < 5
                          select num;


            var studentQuery2 =
                from number in numbers
                group number by number into g
                orderby g.Key
                select g;
        }
    }
}
