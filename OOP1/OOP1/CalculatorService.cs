using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class CalculatorService
    {
        public double A { get; set; }
        public double B { get; set; }

        public double Add() // Kata kerja
        {
            return A + B;
        }

        public double Subtract() 
        {
            return A - B;
        }

        public double Multiply()
        {
            return A * B;
        }
    }
}
