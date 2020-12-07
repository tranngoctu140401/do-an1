using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.Entities
{
    class ThietBi
    {
        private string tenthietbi;
        private string madasudung;
        public ThietBi()
        {
            
        }
        public ThietBi(string tenthietbi,string madasudung)
        {
            this.tenthietbi = tenthietbi;
            this.madasudung = madasudung;
        }
        public ThietBi(string tenthietbi)
        {
            this.tenthietbi = tenthietbi;
            madasudung = "";
        }
        override
            public string ToString()
        {
            return tenthietbi + "#" + madasudung;
        }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public string Madasudung { get => madasudung; set => madasudung = value; }
    }
}
