using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Pertemuan4
{
    public class RodaEmpat: Kendaraan
    {
        public string RodaEmpatInfo1 { get; set; }
        protected internal string RodaEmpatInfo2 { get; set; }
        protected string RodaEmpatInfo3 { get; set; }
        internal string RodaEmpatInfo4 { get; set; }
        private protected string RodaEmpatInfo5 { get; set; }
        private string RodaEmpatInfo6 { get; set; }

        public void Jalan()
        {
            string rodaEmpat1 = KendaraanInfo1;
            string rodaEmpat2 = KendaraanInfo2;
            string rodaEmpat3 = KendaraanInfo3;
            //string rodaEmpat4 = KendaraanInfo4;
            //string rodaEmpat5 = KendaraanInfo5;
            //string rodaEmpat6 = KendaraanInfo6;
        }

    }
}
