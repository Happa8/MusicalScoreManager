using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace MusicalScoreManager
{
    class MSD_Out
    {
        public static void CreateMSDFile()
        {
            string CurrentDir = System.IO.Directory.GetCurrentDirectory();
            string MSDDir = CurrentDir + "\\MSD";
            bool CheckMSDFolderCreated = File.Exists(MSDDir);

            if (!CheckMSDFolderCreated)
            {
                Directory.CreateDirectory(MSDDir);
                //var MSDFileInfo = new System.IO.DirectoryInfo(MSDDir);
                //MSDFileInfo.Attributes |= System.IO.FileAttributes.Hidden;
                
            }

            

            
           
        }
    }
}
