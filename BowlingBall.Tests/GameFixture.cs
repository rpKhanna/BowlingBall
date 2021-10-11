using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests {
    [TestClass]
    public class GameFixture {
        Game game;

        [TestInitialize]
        public void Initialize() {
            game = new Game();
        }

        [TestMethod]
        public void Gutter_game_score_should_be_zero_test() {
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void All_frames_with_double_three_test() {
            Roll(game, 3, 20);
            Assert.AreEqual(60, game.GetScore());
        }

        [TestMethod]
        public void Single_strike_test() {
            game.Roll(10);
            Roll(game, 3, 4);
            Roll(game, 0, 14);
            Assert.AreEqual(28, game.GetScore());
        }

        [TestMethod]
        public void Final_frame_strike_test() {
            Roll(game, 0, 18);
            game.Roll(10);
            game.Roll(7);
            game.Roll(2);
            Assert.AreEqual(19, game.GetScore());
        }

        [TestMethod]
        public void All_strike_test() {
            Roll(game, 10, 12);
            Assert.AreEqual(300, game.GetScore());
        }

        [TestMethod]
        public void Single_spare_test() {
            game.Roll(7);
            game.Roll(3);
            game.Roll(4);
            game.Roll(3);
            Roll(game, 0, 16);
            Assert.AreEqual(21, game.GetScore());
        }

        [TestMethod]
        public void All_strike_spare_test() {
            game.Roll(10);
            game.Roll(4);
            game.Roll(6);
            game.Roll(10);
            game.Roll(4);
            game.Roll(6);
            game.Roll(10);
            game.Roll(4);
            game.Roll(6);
            game.Roll(10);
            game.Roll(4);
            game.Roll(6);
            game.Roll(10);
            game.Roll(4);
            game.Roll(6);
            game.Roll(10);
            Assert.AreEqual(200, game.GetScore());
        }

        [TestMethod]
        public void Final_frame_spare_test() {
            Roll(game, 0, 18);
            game.Roll(6);
            Roll(game, 4, 2);
            Assert.AreEqual(14, game.GetScore());
        }

        private void Roll(Game game, int pins, int times) {
            for(int i = 0; i < times; i++) {
                game.Roll(pins);
            }
        }
    }
}
