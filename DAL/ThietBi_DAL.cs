using QuanLyWinDowVaOffice.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyWinDowVaOffice.Entities;

namespace QuanLyWinDowVaOffice.DAL
{
    class ThietBi_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
            if (File.Exists("ThietBi.txt"))
            {
                StreamReader streamReader = new StreamReader("ThietBi.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {

                    string tenthietbi = line.Split("#")[0];

                    string makhoa = line.Split("#")[1];

                    arrayList.Add(new ThietBi(tenthietbi, makhoa));
                }
                streamReader.Close();
            }

        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("ThietBi.txt");
            foreach (ThietBi thietBi in arrayList)
            {
                streamWriter.WriteLine(thietBi.ToString());
            }
            streamWriter.Close();
        }
    }
}

