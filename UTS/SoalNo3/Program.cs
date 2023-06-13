using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalNo3
{
    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Hello World!");

            Console.WriteLine("Value Type : ");
            ValueType value = new ValueType();
            value.Main1();

            Console.WriteLine("Reference Type : ");
            ReferenceType ref = new ReferenceType();
            ref.Main2();

            Console.WriteLine("Static : ");
            Static x = new Static();
            int newval = x.calculation(12,12);
            Console.WriteLine(newval);
            Console.ReadKey();

            Console.WriteLine("Non-Static : ");
            Console.WriteLine(calculation(12,12));
            Console.ReadKey();
        }
    }
}