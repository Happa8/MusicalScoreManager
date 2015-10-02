using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
    }
}
