using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan11
{
    class Mahasiswa
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
    }

    internal class LambdaExpression1
    {
        public static void Start2()
        {
            IList<Mahasiswa> list = new List<Mahasiswa>();
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Umur = 20;
            mahasiswa.Nama = "Anton";
            list.Add(mahasiswa);

            mahasiswa = new Mahasiswa();
            mahasiswa.Umur = 21;
            mahasiswa.Nama = "Alex";
            list.Add(mahasiswa);

            mahasiswa = new Mahasiswa();
            mahasiswa.Umur = 18;
            mahasiswa.Nama = "Andi";
            list.Add(mahasiswa);

            IEnumerable<Mahasiswa> umurDiatas20 = list.Where(m => m.Umur > 20);
            IEnumerable<int> umurDiatas20SatuSaja = list.Select(m => m.Umur);

        }
        
        
        public static void Start()
        {
            Action<string> messageTarget = ShowWindowsMessage;

            Action<string, string> greet = (name, umur) =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };

            Func<int, int, bool> testForEquality = (x, y) => x == y;

            Func<int, int> square = x => x * x;
            var result = square(5);

            List<int> listData = new List<int>() { 2,3,3,4};
            var selectData = listData.Select(x => x - 1);

            Func<int, int, int> constant = (_, _) => 42;
        }

        public static async Task Start1Async()
        {
            Console.WriteLine("AAA");
            await ExampleMethodAsync();
            Console.WriteLine("BBB");

            var test = async () => { await ExampleMethodAsync(); };

            Console.WriteLine("CCC");
            await test();
            Console.WriteLine("DDD");

            (double, int, string) t1 = (4.5, 3, "AA");
            Console.WriteLine($"Tuple with elements {t1.Item3}" +
                $" and {t1.Item2}.");


            Func<(int, int, int), (int, int, int)> doubleThem =
                ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);

            (int, int, int) numbers = (2, 3, 4);
            (int, int, int) doubledNumbers = doubleThem(numbers);
            Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");


            //Func<(int n1, int n2, int n3), (int, int, int)> doubleThem =
            //    ns => (2 * ns.n1, 2 * ns.n2, 2 * ns.n3);
            //var numbers = (2, 3, 4);
            //var doubledNumbers = doubleThem(numbers);
            //Console.WriteLine($"The set {numbers} doubled: {doubledNumbers}");

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int jumlahNumbers = numbers.Count();

            //IList<int> genaps = numbers.Where(n => n % 2 == 0).ToList();
            //int jumlahGenap = genaps.Count();

            //int evenNumbers = numbers.Count(n => n % 2 == 0);

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var firstNumbersLessThanSix = numbers.TakeWhile(n => n < 6);
        }

        private static async Task ExampleMethodAsync()
        {
            // The following line simulates a
            // task-returning asynchronous process.
            await Task.Delay(5000);
        }

        private static void ShowWindowsMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
