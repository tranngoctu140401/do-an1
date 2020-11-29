using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyWinDowVaOffice.BLL;
using QuanLyWinDowVaOffice.DAL;
using QuanLyWinDowVaOffice.Entities;

namespace QuanLyWinDowVaOffice.GUI
{
    class NguoiDung_GUI
    {
        static QuanLyNguoiDung_BLL quanlynguoidung = new QuanLyNguoiDung_BLL();
        private  void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Đăng nhập                    |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Đăng kí                      |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  0.Thoát                        |");
            Console.WriteLine("---------------------------------------------------");
        }
        static NguoiDung user;
        static NguoiDung_DAL nguoidung = new NguoiDung_DAL();
        public  void Chon(ArrayList taikhoan,ArrayList thietbiArrayList,ArrayList khoabanquyenArrayList)
        {
            nguoidung.DocFile(taikhoan);
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        user = quanlynguoidung.DangNhap(taikhoan);
                        if (user != null)
                        {
                            Console.WriteLine("Đăng nhập thành công");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Nhập key");
                            string key = Console.ReadLine();
                            quanlynguoidung.NhapKey(thietbiArrayList, khoabanquyenArrayList, user,key);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Đăng nhập thất bại");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        quanlynguoidung.TaoTK(taikhoan,thietbiArrayList);

                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
