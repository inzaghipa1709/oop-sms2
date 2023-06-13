using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan7
{
    public class SimpleUnitTest
    {

        public static int Add(int A, int B)
        {
            try
            {

                if (A <= 0)
                {
                    throw new ArgumentException("Harus diatas 0");
                }

                return A + B;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }
    }
}
