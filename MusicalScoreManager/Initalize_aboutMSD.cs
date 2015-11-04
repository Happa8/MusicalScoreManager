using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicalScoreManager
{
    class Initalize_aboutMSD
    {
        public static int MSDNum;

        public static void SaveMSDNum()
        {
            var SaveMSDNum = new StreamWriter("MSD\\OtherData.setting", false, Encoding.GetEncoding("Shift_JIS"));
            SaveMSDNum.WriteLine(MSDNum);
            SaveMSDNum.Close();


        }

        public static void ReadMSDNum()
        {
            if (!File.Exists("MSD\\OtherData.setting"))
            {
                SaveMSDNum();
            }

            var ReadMSDNum = new StreamReader("MSD\\OtherData.setting");
            string stMSDNum = ReadMSDNum.ReadLine();
            MSDNum = int.Parse(stMSDNum);
            ReadMSDNum.Close();

        }
    }
}
