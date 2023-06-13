//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Multithreading
//{
//    internal class Multithread
//    {
//        public static bool IsCanceledThr1 { get; set; }

//        public static void Method1()
//        {
//            for (int I = 0; I <= 10; I++)
//            {
//                if (IsCanceledThr1) return;
//
//                try
//                {
//                    Console.WriteLine(Thread.CurrentThread.Name + " : {0}", I);
//                    Thread.Sleep(1500);

//                    if (I == 5)
//                    {
//                        Console.WriteLine("Sleep 6 sceond ====");
//                        Thread.Sleep(6000);
//                    }
//                }
//                catch (Exception e)
//                {
//                }
//            }
//        }

//        public static void Method2()
//        {
//            for (int J = 0; J <= 10; J++)
//            {
//                Console.WriteLine(Thread.CurrentThread.Name + " : {0}", J);
//                Thread.Sleep(1500);
//            }
//        }

//        static public void Run()
//        {
//            Thread thr1 = new Thread(Method1);
//            Thread thr2 = new Thread(Method2);

//            thr1.Priority = ThreadPriority.Lowest;
//            thr2.Priority = ThreadPriority.Highest;

//            Console.WriteLine("ThreadState of TR1 thread" +
//                             " is: {0}", thr1.ThreadState);
//            Console.WriteLine("ThreadState of TR2 thread" +
//                             " is: {0}", thr2.ThreadState);


//            thr1.Start();
//            thr1.Name = "thr1";

//            thr2.Start();
//            thr2.Name = "thr2";


//            Console.WriteLine("ThreadState of TR1 thread" +
//                             " is: {0}", thr1.ThreadState);
//            Console.WriteLine("ThreadState of TR2 thread" +
//                             " is: {0}", thr2.ThreadState);

//            Thread.Sleep(3000);
//            Console.WriteLine("thr1 is abort");
//            IsCanceledThr1 = true;

//            Thread.Sleep(3000);
//            Console.WriteLine("Is thread 1 is alive : {0}", thr1.IsAlive);
//            Console.WriteLine("Is thread 2 is alive : {0}", thr2.IsAlive);

//            Console.WriteLine("ThreadState of TR1 thread" +
//                             " is: {0}", thr1.ThreadState);
//            Console.WriteLine("ThreadState of TR2 thread" +
//                             " is: {0}", thr2.ThreadState);
//        }
//    }
//}