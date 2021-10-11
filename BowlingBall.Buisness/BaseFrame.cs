using System.Collections.Generic;

namespace BowlingBall.Buisness {
    /// <summary>
    /// Base class for all the frames.
    /// </summary>
    abstract public class BaseFrame {
        protected List<int> rolls;
        protected int frameStart;

        /// <summary>
        /// Constructor to initialize list and framestart index.
        /// </summary>
        /// <param name="rolls">List of rolls</param>
        /// <param name="frameStart">Frame start index</param>
        public BaseFrame(List<int> rolls, int frameStart) {
            this.rolls = rolls;
            this.frameStart = frameStart;
        }

        /// <summary>
        /// Method to be implemented by every derived classes.
        /// </summary>
        /// <returns>Score for the particular frame</returns>
        abstract public int Score();
    }
}
