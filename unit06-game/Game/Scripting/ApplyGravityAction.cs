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
            player.FallOn(Constants.GROUND_Y, Constants.GRAVITY_ACCELERATION);
            
      
        }
    }
}