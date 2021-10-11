using System.Collections.Generic;

namespace BowlingBall.Buisness {
    /// <summary>
    /// This class handles the strike frame where the player achieves all 10 pins in first roll.
    /// </summary>
    public class StrikeFrame : BaseFrame {

        public StrikeFrame(List<int> rolls, int frameStart) : base(rolls, frameStart) {
        }

        /// <summary>
        /// Sums up 10 for this frame plus pins from next two rolls and returns the score.
        /// </summary>
        /// <returns>Returns score for this frame</returns>
        override public int Score() {
            return 10 + rolls[frameStart + 1] + rolls[frameStart + 2];
        }
    }
}
