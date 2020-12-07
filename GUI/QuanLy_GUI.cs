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
            Console.SetCursorPosition(32, 6);
            Console.WriteLine("███████████████████████████████████████████████████████");
            Console.SetCursorPosition(32, 7);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 8);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 9);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 10);
            Console.WriteLine("██___________________________________________________██");
            Console.SetCursorPosition(32, 11);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 12);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 13);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 14);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 15);
            Console.WriteLine("██                                                   ██");
            Console.SetCursorPosition(32, 16);
            Console.WriteLine("███████████████████████████████████████████████████████");
            Console.SetCursorPosition(55, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TÙY CHỌN");
            Console.SetCursorPosition(50, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Admin");
            Console.SetCursorPosition(50, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Người dùng");
            Console.SetCursorPosition(50, 14);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0. Thoát");
            Console.SetCursorPosition(42, 19);
            Console.Write("Lựa chọn của bạn: ");
            Console.ForegroundColor = ConsoleColor.White;
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
