using System;
using System.Collections.Generic;
using System.IO;
using unit06_game.Game.Casting;
using unit06_game.Game.Scripting;
using unit06_game.Game.Services;


namespace unit06_game.Game.Directing
{
    public class SceneManager
    {
        public static AudioService AudioService = new RaylibAudioService();
        public static KeyboardService KeyboardService = new RaylibKeyboardService();
        public static MouseService MouseService = new RaylibMouseService();
        public static PhysicsService PhysicsService = new RaylibPhysicsService();
        public static VideoService VideoService = new RaylibVideoService(Constants.GAME_NAME,
            Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT, Constants.BLACK);

        public SceneManager()
        {
        }

        public void PrepareScene(string scene, Cast cast, Script script)
        {
            if (scene == Constants.NEW_GAME)
            {
                PrepareNewGame(cast, script);
            }
            // else if (scene == Constants.NEXT_LEVEL)
            // {
            //     PrepareNextLevel(cast, script);
            // }
            // else if (scene == Constants.TRY_AGAIN)
            // {
            //     PrepareTryAgain(cast, script);
            // }
            // else if (scene == Constants.IN_PLAY)
            // {
            //     PrepareInPlay(cast, script);
            // }
            // else if (scene == Constants.GAME_OVER)
            // {
            //     PrepareGameOver(cast, script);
            // }
        }

        private void PrepareNewGame(Cast cast, Script script)
        {
            // Code that sets up screen for a new game
            

        }






    }
}