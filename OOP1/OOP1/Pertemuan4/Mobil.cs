using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan4
{
    public class Mobil: RodaEmpat
    {
        public string MobilInfo1 { get; set; }
        protected internal string MobilInfo2 { get; set; }
        protected string MobilInfo3 { get; set; }
        internal string MobilInfo4 { get; set; }
        private protected string MobilInfo5 { get; set; }
        private string MobilInfo6 { get; set; }

        public void Jalan()
        {
            string test1 = MobilInfo1;
            string test2 = MobilInfo2;
            string test3 = MobilInfo3;
            string test4 = MobilInfo4;  
            string test5 = MobilInfo5;
            string test6 = MobilInfo6;

            string rodaEmpat1 = RodaEmpatInfo1;
            string rodaEmpat2 = RodaEmpatInfo2;
            string rodaEmpat3 = RodaEmpatInfo3;
            string rodaEmpat4 = RodaEmpatInfo4;
            string rodaEmpat5 = RodaEmpatInfo5;
            //string rodaEmpat6 = RodaEmpatInfo6;
        }
    }
}
