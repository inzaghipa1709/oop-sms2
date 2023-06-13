using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFile fileInfo = new MyFileInfo();

            fileInfo.WriteFile("aaa");

            MyFileInfo myFileInfo = (MyFileInfo)fileInfo;
            myFileInfo.Search();

            //IFile fileInfo1 = new MyFileInfo();
            //MyFileInfo fileInfo2 = new MyFileInfo();


        }
    }
}