using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.BLL.Interface
{
    interface TinhToan_IF
    {
        void TinhTong(ArrayList arrayList);
        void TinhTongConLuot(ArrayList arrayList);
        void TinhTongHetLuot(ArrayList arrayList);
        void TongSoLuotKichHoat(ArrayList arrayList);
    }
}
