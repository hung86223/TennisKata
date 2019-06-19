using System.Collections.Generic;

namespace TennisKata
{
    public class Tennis

    {
        public Tennis(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        private int _firstPlayerScoreTime;
        private int _secondPlayerScoreTime;

        public string Score()
        {
            if (IsScoreDiff())
            {
                if (_firstPlayerScoreTime > 3)
                {
                    if (_firstPlayerScoreTime - _secondPlayerScoreTime == 1)
                    {
                        return $"{_firstPlayerName}_adv";
                    }
                }

                return NormalScore();
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTime >= 3;
        }

        private string SameScore()
        {
            return _scoreLookUp[_firstPlayerScoreTime] + "_All";
        }

        private string NormalScore()
        {
            return _scoreLookUp[_firstPlayerScoreTime] + "_" + _scoreLookUp[_secondPlayerScoreTime];
        }

        private bool IsScoreDiff()
        {
            return _firstPlayerScoreTime != _secondPlayerScoreTime;
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

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty"},
            {3,"Forty"}
        };

        private string _firstPlayerName;
    }
}