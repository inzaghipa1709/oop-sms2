using System;

namespace OOPExample{
    public class RefType
    {
        public void Main1()
        {
            IList<double> myList = new List<double>() { 1.2, 2.3, 4.5 };
            
            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }
            Changevalue(myList);

            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Changevalue(IList<double> myList)
        {
            myList[1] = 3.3;
        }


        //public void Main2()
        //{
        //    Mahasiswa mahasiswa = new Mahasiswa();
        //    mahasiswa.ID = 1;
        //    mahasiswa.Nama = "Andi";

        //    ChangeValue(mahasiswa);
        //}

        //public void ChangeValue(Mahasiswa mahasiswa)
        //{
        //    mahasiswa.Nama = "Andi Cahyono";
        //}

        public void Main3()
        {
            int? nilai = null;

            string myName = "Budi";

            ChangeValue(myName);

            string myValue = myName;

        }

        public void ChangeValue(string nama)
        {
            nama = "Andi Cahyono";
        }
    }

    public class StaticNonStatic
    {
        public static int MyStaticData = 3;
        public int MyNonStaticData = 1;
        public void Run()
        {
            Console.WriteLine("MyStaticData: " + MyStaticData);
            Console.WriteLine("MyNonStaticData: " + MyNonStaticData);
        }

        public static void MyStaticMethod()
        {
            StaticNonStatic.MyStaticData = 9;
        }
    }

    public class AccessStaticData
    {
        public void Run()
        {
            StaticNonStatic.MyStaticMethod();
            StaticNonStatic StaticNonStatic = new StaticNonStatic();
            StaticNonStatic.Run();
        }
    }

    public class Value
    {
        public void Main4()
        {
            double i = 100.3;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);
        }

        public void ChangeValue(double x)
        {
            x = 200.4;
            Console.WriteLine(x);
        }
    }

    public class Program{
        public static void Main(string[] args){
            Console.WriteLine("Hello World!");

            RefType obj = new RefType();
            obj.Main3();
            Value Value = new Value();
            Value.Main4();
            AccessStaticData AccessStaticData = new AccessStaticData();
            AccessStaticData.Run();

        }
    }
}