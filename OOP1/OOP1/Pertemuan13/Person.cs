using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OOP1.Pertemuan13
{
    [Serializable]
    public class Person: ICloneable
    {
        public Person()
        { 
        }

        public Person(Person person)
        {
            ID = person.ID;
            Nama = person.Nama;
            Email = person.Email;
        }

        public int ID { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public Siswa Siswa { get; set; }

        // Swallow Copy
        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        // Deep copy
        public object Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Position = 0;
            object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }


    static public class SerializeHelper
    {
        //Michael White, Holly Springs Consulting, 2009
        //michael@hollyspringsconsulting.com
        public static T DeserializeXML<T>(string xmlData)
            where T : new()
        {
            if (string.IsNullOrEmpty(xmlData))
                return default(T);

            TextReader tr = new StringReader(xmlData);
            T DocItms = new T();
            XmlSerializer xms = new XmlSerializer(DocItms.GetType());
            DocItms = (T)xms.Deserialize(tr);

            return DocItms == null ? default(T) : DocItms;
        }

        public static string SeralizeObjectToXML<T>(T xmlObject)
        {
            StringBuilder sbTR = new StringBuilder();
            XmlSerializer xmsTR = new XmlSerializer(xmlObject.GetType());
            XmlWriterSettings xwsTR = new XmlWriterSettings();

            XmlWriter xmwTR = XmlWriter.Create(sbTR, xwsTR);
            xmsTR.Serialize(xmwTR, xmlObject);

            return sbTR.ToString();
        }

        public static T CloneObject<T>(T objClone)
            where T : new()
        {
            string GetString = SerializeHelper.SeralizeObjectToXML<T>(objClone);
            return SerializeHelper.DeserializeXML<T>(GetString);
        }
    }
}
