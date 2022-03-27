using Unit06.Game.Casting;

namespace Unit06.Game.Scripting
{
    public class ApplyGravityAction : Action
    {
        public ApplyGravityAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Player player = (Player) cast.GetFirstActor(Constants.PLAYER_GROUP);
            Body body = player.GetBody();
            if (player.IsAirBorne())
            {  
                Point v = body.GetVelocity().Add(new Point(0, Constants.GRAVITY_ACCELERATION));
                if (body.GetPosition().GetY() + Constants.PLAYER_HEIGHT >= Constants.GROUND_Y)
                {
                    player.Land(Constants.GROUND_Y - Constants.PLAYER_HEIGHT);
                }
                else
                {
                    player.GetBody().SetVelocity(v);
                }


            }
            
      
        }
    }
}