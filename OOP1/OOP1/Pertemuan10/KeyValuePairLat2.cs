using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan10
{
    public class KeyValuePairLat2
    {
        static Dictionary<int, string> MyDictionary = new Dictionary<int, string>();
        static List<KeyValuePair<int, string>> KeyValuePairs { get; set; }
        static KeyValuePair<int, string> KeyValuePair { get; set; }

        public static void Start()
        {
            KeyValuePair = new KeyValuePair<int, string>(2, "Nomer 2");
            string value = KeyValuePair.Value;
            int key = KeyValuePair.Key;

            KeyValuePairs = new List<KeyValuePair<int, string>>();
            KeyValuePairs.Add(KeyValuePair);

            KeyValuePair = new KeyValuePair<int, string>(2, "Nomer 3");
            KeyValuePairs.Add(KeyValuePair);

            int index = KeyValuePairs.IndexOf(KeyValuePair);

            MyDictionary.Add(1,"HALO");
            MyDictionary.Add(2, "TEST");

            var myResult = KeyValuePairs.Where(a=> a.Key == 2);
        }

    }
}
