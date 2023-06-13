//using System;

//namespace Csharp{
//    public class Calculator{
//        public class CalculatorService
//        {
//            public double A { get; set; }
//            public double B { get; set; }

//            public double Add()
//            {
//                return A + B;
//            }

//            public double Subtract()
//            {
//                return A - B;
//            }

//            public double Multiply()
//            {
//                return A * B;
//            }
//            public double Divide()
//            {
//                return A / B;
//            }
//        }

//        public static void Main(string[] args){
//            CalculatorService calculatorService = new CalculatorService();
//            Console.WriteLine("Output :");

//            calculatorService.A = 4.5;
//            calculatorService.B = 1.3;

//            Console.WriteLine(calculatorService.A);
//            Console.WriteLine(calculatorService.B);
//
//            double hasilPenjumlahan = calculatorService.Add();
//            Console.WriteLine("\nHasil Penjumlahan :");
//            Console.WriteLine(hasilPenjumlahan);
//            double hasilPengurangan = calculatorService.Subtract();
//            Console.WriteLine("\nHasil Pengurangan :");
//            Console.WriteLine(hasilPengurangan);
//            double hasilKali = calculatorService.Multiply();
//            Console.WriteLine("\nHasil Perkalian :");    
//            Console.WriteLine(hasilKali);
//            double hasilBagi = calculatorService.Divide();
//            Console.WriteLine("\nHasil Pembagian :");    
//            Console.WriteLine(hasilBagi);
//        }
//    }
//}