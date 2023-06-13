using System;
using System.Net;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //SingleThread.Method1();
            //SingleThread.Method2();

            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Inline Task : "+i.ToString());
                    Thread.Sleep(1500);
                }
            });

            Task.Run(TaskLat.Method1);
        }
    }
}