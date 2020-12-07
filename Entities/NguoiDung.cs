using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.Entities
{
    class NguoiDung
    {
        private string tentaikhoan;
        private string matkhau;
        private string thietbi;
        public NguoiDung(string tentaikhoan, string matkhau, string thietbi)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.thietbi = thietbi;
        }
        override
            public string ToString()
        {
            return tentaikhoan + "#" + matkhau + "#" + thietbi;
        }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Thietbi { get => thietbi; set => thietbi = value; }
    }
}
