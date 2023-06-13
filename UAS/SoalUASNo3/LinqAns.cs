using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalUASNo3{
    public class LinqAns{
        public static void Main(string[] args){
            string[] names = {"Inzaghi", "Hendra", "Steven", "Rizki"};
            
            var myLinqQuery =  from name in names
                            where name.Contains('a')
                            select name;
                
            foreach (var name in myLinqQuery)
            Console.Write(name + " ");
        }
    }
}