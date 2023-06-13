using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmdExprn
{
    internal class LinqPrgm
    {
        public static void Start()
        {
            int[] scores = {97, 92, 81, 60};

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}