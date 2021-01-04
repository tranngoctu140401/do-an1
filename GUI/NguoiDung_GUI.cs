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
            Console.Clear();
            Console.SetCursorPosition(35, 6);  Console.WriteLine("████████████████████████████████████████████████████████");
            Console.SetCursorPosition(35, 7);  Console.WriteLine("█                                                      █");
            Console.SetCursorPosition(35, 8);  Console.WriteLine("█                     1.Đăng nhập                      █");
            Console.SetCursorPosition(35, 9);  Console.WriteLine("█                                                      █");
            Console.SetCursorPosition(35, 10); Console.WriteLine("████████████████████████████████████████████████████████");
            Console.SetCursorPosition(35, 11); Console.WriteLine("█                                                      █");
            Console.SetCursorPosition(35, 12); Console.WriteLine("█                     2.Đăng kí                        █");
            Console.SetCursorPosition(35, 13); Console.WriteLine("█                                                      █");
            Console.SetCursorPosition(35, 14); Console.WriteLine("████████████████████████████████████████████████████████");
            Console.SetCursorPosition(35, 15); Console.WriteLine("█                                                      █");
            Console.SetCursorPosition(35, 16); Console.WriteLine("█                     0.Thoát                          █");
            Console.SetCursorPosition(35, 17); Console.WriteLine("█                                                      █");
            Console.SetCursorPosition(35, 18); Console.WriteLine("████████████████████████████████████████████████████████");
            Console.SetCursorPosition(40, 20);
            Console.Write("Lựa chọn của bạn: ");
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
                            Console.SetCursorPosition(53, 15);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Đăng nhập thành công");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                            Console.SetCursorPosition(40, 6);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("HÃY NHẬP KHÓA BẢN QUYỀN BẠN MUỐN SỬ DỤNG!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(40, 7);  Console.WriteLine("_______________________________________________");
                            Console.SetCursorPosition(40, 8);  Console.WriteLine("|");
                            Console.SetCursorPosition(40, 9);  Console.WriteLine("|Nhập key:");
                            Console.SetCursorPosition(40, 10); Console.WriteLine("|______________________________________________");
                            Console.SetCursorPosition(50, 9);
                            string key = Console.ReadLine();
                            quanlynguoidung.NhapKey(thietbiArrayList, khoabanquyenArrayList, user,key);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.SetCursorPosition(53, 15);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Đăng nhập thất bại");
                            Console.ForegroundColor = ConsoleColor.White;
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
