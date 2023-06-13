using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan6
{

    public class FileService 
    {        
        public void Run()
        {
            string pathFileName = @"C:\DATAKU\Contoh.txt";
            string text = File.ReadAllText(pathFileName);

            string data = "BBBBBBBBBBBB";
            File.AppendAllText(pathFileName, data);
        }
    }



}
