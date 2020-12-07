using QuanLyWinDowVaOffice.BLL.Interface;
using QuanLyWinDowVaOffice.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.BLL
{
    class TinhToan_BLL : TinhToan_IF
    {
        public void TinhTong(ArrayList arrayList)
        {
            int dem = 0;
            foreach(KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                dem++;
            }
            Console.WriteLine("Số lượng khóa kích hoạt là " + dem);
        }

        public void TinhTongConLuot(ArrayList arrayList)
        {
            int dem = 0;
            foreach (KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                if (khoaBanQuyen.Soluotkichhoat > 0) dem++;
            }
            Console.WriteLine("Số lượng khóa kích hoạt còn lượt là " + dem);
        }

        public void TinhTongHetLuot(ArrayList arrayList)
        {
            int dem = 0;
            foreach (KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                if (khoaBanQuyen.Soluotkichhoat == 0) dem++;
            }
            Console.WriteLine("Số lượng khóa kích hoạt hết lượt là " + dem);
        }

        public void TongSoLuotKichHoat(ArrayList arrayList)
        {
            int dem = 0;
            foreach (KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                if (khoaBanQuyen.Errorcode.Equals("Online")) dem++;
            }
            Console.WriteLine("Số lượng khóa kích hoạt hết lượt là " + dem);
        }
    }
}
