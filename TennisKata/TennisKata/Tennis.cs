namespace TennisKata
{
    public class Tennis

    {
        private int _firstPlayerScoreTime;
        private int _secondPlayerScoreTime;

        public string Score()
        {
            if (_firstPlayerScoreTime == 1 && _secondPlayerScoreTime == 1)
            {
                return "Fifteen_All";
            }
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
            return "Love_All";
        }

        public void PlayerScored(string person, int scoreTime)
        {
            if (person == "first")
            {
                for (int i = 0; i < scoreTime; i++)
                {
                    _firstPlayerScoreTime++;
                }
            }
            else
            {
                for (int i = 0; i < scoreTime; i++)
                {
                    _secondPlayerScoreTime++;
                }
            }
        }
    }
}