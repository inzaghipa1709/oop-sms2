using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan10
{
    public class ListLat1
    {

        public static List<int> MyIntegerNumbers { get; set; } = new List<int>();
        public static List<string> MyStrings { get; set; } = new List<string>();
        static string[] Animals = { "Cow", "Camel", "Elephant", "Bird" };

        public static void Introduce()
        {
            //MyIntegerNumbers.Add(1);
            //MyIntegerNumbers.Add(21);

            MyStrings.Add("AAA");
            MyStrings.Add("BBB");
            MyStrings.AddRange(Animals);
            MyStrings.Insert(3, "Ini index ke tiga");

            string[] transportations = { "Car", "Bus", "Plane" };
            MyStrings.InsertRange(2, transportations);

            for (int i = 0; i < MyStrings.Count; i++)
            {
                Console.WriteLine("Index " + i + " :" + MyStrings[i]);
            }

            //foreach (var item in MyStrings)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(MyStrings[2]);
            //Console.WriteLine(MyStrings.Count);
            //Console.WriteLine(MyStrings.Capacity);
        }



        public static void Remove()
        {
            MyStrings.AddRange(Animals);
            MyStrings.RemoveRange(3, 2);
            MyStrings.Remove("Camel");
            MyStrings.RemoveAt(1);
            MyStrings.Clear();
        }

        public static void FindElement()
        {
            MyStrings.AddRange(Animals);
            int result = MyStrings.IndexOf("Camel");
            if (result == -1)
            {

            }
            else
            {

            }

            int resultStartPosition = MyStrings.IndexOf("Bird", 4);
            int resultEndPosition = MyStrings.LastIndexOf("Bird");


            for (int i = 0; i < MyStrings.Count; i++)
            {
                Console.WriteLine("Index " + i + " :" + MyStrings[i]);
            }

            MyStrings.Sort();
            int foundIndex = MyStrings.BinarySearch("Camel");
            for (int i = 0; i < MyStrings.Count; i++)
            {
                Console.WriteLine("Index " + i + " :" + MyStrings[i]);
            }


            MyStrings.Reverse();
            for (int i = 0; i < MyStrings.Count; i++)
            {
                Console.WriteLine("Index " + i + " :" + MyStrings[i]);
            }


            string[] transportations = { "Car", "Bus", "Plane" };
            List<string> newList = new List<string>(transportations);
            
            //MyStrings.AddRange(newList);

            // How to add newList to MyStrings, without AddRange
            foreach (var item in newList)
            {
                MyStrings.Add(item);
            }
        }



    }
}
