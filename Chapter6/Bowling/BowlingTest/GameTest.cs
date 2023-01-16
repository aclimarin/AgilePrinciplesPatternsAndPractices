using Bowling;

namespace BowlingTest
{
    public class GameTest
    {
        private Game _game;

        public GameTest()
        {
            _game = new Game();
        }

        [Fact]
        public void TestTwoThrowNoMark()
        {
            _game.Add(4);
            _game.Add(5);
            Assert.Equal(_game.Score, 9);
        }

        [Fact]
        public void TestFuorThrowNoMark()
        {
            _game.Add(5);
            _game.Add(4);
            _game.Add(7);
            _game.Add(2);

            Assert.Equal(_game.Score, 18);
            Assert.Equal(_game.ScoreForFrame(1), 9);
            Assert.Equal(_game.ScoreForFrame(2), 18);
        }

        [Fact]
        public void TestSimpleSpare()
        {
            _game.Add(3);
            _game.Add(7);
            _game.Add(2);

            Assert.Equal(_game.ScoreForFrame(1), 12);
        }

        [Fact]
        public void TestSimpleFrameAfterSpare()
        {
            _game.Add(3);
            _game.Add(7);
            _game.Add(3);
            _game.Add(2);

            Assert.Equal(_game.ScoreForFrame(1), 13);
            Assert.Equal(_game.ScoreForFrame(2), 18);
            Assert.Equal(_game.Score, 18);
        }

        [Fact]
        public void TestSimpleStrike()
        {
            _game.Add(10);
            _game.Add(3);
            _game.Add(6);

            Assert.Equal(_game.ScoreForFrame(1), 19);
            Assert.Equal(_game.Score, 28);
        }

        [Fact]
        public void TestePerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.Add(10);
            }

            Assert.Equal(_game.Score, 300);
        }

        [Fact]
        public void TestEndOfArray()
        {
            for (int i = 0; i < 9; i++)
            {
                _game.Add(0);
                _game.Add(0);
            }
            _game.Add(2);
            _game.Add(8); //spare no 10° quadro
            _game.Add(10); // strike na última posição do array

            Assert.Equal(_game.Score, 20);
        }

        [Fact]
        public void TestSampleGame()
        {   
            _game.Add(1);
            _game.Add(4); 
            _game.Add(4);
            _game.Add(5);
            _game.Add(6);
            _game.Add(4);
            _game.Add(5);
            _game.Add(5);
            _game.Add(10);
            _game.Add(0);
            _game.Add(1);
            _game.Add(7);
            _game.Add(3);
            _game.Add(6);
            _game.Add(4);
            _game.Add(10);
            _game.Add(2);
            _game.Add(8);
            _game.Add(6);

            Assert.Equal(_game.Score, 133);
        }

        [Fact]
        public void TestHeartBreak()
        {
            for (int i = 0; i < 11; i++)
            {
                _game.Add(10);

            }
            _game.Add(9);

            Assert.Equal(_game.Score, 299);
        }

        [Fact]
        public void TestTenthFrameSpare()
        {
            for (int i = 0; i < 9; i++)
            {
                _game.Add(10);

            }
            _game.Add(9);
            _game.Add(1);
            _game.Add(1);

            Assert.Equal(_game.Score, 270);
        }
    }
}
