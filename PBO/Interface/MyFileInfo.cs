using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public class MyFileInfo : IFile, IBinaryFile
    {
        
        public string FileName { get; set; }

        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }

        public void Search()
        {
            Console.WriteLine("Search File");
        }

        public void ReadBinaryFile()
        {
            Console.WriteLine("ReadBinaryFile");
        }

        public void WriteBinaryFile(string text)
        {
            Console.WriteLine("WriteBinaryFile");
        }
    }
}