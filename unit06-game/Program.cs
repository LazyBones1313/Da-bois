using unit06_game.Game.Directing;

namespace unit06_game
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Director director = new Director(SceneManager.VideoService);
            director.StartGame();
        }
    }
}
