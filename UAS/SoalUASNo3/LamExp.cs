//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SoalUASNo3{
//    public class LamExp{
//        static void Main(string[] args){
//            List<int> numbers = new List<int>() {36, 71, 12,
//                                15, 29, 18, 27, 17, 9, 34};
    
//            Console.Write("Lists : ");
//            foreach(var value in numbers)
//            {
//                Console.Write("{0} ", value);
//            }
//            Console.WriteLine();
    
//            var square = numbers.Select(x => x * x);
    
//            Console.Write("Squares : ");
//            foreach(var value in square)
//            {
//                Console.Write("{0} ", value);
//            }
//            Console.WriteLine();
    
//            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);
    
//            Console.Write("Numbers Divisible by 3 : ");
//            foreach(var value in divBy3)
//            {
//                Console.Write("{0} ", value);
//            }
//            Console.WriteLine();
//        }
//    }
//}