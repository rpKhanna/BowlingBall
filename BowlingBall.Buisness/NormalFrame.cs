using System.Collections.Generic;

namespace BowlingBall.Buisness {
    /// <summary>
    /// Normal frame class to handle frame where player couldn't achieve 10 pins in both the rolls.
    /// </summary>
    public class NormalFrame : BaseFrame {

        public NormalFrame(List<int> rolls, int frameStart) : base(rolls, frameStart) {
        }

        /// <summary>
        /// Score method calculates and returns pins from both the rolls.
        /// </summary>
        /// <returns>Score for this frame</returns>
        override public int Score() {
            return rolls[frameStart] + rolls[frameStart + 1];
        }
    }
}
