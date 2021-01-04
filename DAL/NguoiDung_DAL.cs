using QuanLyWinDowVaOffice.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyWinDowVaOffice.Entities;
namespace QuanLyWinDowVaOffice.DAL
{
    class NguoiDung_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
            if (File.Exists("NguoiDung.txt"))
            {
                string line;
                StreamReader streamReader = new StreamReader("NguoiDung.txt");

                while((line= streamReader.ReadLine()) != null){
                    string taikhoan = line.Split("#")[0];
                    string matkhau = line.Split("#")[1];
                    string thietbi = line.Split("#")[2];
                    arrayList.Add(new NguoiDung(taikhoan, matkhau, thietbi));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("NguoiDung.txt");
            foreach(NguoiDung nguoiDung in arrayList)
            {
                streamWriter.WriteLine(nguoiDung.ToString());
            }
            streamWriter.Close();
        }
    }
}
