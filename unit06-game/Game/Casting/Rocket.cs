namespace Unit06.Game.Casting
{
    /// <summary>
    /// This is the player for the game.
    /// </summary>
    public class Rocket : RoomActor
    {
        // private PopUpLabel rocketMsg;
        private bool repaired = false;

        public Rocket(Body body, Image image, bool debug = false) : base(debug)
        {
            base.SetBody(body);
            base.SetImage(image);
        }

        public bool IsRepaired()
        {
            return repaired;
        }

        public void SetRepaired(bool repaired)
        {
            this.repaired = repaired;
        }
    }
}

