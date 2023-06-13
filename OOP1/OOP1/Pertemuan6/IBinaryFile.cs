using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan6
{
    interface IBinaryFile
    {
        public string FileName { get; set; }

        void ReadBinaryFile();
        void WriteBinaryFile(string text);
    }


}
