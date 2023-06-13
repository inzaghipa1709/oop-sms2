using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan6
{

    public class ExplicitFileInfo : IFile
    {        
        public string FileName { get; set; }

        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }

        public void Search()
        {
            Console.WriteLine("Search File");
        }


    }

}
