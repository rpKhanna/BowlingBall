using System;
using System.Collections.Generic;

namespace BowlingBall.Buisness {
    /// <summary>
    /// This class handles the frame where the player achieves 10 pins with two rolls.
    /// </summary>
    public class SpareFrame : BaseFrame {

        public SpareFrame(List<int> rolls, int frameStart) : base(rolls, frameStart) {
        }

        /// <summary>
        /// This method adds 10 for this frame along with next roll's pins and returns the sum.
        /// </summary>
        /// <returns>Score for this frame</returns>
        override public int Score() {
            return 10 + rolls[frameStart + 2];
        }
    }
}
