using QuanLyWinDowVaOffice.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyWinDowVaOffice.Entities;

namespace QuanLyWinDowVaOffice.DAL
{
    class KhoaBanQuyen_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
            //string makhoa,string tenkhoa,string theloai,int soluotkichhoat
            if (File.Exists("KhoaBanQuyen.txt"))
            {
                StreamReader streamReader = new StreamReader("KhoaBanQuyen.txt");
                string line;
                while((line = streamReader.ReadLine()) != null)
                {
                    string makhoa = line.Split("#")[0];
                    string tenkhoa = line.Split("#")[1];
                    string theloai = line.Split("#")[2];
                    int soluotkichhoat = int.Parse(line.Split("#")[3]);
                    string ngaynhap = line.Split("#")[4];
                    string errorcode = line.Split("#")[5];
                    arrayList.Add(new KhoaBanQuyen(makhoa, tenkhoa, theloai, soluotkichhoat,ngaynhap,errorcode));
                }
                streamReader.Close();
            }
            
        }

        public void GhiFile(ArrayList arrayList)
        {

            StreamWriter streamWriter = new StreamWriter("KhoaBanQuyen.txt");
            foreach (KhoaBanQuyen khoaBanQuyen in arrayList)
            {
                streamWriter.WriteLine(khoaBanQuyen.ToString());
            }
            streamWriter.Close();
        }
    }
}
