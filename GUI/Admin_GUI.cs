using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyWinDowVaOffice.BLL;
using QuanLyWinDowVaOffice.DAL;
namespace QuanLyWinDowVaOffice.GUI
{
    class Admin_GUI
    {
        private void Menu()
        {
            Console.Clear();
            Console.SetCursorPosition(9, 4);  Console.WriteLine("███████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(9, 5);  Console.WriteLine("██                                                                                                   ██");
            Console.SetCursorPosition(9, 6);  Console.WriteLine("██                                QUẢN LÝ BẢN QUYỀN OFFICE & WINDOWS                                 ██");
            Console.SetCursorPosition(9, 7);  Console.WriteLine("██___________________________________________________________________________________________________██");
            Console.SetCursorPosition(9, 8);  Console.WriteLine("██ 1. Nhập khóa bản quyền                        | 5. Tổng số lượng khóa bản quyền                   ██");
            Console.SetCursorPosition(9, 9);  Console.WriteLine("██ 2. Hiện thị danh sách khóa bản quyền          | 6. Tổng khóa bản quyền còn lượt kích hoạt         ██");
            Console.SetCursorPosition(9, 10); Console.WriteLine("██ 3. Cập nhật thông tin                         | 7. Tổng khóa bản quyền hết lượt kích hoạt         ██");
            Console.SetCursorPosition(9, 11); Console.WriteLine("██ 4. Xóa khóa bản quyền                         | 8. Hiện các thiết bị sử dụng bản quyền            ██");
            Console.SetCursorPosition(9, 12); Console.WriteLine("██_______________________________________________|___________________________________________________██");
            Console.SetCursorPosition(9, 13); Console.WriteLine("██                                                                                                   ██");
            Console.SetCursorPosition(9, 14); Console.WriteLine("██                         9. Hiện các thiết bị sử dụng bản quyền window                             ██");
            Console.SetCursorPosition(9, 15); Console.WriteLine("██                         10. Hiện các thiết bị sử dụng bản quyền office                            ██");
            Console.SetCursorPosition(9, 16); Console.WriteLine("██                         11. Hiện các thiết bị sử dụng bản quyền window & office                   ██");
            Console.SetCursorPosition(9, 17); Console.WriteLine("██                         0.Thoát                                                                   ██");
            Console.SetCursorPosition(9, 18); Console.WriteLine("██                                                                                                   ██");
            Console.SetCursorPosition(9, 19); Console.WriteLine("███████████████████████████████████████████████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(30, 21);
            Console.Write("Lựa chọn của bạn: ");
        }

        public void Run(QuanLyKhoa_BLL quanLyKhoa_BLL, KhoaBanQuyen_DAL khoaBanQuyen_DAL, TinhToan_BLL tinhToan_BLL, ArrayList khoaArrayList, QuanLyThietBi_BLL quanLyThietBi_BLL, ArrayList thietBiArrayList)
        {
            Console.Clear();
            Console.SetCursorPosition(30, 6);  Console.Write("████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(30, 7);  Console.Write("██                                                        ██");
            Console.SetCursorPosition(30, 8);  Console.Write("██                                                        ██");
            Console.SetCursorPosition(30, 9);  Console.Write("██                                                        ██");
            Console.SetCursorPosition(30, 10); Console.Write("██       TÀI KHOẢN :                                      ██");
            Console.SetCursorPosition(30, 11); Console.Write("██                                                        ██");
            Console.SetCursorPosition(30, 12); Console.Write("██       MẬT KHẨU :                                       ██");
            Console.SetCursorPosition(30, 13); Console.Write("██                                                        ██");
            Console.SetCursorPosition(30, 14); Console.Write("████████████████████████████████████████████████████████████");
            Console.SetCursorPosition(55, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ĐĂNG NHẬP");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 10);
            Console.Write("");
            string tk = Console.ReadLine();
            Console.SetCursorPosition(49, 12);
            Console.Write("");
            string mk = Console.ReadLine();
            if (tk.Equals("admin") && mk.Equals("admin"))
            {
                Console.SetCursorPosition(44, 16);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=>>> Đăng nhập thành công <<<=");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                int chon;
                while (true)
                {
                    Menu();
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 0)
                    {
                        Console.Clear(); break;
                    }
                    switch (chon)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("MỖI KHÓA BẢN QUYỀN CÓ 25 KÝ TỰ ĐƯỢC VIẾT HOA GỒM CẢ SỐ VÀ CHỮ!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            quanLyKhoa_BLL.Nhap(khoaArrayList);                           
                            khoaBanQuyen_DAL.GhiFile(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            quanLyKhoa_BLL.Hien(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            quanLyKhoa_BLL.CapNhat(khoaArrayList);
                            khoaBanQuyen_DAL.GhiFile(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            quanLyKhoa_BLL.Xoa(khoaArrayList);
                            khoaBanQuyen_DAL.GhiFile(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 5:
                            tinhToan_BLL.TinhTong(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 6:
                            tinhToan_BLL.TinhTongConLuot(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 7:
                            tinhToan_BLL.TinhTongHetLuot(khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 8:
                            quanLyThietBi_BLL.HienThietBi(thietBiArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 9:
                            quanLyThietBi_BLL.HienThiSuDungWindow(khoaArrayList, thietBiArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 10:
                            quanLyThietBi_BLL.HienThiSuDungOffice(thietBiArrayList, khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 11:
                            quanLyThietBi_BLL.HienThiSudungAll(thietBiArrayList, khoaArrayList);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        default: break;



                    }
                }
            }
            else
            {
                Console.SetCursorPosition(41, 16);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("==> Đăng nhập không thành công <==");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
