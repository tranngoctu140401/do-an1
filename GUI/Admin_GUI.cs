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

            Console.WriteLine("_______________________________________________________________________________________________________");
            Console.WriteLine("|                                 QUẢN LÝ KEY OFFICE & WINDOW                                         |");
            Console.WriteLine("|_____________________________________________________________________________________________________|");
            Console.WriteLine("|1. Nhập thêm key                                    |5. Tổng số lượng key                            |");
            Console.WriteLine("|2. Hiện thị danh sách                               |6. Tổng key còn lượt kích hoạt                  |");
            Console.WriteLine("|3. Cập nhật thông tin                               |7. Tổng key hết kích hoạt                       |");
            Console.WriteLine("|4. Xóa key                                          |8. Hiện các thiết bị                            |");
            Console.WriteLine("|____________________________________________________|________________________________________________|");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                          9. Hiện các thiết bị sử dụng bản quyền window                              |");
            Console.WriteLine("|                          10. Hiện các thiết bị sử dụng bản quyền office                             |");
            Console.WriteLine("|                          11. Hiện các thiết bị sử dụng bản quyền window & office                    |");
            Console.WriteLine("|                          0.Thoát                                                                    |");
            Console.WriteLine("|_____________________________________________________________________________________________________|");
            Console.SetCursorPosition(30, 15);
            Console.Write("Lựa chọn của bạn: ");
        }

        public void Run(QuanLyKhoa_BLL quanLyKhoa_BLL, KhoaBanQuyen_DAL khoaBanQuyen_DAL, TinhToan_BLL tinhToan_BLL, ArrayList khoaArrayList, QuanLyThietBi_BLL quanLyThietBi_BLL, ArrayList thietBiArrayList)
        {
            Console.Clear();
            Console.SetCursorPosition(35, 2);
            Console.Write("__________________________________________________________");
            Console.SetCursorPosition(35, 3);
            Console.Write("|                                                        |");
            Console.SetCursorPosition(35, 4);
            Console.Write("|                        ĐĂNG NHẬP                       |");
            Console.SetCursorPosition(35, 5);
            Console.Write("|                                                        |");
            Console.SetCursorPosition(35, 6);
            Console.Write("|                                                        |");
            Console.SetCursorPosition(35, 7);
            Console.Write("|                                                        |");
            Console.SetCursorPosition(35, 8);
            Console.Write("|                                                        |");
            Console.SetCursorPosition(35, 9);
            Console.Write("|                                                        |");
            Console.SetCursorPosition(35, 10);
            Console.Write("|________________________________________________________|");
            Console.SetCursorPosition(40, 6);
            Console.Write("TÊN TÀI KHOẢN (admin):");
            string tk = Console.ReadLine();
            Console.SetCursorPosition(40, 8);
            Console.Write("MẬT KHẨU (admin):");
            string mk = Console.ReadLine();
            if (tk.Equals("admin") && mk.Equals("admin"))
            {
                Console.SetCursorPosition(45, 12);
                Console.WriteLine("=>>> Đăng nhập thành công <<<=");
                Console.ReadKey();
                Console.Clear();
                int chon;
                while (true)
                {
                    Menu();
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 0) break;
                    switch (chon)
                    {
                        case 1:
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
                Console.WriteLine("Đăng nhập không thành công");
            }
        }
    }
}
