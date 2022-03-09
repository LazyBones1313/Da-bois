using Unit05.Game;
using Unit05.Game.Casting;
using Unit05.Game.Directing;
using Unit05.Game.Scripting;
using Unit05.Game.Services;


namespace Unit05
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            //Create Snakes
            Snake s1 = new Snake();
            int s1x = 0;
            int s1y = Constants.MAX_Y - Constants.CELL_SIZE;
            s1.SetPosition(new Point(s1x, s1y));
            s1.SetHeadColor(Constants.BLUE);
            s1.SetSegmentsColor(Constants.CYAN);
            s1.PrepareBody();

            Snake s2 = new Snake();
            int s2x = Constants.MAX_X - Constants.CELL_SIZE;
            int s2y = 0;
            s2.SetPosition(new Point(s2x, s2y));
            s2.SetHeadColor(Constants.RED);
            s2.SetSegmentsColor(Constants.ORANGE);
            s2.PrepareBody();

            // create the cast
            Cast cast = new Cast();
            cast.AddActor("snake", s1);
            cast.AddActor("snake", s2);
            cast.AddActor("score", new Score());



            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            // create the script
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}
