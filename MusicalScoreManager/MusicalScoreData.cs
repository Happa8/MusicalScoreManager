using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace MusicalScoreManager
{
    public class MusicalScoreData
    {
        private int ScoreNum; //楽譜通番
        private string ScoreName; //楽譜名
        private string ScoreNameJP; //楽譜名（日本語）
        private string ScoreComposer; //作曲者名
        private string ScoreArranger; //編曲者名
        private int ScoreState; //楽譜保存状況
        private bool IsSMPCreated; //楽譜管理票が作られているかどうか SMP:ScoreManagementPrint
        private string ScoreClassification; //楽譜の区分



        //-------フィールドを利用するためのメソッド群--------
        public void ChangeScoreNum(int CScoreNum)
        {
            ScoreNum = CScoreNum;
        }
        public void ChangeScoreName(string CScoreName)
        {
            ScoreName = CScoreName;
        }
        public void ChangeScoreNameJP(string CScoreNameJP)
        {
            ScoreNameJP = CScoreNameJP;
        }
        public void ChangeScoreComposer(string CScoreComposer)
        {
            ScoreComposer = CScoreComposer;
        }
        public void ChangeScoreArranger(string CScoreArranger)
        {
            ScoreArranger = CScoreArranger;
        }
        public void ChangeScoreState(int CScoreState)
        {
            ScoreState = CScoreState;
        }
        public void ChangeIsSMPCreated(bool CIsSMPCreated)
        {
            IsSMPCreated = CIsSMPCreated;
        }
        public void ChangeScoreClassification(string CScoreClassification)
        {
            ScoreClassification = CScoreClassification;
        }

        public void ReadScoreName(string RScoreName)
        {
            RScoreName = ScoreName;
        }

        //データ保存用メソッド
        public void SaveMSD()
        {
            string MSDName = "MSD\\" + ScoreNum.ToString() + ".msd";
            var WriteMSD = new StreamWriter(MSDName, false, Encoding.GetEncoding("Shift_JIS"));

            WriteMSD.WriteLine(ScoreNum);
            WriteMSD.WriteLine(ScoreName);
            WriteMSD.WriteLine(ScoreNameJP);
            WriteMSD.WriteLine(ScoreComposer);
            WriteMSD.WriteLine(ScoreArranger);
            WriteMSD.WriteLine(ScoreState);
            WriteMSD.WriteLine(IsSMPCreated);
            WriteMSD.WriteLine(ScoreClassification);

            WriteMSD.Close();
        }
    }
}
