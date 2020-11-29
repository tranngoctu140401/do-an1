using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyWinDowVaOffice.BLL;
using QuanLyWinDowVaOffice.DAL;
namespace QuanLyWinDowVaOffice.GUI
{
    class QuanLy_GUI
    {
        private void Menu()
        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine("|Tùy chọn                              |");
            Console.WriteLine("|1. Admin                              |");
            Console.WriteLine("|2. Người dùng                         |");
            Console.WriteLine("|0. Thoát                              |");
            Console.WriteLine("|______________________________________|");
        }
        //QuanLyKhoa_BLL quanLyKhoa_BLL, KhoaBanQuyen_DAL khoaBanQuyen_DAL, TinhToan_BLL tinhToan_BLL, ArrayList khoaArrayList, QuanLyThietBi_BLL quanLyThietBi_BLL, ArrayList thietBiArrayList
        static Admin_GUI admin = new Admin_GUI();
        static NguoiDung_GUI nguoiDung = new NguoiDung_GUI();
        static QuanLyKhoa_BLL quanLyKhoa_BLL = new QuanLyKhoa_BLL();
        static KhoaBanQuyen_DAL khoaBanQuyen_DAL = new KhoaBanQuyen_DAL();
        static TinhToan_BLL tinhToan_BLL = new TinhToan_BLL();
        static QuanLyThietBi_BLL quanLyThietBi_BLL = new QuanLyThietBi_BLL();
        static ArrayList khoaArrayList = new ArrayList();
        static ArrayList thietBiArrayList = new ArrayList();
        static ArrayList taikhoan = new ArrayList();
        static ThietBi_DAL thietBi = new ThietBi_DAL();
        NguoiDung_DAL nguoiDung_DAL = new NguoiDung_DAL();
        public void Chon()
        {
            khoaBanQuyen_DAL.DocFile(khoaArrayList);
            thietBi.DocFile(thietBiArrayList);
            nguoiDung_DAL.DocFile(taikhoan);
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        admin.Run(quanLyKhoa_BLL, khoaBanQuyen_DAL, tinhToan_BLL, khoaArrayList, quanLyThietBi_BLL, thietBiArrayList);
                        break;
                    case 2:
                        nguoiDung.Chon(taikhoan, thietBiArrayList, khoaArrayList);
                        break;
                    default: break;

                }
            }
        }
    }
}
