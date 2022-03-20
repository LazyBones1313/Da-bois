namespace unit06_game.Game.Casting
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
        
    }
}