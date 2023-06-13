using System;

namespace Csharp{
    public class Program{
        public class CalculatorService //Class
        {
            public double A { get; set; } //Property
            public double B { get; set; } //Property

            public double Add() //Method
            {
                return A + B;
            }

            public double Subtract() //Method
            {
                return A - B;
            }

            public double Multiply() //Method
            {
                return A * B;
            }
            public double Divide() //Method
            {
                return A / B;
            }
        }

    class Kendaraan  // Base class
    {
        public string brand = "Honda";  // Field
        public void honk()             // Method 
        {
            Console.WriteLine("Brem, brem!");
        }
        class Mobil : Kendaraan  // Derived class
        {
            public string modelName = "Mobilio";  // Field
        }
    }

        public static void Main(string[] args){
            CalculatorService calculatorService = new CalculatorService(); //Constructor
            Console.WriteLine("Output :"); //Object: calculatorService

            calculatorService.A = 4.5; //Field
            calculatorService.B = 1.3; //Field

            Console.WriteLine(calculatorService.A);
            Console.WriteLine(calculatorService.B);

            double hasilPenjumlahan = calculatorService.Add();
            Console.WriteLine("\nHasil Penjumlahan :");
            Console.WriteLine(hasilPenjumlahan);
            double hasilPengurangan = calculatorService.Subtract();
            Console.WriteLine("\nHasil Pengurangan :");
            Console.WriteLine(hasilPengurangan);
            double hasilKali = calculatorService.Multiply();
            Console.WriteLine("\nHasil Perkalian :");    
            Console.WriteLine(hasilKali);
            double hasilBagi = calculatorService.Divide();
            Console.WriteLine("\nHasil Pembagian :");    
            Console.WriteLine(hasilBagi);

            //Membuat Objek
            Mobil myCar = new Mobil();
            //Memanggil method honk() (Dari Class Kendaraan) dalam objek myCar
            myCar.honk();
            //Menampilkan value dari brand field (Dari Class Kendaraan) dan juga nilai modelName dari kelas Mobil
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}