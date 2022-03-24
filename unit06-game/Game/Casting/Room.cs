namespace Unit06.Game.Casting
{
    /// <summary>
    /// This is the room/background for the game.
    /// </summary>
    public class Room : Actor
    {
        private Body body;

        private Image image;

        public Room(Body body, Image image, bool debug = false) : base(debug)
        {
            this.body = body;
            this.image = image;
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
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Image GetImage()
        {
            return image;
        }
    }
}

