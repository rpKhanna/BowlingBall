using System.Collections.Generic;

namespace BowlingBall.Buisness {
    /// <summary>
    /// Extra roll class to handle extra rolls played by player for 10th frame in the game.
    /// </summary>
    public class ExtraRoll : BaseFrame {
        public ExtraRoll(List<int> rolls, int frameStart) : base(rolls, frameStart) {
        }

        /// <summary>
        /// This method of score returns 0 because score for extra roll is calculated in Spart or Strike frame.
        /// </summary>
        /// <returns>0</returns>
        public override int Score() {
            return 0;
        }
    }
}
