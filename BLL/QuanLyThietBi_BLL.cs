using QuanLyWinDowVaOffice.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyWinDowVaOffice.Entities;

namespace QuanLyWinDowVaOffice.BLL
{
    class QuanLyThietBi_BLL : QuanLyThietBi_IF
    {
        public void Display(ThietBi thietBi)
        {
            Console.WriteLine("|{0,-20}|{1,-30}|", thietBi.Tenthietbi, thietBi.Madasudung);
        }
        public void HienThietBi(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-30}|", "Tên thiết bị", "Mã kích hoạt");

            foreach (ThietBi thietBi in arrayList)
            {
                Display(thietBi);
            }
        }
        public void HienThiSudungAll(ArrayList thietBiArrayList, ArrayList khoaArrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-30}|", "Tên thiết bị", "Mã kích hoạt");

            foreach (ThietBi thietBi in thietBiArrayList)
            {
                foreach (KhoaBanQuyen khoaBanQuyen in khoaArrayList)
                {
                    if (thietBi.Madasudung.Equals(khoaBanQuyen.Makhoa))
                    {
                        Display(thietBi);
                    }
                }
            }
        }
        public string XuLyOffice(string str)
        {
            string tmp = "";
            for (int i = 0; i < 6; i++)
            {
                tmp += str[i];
            }
            return tmp;
        }
        public void HienThiSuDungOffice(ArrayList thietBiArrayList, ArrayList khoaArrayList)
        {
            
            Console.WriteLine("|{0,-20}|{1,-30}|", "Tên thiết bị", "Mã kích hoạt");

            foreach (ThietBi thietBi in thietBiArrayList)
            {
                foreach (KhoaBanQuyen khoaBanQuyen in khoaArrayList)
                {
                  
                        if (thietBi.Madasudung.Equals(khoaBanQuyen.Makhoa)&&XuLyOffice(khoaBanQuyen.Tenkhoa).ToLower().Equals("office"))
                        {
                            Display(thietBi);
                        }
                   
                }
            }
        }

        public void HienThiSuDungWindow(ArrayList khoaArrayList,ArrayList thietBiArrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-30}|", "Tên thiết bị", "Mã kích hoạt");

            foreach (ThietBi thietBi in thietBiArrayList)
            {
                foreach (KhoaBanQuyen khoaBanQuyen in khoaArrayList)
                {

                    if (thietBi.Madasudung.Equals(khoaBanQuyen.Makhoa) && XuLyOffice(khoaBanQuyen.Tenkhoa).ToLower().Equals("window"))
                    {
                        Display(thietBi);
                    }

                }
            }
        }
    }
}
