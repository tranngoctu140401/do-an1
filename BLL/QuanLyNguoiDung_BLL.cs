using System;
using System.Collections;
using System.Text;
using QuanLyWinDowVaOffice.DAL;
using QuanLyWinDowVaOffice.Entities;
namespace QuanLyWinDowVaOffice.BLL
{
    class QuanLyNguoiDung_BLL
    {
        static NguoiDung_DAL nguoiDung_DAL = new NguoiDung_DAL();
        static ThietBi_DAL ThietBi_DAL = new ThietBi_DAL();
        public void NhapKey(ArrayList thietBiArrayList, ArrayList khoabanquyenArrayList, NguoiDung user, string key)
        {
            bool kt = false;
            foreach (ThietBi thietBi in thietBiArrayList)
            {
                foreach (KhoaBanQuyen khoaBanQuyen in khoabanquyenArrayList)
                {
                    if (user.Thietbi.Equals(thietBi.Tenthietbi))
                    {
                        if (key.Equals(khoaBanQuyen.Makhoa))
                        {
                            Console.WriteLine("Nhập key thành công");
                            thietBi.Madasudung = key;
                            khoaBanQuyen.Soluotkichhoat = khoaBanQuyen.Soluotkichhoat - 1;
                            kt = true;
                        }
                    }
                }

            }
            ThietBi_DAL.GhiFile(thietBiArrayList);
            if (kt == false) Console.WriteLine("Nhập  key không thành công");
        }
        public void TaoTK(ArrayList list, ArrayList thietbis)
        {
            //tạo tải khoản
            string tk = UserName();
            string mk = Password();
            string tb = Tenthietbi();
            //ghi tài khoản vào danh sách mảng
            list.Add(new NguoiDung(tk, mk, tb));
            thietbis.Add(new ThietBi(tb));
            ThietBi_DAL.GhiFile(thietbis);
            //ghi tài khoản vào cơ sở dữ liệu

            nguoiDung_DAL.GhiFile(list);
        }
        public NguoiDung DangNhap(ArrayList list)
        {
            NguoiDung nguoiDung = null;
            //đọc tài khoản trong cơ sở dữ liệu
           
            string tk = UserName();
            string mk = Password();
            foreach (NguoiDung dangnhap in list)
            {
                if (tk.Equals(dangnhap.Tentaikhoan) && mk.Equals(dangnhap.Matkhau))
                {
                    nguoiDung = dangnhap;
                }
            }
            return nguoiDung;
        }
        public string UserName()
        {
            string tk;
            while (true)
            {
                Console.SetCursorPosition(35, 5);  Console.Write("████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(35, 6);  Console.Write("██                                                        ██");
                Console.SetCursorPosition(35, 7);  Console.Write("██                                                        ██");
                Console.SetCursorPosition(35, 8);  Console.Write("██                                                        ██");
                Console.SetCursorPosition(35, 9);  Console.Write("██       TÀI KHOẢN:                                       ██");
                Console.SetCursorPosition(35, 10); Console.Write("██                                                        ██");
                Console.SetCursorPosition(35, 11); Console.Write("██       MẬT KHẨU:                                        ██");
                Console.SetCursorPosition(35, 12); Console.Write("██                                                        ██");
                Console.SetCursorPosition(35, 13); Console.Write("████████████████████████████████████████████████████████████");
                Console.SetCursorPosition(60, 7);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ĐĂNG NHẬP");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(54, 9);
                Console.Write("");
                tk = Console.ReadLine();
                if (tk != "") break;
            }
            return tk;
        }
        public string Tenthietbi()
        {
            string tk;
            while (true)
            {
                Console.SetCursorPosition(53, 15);
                Console.WriteLine("Nhập tên thiết bị: ");
                tk = Console.ReadLine();
                if (tk != "") break;
            }
            return tk;
        }
        public string Password()
        {
            string pass;
            while (true)
            {
                Console.SetCursorPosition(53, 11);
                Console.Write("");
                pass = Console.ReadLine();
                if (pass != "") break;
            }
            return pass;
        }
    }
}
