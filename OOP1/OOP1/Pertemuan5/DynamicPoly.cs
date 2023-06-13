using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan5
{
    // Base / Parent class
    public class Drawing
    {
        public virtual double Area(int constant)
        {
            return 0;
        }
    }

    // Inheritence / Child class
    public class Circle : Drawing
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 5;
        }
        public override double Area(int constant)
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    // Inheritence class
    public class Square : Drawing
    {
        public double Length { get; set; }
        public Square()
        {
            Length = 6;
        }
        public override double Area(int constant)
        {
            return Math.Pow(Length, 2);
        }
    }
}
