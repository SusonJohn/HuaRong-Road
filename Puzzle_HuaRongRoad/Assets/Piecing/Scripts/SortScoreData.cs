namespace Assets.Piecing.Scripts
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
