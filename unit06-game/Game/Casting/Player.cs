namespace Unit06.Game.Casting
{
    /// <summary>
    /// This is the player for the game.
    /// </summary>
    public class Player : Actor
    {
        private bool airBorne = false;

        public Player(Body body, Image image, bool debug = false) : base(debug)
        {
            base.SetBody(body);
            base.SetImage(image);
        }

        public void MoveLeft()
        {
            base.GetBody().GetVelocity().SetX(-Constants.PLAYER_MOVE_VELOCITY);
        }

        public void MoveRight()
        {
            base.GetBody().GetVelocity().SetX(Constants.PLAYER_MOVE_VELOCITY);
        }
        public void StopMoving()
        {
            base.GetBody().GetVelocity().SetX(0);
        }
        
        public void Jump()
        {
            if (!IsAirBorne())
            {
                SetAirBorne(true);
                base.GetBody().GetVelocity().SetY(-Constants.PLAYER_JUMP_VELOCITY);
            }
        }

        public void Land(int y)
        {
                    SetAirBorne(false);
                    GetBody().GetVelocity().SetY(0);
                    GetBody().GetPosition().SetY(y);
        }

        private void SetAirBorne(bool airBorne)
        {
            this.airBorne = airBorne;
        }

        public bool IsAirBorne()
        {
            return airBorne;
        }

    }
}