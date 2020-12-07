using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuanLyWinDowVaOffice.BLL.Interface
{
    interface QuanLyThietBi_IF
    {
        void HienThiSuDungWindow(ArrayList thietbiArraylist, ArrayList khoaArrayList);
        void HienThiSuDungOffice(ArrayList thietBiArrayList, ArrayList khoaArrayList);
        void HienThiSudungAll(ArrayList thietBiArrayList, ArrayList khoaArrayList);
       
    }
}
