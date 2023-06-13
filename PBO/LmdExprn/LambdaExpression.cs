using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmdExprn
{
    class Mahasiswa
    {
        public string Nama { get; set; }
        public int Umur { get; set; }
    }

    internal class LambdaExpression
    {
        //public static void Start2()
        //{
        //    IList<Mahasiswa> list = new List<Mahasiswa>();
        //    Mahasiswa mahasiswa = new Mahasiswa();
        //    mahasiswa.Umur = 20;
        //    mahasiswa.Nama = "Anton";
        //    list.Add(mahasiswa);

        //    mahasiswa = new Mahasiswa();
        //    mahasiswa.Umur = 21;
        //    mahasiswa.Nama = "Alex";
        //    list.Add(mahasiswa);

        //    mahasiswa = new Mahasiswa();
        //    mahasiswa.Umur = 18;
        //    mahasiswa.Nama = "Andi";
        //    list.Add(mahasiswa);

        //    IEnumerable<Mahasiswa> umurDiatas20 = list.Where(m => m.Umur > 20);
        //    IEnumerable<int> umurDiatas20SatuSaja = list.Select(m => m.Umur);
        //}
        
        public static void Start()
        {
            Action<string> messageTarget = ShowWindowsMessage;

            Action<string, string> greet = (nama, umur) =>
            {
                string greeting = $"Hello {nama}!";
                Console.WriteLine(greeting);
            };

            Func<int, int, bool> testForEquality = (x, y) => x == y;

            Func<int, int> square = x => x * x;
            var result = square(5);

            List<int> listData = new List<int>() { 2,3,3,4};
            var selectData = listData.Select(x => x - 1);
        }

        private static void ShowWindowsMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
