using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Pertemuan2_StaticNonStatic
    {
        public static int MyStaticData = 3;
        public int MyNonStaticData = 1;
        public void Run()
        {
            Console.WriteLine("MyStaticData: " + MyStaticData);
            Console.WriteLine("MyNonStaticData: " + MyNonStaticData);
        }

        public static void MyStaticMethod()
        {
            Pertemuan2_StaticNonStatic.MyStaticData = 9;
        }
    }


    public class Pertemuan2_AccessStaticData
    {
        public void Run()
        {
            Pertemuan2_StaticNonStatic.MyStaticMethod();
            Pertemuan2_StaticNonStatic pertemuan2_StaticNonStatic = new Pertemuan2_StaticNonStatic();
            pertemuan2_StaticNonStatic.Run();
        }
    }

}
