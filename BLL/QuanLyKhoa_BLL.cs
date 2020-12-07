using QuanLyWinDowVaOffice.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyWinDowVaOffice.Entities;

namespace QuanLyWinDowVaOffice.BLL
{
    class QuanLyKhoa_BLL : QuanLyKhoa_IF
    {
        public void Display(KhoaBanQuyen khoaBanQuyen,ArrayList arrayList)
        {
            Console.WriteLine("|{0,-5}|{1,-30}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|",arrayList.IndexOf(khoaBanQuyen),khoaBanQuyen.Makhoa,khoaBanQuyen.Tenkhoa,khoaBanQuyen.Soluotkichhoat,khoaBanQuyen.Ngaynhap,khoaBanQuyen.Errorcode);
        }
        public KhoaBanQuyen Find(ArrayList arrayList)
        {
            Hien(arrayList);
            Console.WriteLine("Nhập từ khóa cần tìm");
            string keyword = Console.ReadLine();
            KhoaBanQuyen result = null;
            foreach(KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                if (keyword.ToLower().Equals(khoaBanQuyen.Tenkhoa))
                {
                    result = khoaBanQuyen;
                }
            }
            return result;
        }
        public void CapNhat(ArrayList arrayList)
        {
            KhoaBanQuyen khoaBanQuyen = Find(arrayList);
            if (khoaBanQuyen == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã khóa bản quyển");
                khoaBanQuyen.Makhoa = ChuanHoaKey(Console.ReadLine());
                Console.WriteLine("Tên khóa bản quyền");
                khoaBanQuyen.Tenkhoa= Console.ReadLine();
                Console.WriteLine("Nhập số lượng khóa");
                khoaBanQuyen.Soluotkichhoat = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập thể loại");
                khoaBanQuyen.Theloai = Console.ReadLine();
                Console.WriteLine("Nhập ngày nhập");
                khoaBanQuyen.Ngaynhap = Console.ReadLine();
                Console.WriteLine("Nhập tình trạng");
                khoaBanQuyen.Errorcode = Console.ReadLine();
                Console.WriteLine("Cập nhật thành công");
            }
        }


        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-5}|{1,-30}|{2,-20}|{3,-20}|{4,-20}|{5,-10}|","STT", "Mã khóa", "Tên khóa", "Số lượt","Ngày nhập","Error code");
            foreach(KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                Display(khoaBanQuyen, arrayList);
            }
        }
        public static string ChuanHoaKey(string key)
        {


            string tmp = "";
           
            for (int i = 0; i < key.Length; i++)
            {

                if (i > 4 && i % 5 == 0 && i <= 20)
                {
                    tmp += "-" + key[i];
                }
                else
                {
                    tmp += key[i];
                }

            }
            return tmp;
        }

        public void Nhap(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã khóa bản quyển");
            string key = ChuanHoaKey(Console.ReadLine());
            Console.WriteLine("Tên khóa bản quyền");
            string tenkhoa = Console.ReadLine();
            Console.WriteLine("Nhập số lượng khóa");
            int soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập thể loại");
            string theloai = Console.ReadLine();
            Console.WriteLine("Nhập ngày nhập");
            string ngaynhap = Console.ReadLine();
            Console.WriteLine("Nhập tình trạng");
            string errorcode = Console.ReadLine();
            arrayList.Add(new KhoaBanQuyen(key, tenkhoa, theloai, soluong,ngaynhap,errorcode));
        }

        public void Xoa(ArrayList arrayList)
        {
            KhoaBanQuyen khoaBanQuyen = Find(arrayList);
            if (khoaBanQuyen == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                arrayList.Remove(khoaBanQuyen);
                Console.WriteLine("Xóa thành công");
            }
        }
    }
}
