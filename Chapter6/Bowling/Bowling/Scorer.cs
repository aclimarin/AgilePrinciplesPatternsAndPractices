namespace Bowling
{
    public class Scorer
    {
        private int _ball;
        private int[] _throws = new int[21];
        private int _currentThrow;

        public void AddThrow(int pins)
        {
            _throws[_currentThrow++] = pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            _ball = 0;
            int score = 0;

            for (int currentFrame = 0
                ; currentFrame < theFrame
                ; currentFrame++)
            {
                if (Strike()) //strike
                {
                    score += 10 + NextTwoBallsForStrike;
                    _ball++;
                }
                else if (Spare())
                {
                    score += 10 + NextBallForSpare;
                    _ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame;
                    _ball += 2;
                }
            }

            return score;
        }

        private int NextTwoBallsForStrike
        {
            get { return _throws[_ball + 1] + _throws[_ball + 2]; }
        }


        private int NextBallForSpare
        {
            get { return _throws[_ball + 2]; }
        }

        private int TwoBallsInFrame
        {
            get { return _throws[_ball] + _throws[_ball + 1]; }
        }

        private bool Strike()
        {
            return _throws[_ball] == 10;
        }

        private bool Spare()
        {
            return _throws[_ball] + _throws[_ball + 1] == 10;
        }
    }
}