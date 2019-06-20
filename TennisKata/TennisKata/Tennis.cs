using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace TennisKata
{
    public class Tennis

    {
        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        private int _firstPlayerScoreTime;
        private int _secondPlayerScoreTime;

        public string Score()
        {
            if (IsScoreDiff())
            {
                if (IsGamePoint())
                {
                    if (IsAdv())
                    {
                        return AdvScore();
                    }
                    else
                    {
                        return WinScore();
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

        private string WinScore()
        {
            return $"{WhichPlayerLead()}_win";
        }

        private string AdvScore()
        {
            return $"{WhichPlayerLead()}_adv";
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTime - _secondPlayerScoreTime) == 1;
        }

        private bool IsGamePoint()
        {
            return _firstPlayerScoreTime > 3 || _secondPlayerScoreTime > 3;
        }

        private string WhichPlayerLead()
        {
            return _firstPlayerScoreTime > _secondPlayerScoreTime
                ? _firstPlayerName
                : _secondPlayerName;
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

        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
    }
}