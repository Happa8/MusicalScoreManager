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
using System.Windows.Shapes;

namespace MusicalScoreManager
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class newMSDWindow : Window
    {
        private int ScoreNum; //楽譜通番
        private string ScoreName; //楽譜名
        private string ScoreNameJP; //楽譜名（日本語）
        private string ScoreComposer; //作曲者名
        private string ScoreArranger; //編曲者名
        private int ScoreState; //楽譜保存状況
        private bool IsSMPCreated; //楽譜管理票が作られているかどうか SMP:ScoreManagementPrint
        private string ScoreClassification; //楽譜の区分

        public newMSDWindow()
        {
            InitializeComponent();
            SavetoNewMSD();

            
        }

        //新規MSD作成
        public void SavetoNewMSD() 
        {
            MusicalScoreData MSD000001 = new MusicalScoreData();
            MSD000001.ChangeScoreName(ScoreName);

        }

        private void ScoreName_I_TextChanged(object sender, TextChangedEventArgs e)
        {
            ScoreName = ScoreName_I.Text;
            
        }
    }
}
