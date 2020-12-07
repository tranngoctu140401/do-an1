using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.Entities
{
    class KhoaBanQuyen
    {
        private string makhoa, tenkhoa, theloai,ngaynhap,errorcode;
        private int soluotkichhoat;
        public KhoaBanQuyen()
        {

        }
        public KhoaBanQuyen(string makhoa,string tenkhoa,string theloai,int soluotkichhoat,string ngaynhap,string errorcode)
        {
            this.makhoa = makhoa;
            this.tenkhoa = tenkhoa;
            this.theloai = theloai;
            this.soluotkichhoat = soluotkichhoat;
            this.ngaynhap = ngaynhap;
            this.errorcode = errorcode;
        }
        override
            public string ToString()
        {
            return makhoa + "#" + tenkhoa + "#" + theloai + "#" + soluotkichhoat+"#"+ngaynhap+"#"+errorcode;
        }
        public string Makhoa { get => makhoa; set => makhoa = value; }
        public string Tenkhoa { get => tenkhoa; set => tenkhoa = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public int Soluotkichhoat { get => soluotkichhoat; set => soluotkichhoat = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Errorcode { get => errorcode; set => errorcode = value; }
    }
}
