namespace Unit06.Game.Casting
{
    /// <summary>
    /// This is the player for the game.
    /// </summary>
    public class Player : Actor
    {
        private Body body;

        private Image image;

        public Player(Body body, Image image, bool debug = false) : base(debug)
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

        public void MoveLeft()
        {
            Point velocity = new Point(-Constants.PLAYER_MOVE_VELOCITY, 0);
            body.SetVelocity(velocity);
        }

        public void MoveRight()
        {
            Point velocity = new Point(Constants.PLAYER_MOVE_VELOCITY, 0);
            body.SetVelocity(velocity);
        }

        public void Jump()
        {

        }

        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            body.SetVelocity(velocity);
        }
        
    }
}