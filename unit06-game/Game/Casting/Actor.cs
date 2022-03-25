namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Actor
    {
        private bool debug;
        private Body body;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Actor(bool debug = false)
        {
            this.debug = debug;
        }

        /// <summary>
        /// Whether or not the actor is being debugged.
        /// </summary>
        /// <returns>True if being debugged; false if othewise.</returns>
        public bool IsDebug()
        {
            return debug;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public void SetBody(Body body)
        {
            this.body = body;
        }
    }
}