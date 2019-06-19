using System.Collections.Generic;

namespace TennisKata
{
    public class Tennis

    {
        private int _firstPlayerScoreTime;
        private int _secondPlayerScoreTime;
        private string _firstScore;
        private string _secondScore;

        public string Score()
        {
            if (_firstPlayerScoreTime > 0)
            {
                return _scoreLookUp[_firstPlayerScoreTime] + "_Love";
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

        private Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {1,"Fifteen" },
            {2,"Thirty"},
            {3,"Forty"}
        };
    }
}