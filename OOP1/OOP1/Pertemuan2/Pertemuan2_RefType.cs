
using OOP1.Models;


namespace OOP1
{
    public class Pertemuan2_RefType
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


        public void Main2()
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.ID = 1;
            mahasiswa.Nama = "Andi";

            ChangeValue(mahasiswa);

        }

        public void ChangeValue(Mahasiswa mahasiswa)
        {
            mahasiswa.Nama = "Andi Cahyono";
        }

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


}
