using BowlingBall.Buisness;
using System.Collections.Generic;
using System.Linq;

namespace BowlingBall {
    /// <summary>
    /// This class contains all the information of the game and returns the score.
    /// </summary>
    public class Game {
        List<int> rolls;
        List<BaseFrame> frames;

        public Game() {
            rolls = new List<int>();
            frames = new List<BaseFrame>();
        }

        /// <summary>
        /// Adds the pins for the roll in the list.
        /// </summary>
        /// <param name="pins">Number of pins for the roll</param>
        public void Roll(int pins) {
            rolls.Add(pins);
        }

        /// <summary>
        /// Calculate the score for the game.
        /// </summary>
        /// <returns></returns>
        public int GetScore() {
            CreateFrames();
            return frames.Select(f => f.Score()).Aggregate((s, a) => s + a);
        }

        /// <summary>
        /// Method that creates the frames list
        /// </summary>
        private void CreateFrames() {
            for(int cnt = 0; cnt < rolls.Count; cnt++) {
                if(frames.Count == 10 || cnt == rolls.Count - 1) {
                    ExtraRoll(cnt);
                } else if(rolls[cnt] == 10) {
                    StrikeFrame(cnt);
                } else if(rolls[cnt] + rolls[cnt + 1] == 10) {
                    SpareFrame(cnt);
                    cnt++;
                } else {
                    OpenFrame(cnt);
                    cnt++;
                }
            }
        }

        /// <summary>
        /// Creates and add an open frame to frames list
        /// </summary>
        /// <param name="frameStartIndex">Frame start index</param>
        private void OpenFrame(int frameStartIndex) {
            frames.Add(new NormalFrame(rolls, frameStartIndex));
        }

        /// <summary>
        /// Creates and add a spare frame to frames list
        /// </summary>
        /// <param name="frameStartIndex">Frame start index</param>
        private void SpareFrame(int frameStartIndex) {
            frames.Add(new SpareFrame(rolls, frameStartIndex));
        }

        /// <summary>
        /// Creates and add a strike frame to frames list
        /// </summary>
        /// <param name="frameStartIndex">Frame start index</param>
        private void StrikeFrame(int frameStartIndex) {
            frames.Add(new StrikeFrame(rolls, frameStartIndex));
        }

        /// <summary>
        /// Creates and add an extra roll to frames list
        /// </summary>
        /// <param name="frameStartIndex">Frame start index</param>
        private void ExtraRoll(int frameStartIndex) {
            frames.Add(new ExtraRoll(rolls, frameStartIndex));
        }
    }
}
