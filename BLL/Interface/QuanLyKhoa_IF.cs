using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.BLL.Interface
{
    interface QuanLyKhoa_IF
    {
        void Nhap(ArrayList arrayList);
        void CapNhat(ArrayList arrayList);
        void Xoa(ArrayList arrayList);
        void Hien(ArrayList arrayList);
    }
}
