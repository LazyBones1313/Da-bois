namespace Unit06.Game.Casting
{
    /// <summary>
    /// This is the player for the game.
    /// </summary>
    public class Player : Actor
    {

        public Player(Body body, Image image, bool debug = false) : base(debug)
        {
            base.SetBody(body);
            base.SetImage(image);
        }

        public void MoveLeft()
        {
            Point velocity = new Point(-Constants.PLAYER_MOVE_VELOCITY, 0);
            base.GetBody().SetVelocity(velocity);
        }

        public void MoveRight()
        {
            Point velocity = new Point(Constants.PLAYER_MOVE_VELOCITY, 0);
            base.GetBody().SetVelocity(velocity);
        }

        public void Jump()
        {

        }

        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            base.GetBody().SetVelocity(velocity);
        }
        
    }
}