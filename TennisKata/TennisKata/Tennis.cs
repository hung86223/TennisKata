namespace TennisKata
{
    public class Tennis

    {
        private int _firstPlayerScoreTime;
        private int _secondPlayerScoreTime;

        public string Score()
        {
            if (_firstPlayerScoreTime == 1)
            {
                return "Fifteen_Love";
            }
            if (_firstPlayerScoreTime == 2)
            {
                return "Thirty_Love";
            }
            if (_firstPlayerScoreTime == 3)
            {
                return "Forty_Love";
            }
            if (_firstPlayerScoreTime == 1 && _secondPlayerScoreTime == 1)
            {
                return "Fifteen_All";
            }
            return "Love_All";
        }

        public void FirstPlayerScored()
        {
            _firstPlayerScoreTime++;
        }
    }
}