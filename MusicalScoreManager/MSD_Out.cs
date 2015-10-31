using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicalScoreManager
{
    class MSD_Out
    {
        public static void CreateMSDFile()
        {
            string CurrentDir = System.IO.Directory.GetCurrentDirectory();
            bool CheckMSDFolderCreated = File.Exists(CurrentDir + "\\MSD");

            if (CheckMSDFolderCreated)
            {
                Directory.CreateDirectory(CurrentDir + "\\MSD");
            }
        }
    }
}
