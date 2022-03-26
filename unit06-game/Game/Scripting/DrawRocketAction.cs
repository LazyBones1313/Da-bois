using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawRocketAction : Action
    {
        private VideoService videoService;
        
        public DrawRocketAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Rocket rocket = (Rocket) cast.GetFirstActor(Constants.ROCKET_GROUP);
            Actor screen = cast.GetFirstActor(Constants.SCREEN_GROUP);
            Body body = rocket.GetBody();

            if (rocket.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Image image = rocket.GetImage();
            Point position = body.GetPosition().Subtract(screen.GetBody().GetPosition());
            videoService.DrawImage(image, position);
        }
    }
}