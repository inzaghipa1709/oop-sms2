using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore{
    class Program{
        static void Main(string[] args){
            EFDatabase.Start();
        }
    }
}