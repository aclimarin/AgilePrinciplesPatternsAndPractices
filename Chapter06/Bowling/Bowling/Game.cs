namespace Bowling
{
    public class Game
    {
        private int _currentFrame = 0;
        private bool _isFirstThrow = true;
        private Scorer _scorer = new Scorer();

        public int Score
        {
            get { return ScoreForFrame(_currentFrame); }
        }

        public void Add(int pins)
        {
            _scorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if (LastBallInFrame(pins))
                AdvanceFrame();
            else
                _isFirstThrow = false;
        }

        private bool LastBallInFrame(int pins)
        {
            return Strike(pins) || !_isFirstThrow;
        }

        private bool Strike(int pins)
        {
            return _isFirstThrow && pins == 10;
        }

        private void AdvanceFrame()
        {
            _currentFrame++;

            if (_currentFrame > 10)
                _currentFrame = 10;
        }

        public int ScoreForFrame(int theFrame)
        {
            return _scorer.ScoreForFrame(theFrame);
        }
    }
}
