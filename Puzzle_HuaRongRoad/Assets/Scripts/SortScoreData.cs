/************************************************************
  FileName: SortScoreData.cs
  Author:Guido Kuo       Version :1.0        Date: 2018-10-16
  Description:数据排序
************************************************************/
namespace Assets.Scripts
{
    /// <summary>
    /// 排序逻辑
    /// </summary>
    public class SortScoreData : System.IComparable<SortScoreData>
    {
        public string Name;
        public int GameScore;
        public SortScoreData(string n, int s)
        {
            Name = n;
            GameScore = s;
        }
        public int CompareTo(SortScoreData other)
        {
            if (other == null)
                return 0;
            int value = other.GameScore - this.GameScore;
            return value;
        }
        public override string ToString()//debug用
        {
            return Name + " : " + GameScore.ToString();
        }
    }
}
