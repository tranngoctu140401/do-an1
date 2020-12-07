using QuanLyWinDowVaOffice.BLL;
using System;
using System.Collections;
using System.Text;
using QuanLyWinDowVaOffice.GUI;
namespace QuanLyWinDowVaOffice
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            QuanLy_GUI quanly = new QuanLy_GUI();
            quanly.Chon();
        }
    }
}
