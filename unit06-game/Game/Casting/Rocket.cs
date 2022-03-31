namespace Unit06.Game.Casting
{
    /// <summary>
    /// This is the player for the game.
    /// </summary>
    public class Rocket : RoomActor
    {

        public Rocket(Body body, Image image, bool debug = false) : base(debug)
        {
            base.SetBody(body);
            base.SetImage(image);
        }
    }
}

