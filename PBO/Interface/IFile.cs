using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFile
    {
        public string FileName { get; set; }

        void ReadFile();
        void WriteFile(string text);
    }
}
