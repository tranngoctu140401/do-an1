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
                Console.WriteLine("Nhập tài khoản: ");
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
                Console.WriteLine("Nhập mật khẩu: ");
                pass = Console.ReadLine();
                if (pass != "") break;
            }
            return pass;
        }
    }
}
