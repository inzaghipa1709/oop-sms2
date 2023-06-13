using Newtonsoft.Json;
using OOP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan13
{
    [Serializable]  
    public class Siswa
    {
        public string Name { get; set; }
    }

    public class Lat1Clone
    {
        public static void Start()
        {

            Person person0 = new Person();
            person0.Nama = "AAA";
            person0.Email = "hhh@yahoo.com";
            person0.Siswa = new Siswa();
            person0.Siswa.Name = "BBBBB";

            Person person1 = (Person)person0.Clone();
            person1.Email = "AAAA@yahoo.com";
            person1.Siswa.Name = "VVVVV";


        }

        public static void StartCloneWithJson()
        {

            Person person0 = new Person();
            person0.Nama = "AAA";
            person0.Email = "hhh@yahoo.com";
            person0.Siswa = new Siswa();
            person0.Siswa.Name = "BBBBB";

            // Deep Copy
            string jsonData = JsonConvert.SerializeObject(person0);
            Person person1 = JsonConvert.DeserializeObject<Person>(jsonData);

            person1.Email = "AAAA@yahoo.com";
            person1.Siswa.Name = "VVVVV";


        }

        public static void StartCloneWithConstructor()
        {
            Person person0 = new Person();
            person0.Nama = "AAA";
            person0.Email = "hhh@yahoo.com";
            person0.Siswa = new Siswa();
            person0.Siswa.Name = "BBBBB";

            Person person1 = new Person(person0);
            person1.Email = "AAAA@yahoo.com";
            person1.Siswa.Name = "VVVVV";
        }


        public static void StartCloneWithXml()
        {
            Person person0 = new Person();
            person0.Nama = "AAA";
            person0.Email = "hhh@yahoo.com";
            person0.Siswa = new Siswa();
            person0.Siswa.Name = "BBBBB";

            // Deep copy
            string xmlData = SerializeHelper.SeralizeObjectToXML<Person>(person0);
            Person person1 = SerializeHelper.DeserializeXML<Person>(xmlData);
            person1.Email = "AAAA@yahoo.com";
            person1.Siswa.Name = "VVVVV";
        }
    }
}
