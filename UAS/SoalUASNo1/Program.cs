using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalUASNo1{
    public class Multithread {
        public static void method1(){
    
            for (int I = 0; I <= 10; I++) {
    
                Console.WriteLine("Method1 adalah : {0}", I);

                if (I == 5) {
                    Thread.Sleep(6000);
                }
            }
        }

        public static void method2(){
        
            for (int J = 0; J <= 10; J++) {
        
                Console.WriteLine("Method2 adalah : {0}", J);
            }
        }
    }

    public class Program{
        public static void Main(string[] args){
            Multithread.method1();
            Multithread.method2();
        }
    }
}