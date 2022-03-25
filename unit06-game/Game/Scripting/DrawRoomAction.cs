using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawRoomAction : Action
    {
        private VideoService videoService;
        
        public DrawRoomAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Room room = (Room) cast.GetFirstActor(Constants.ROOM_GROUP);
            Actor screen = cast.GetFirstActor(Constants.SCREEN_GROUP);
            Body body = room.GetBody();

            if (room.IsDebug())
            {
                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
            }

            Image image = room.GetImage();
            Point position = body.GetPosition().Subtract(screen.GetBody().GetPosition());
            videoService.DrawImage(image, position);
        }
    }
}