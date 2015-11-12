using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicalScoreManager
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MSD_Out.CreateMSDFile();
            Initalize_aboutMSD.ReadMSDNum();
            
            
        }

        private void newMSD_Click(object sender, RoutedEventArgs e)
        {
            newMSDWindow NewMSD = new newMSDWindow();
            NewMSD.ShowDialog();
            //MSD_Out.CreateMSDFile();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Initalize_aboutMSD.SaveMSDNum();
        }
    }
}
