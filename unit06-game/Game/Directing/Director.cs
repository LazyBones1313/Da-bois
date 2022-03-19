using System;
using System.Collections.Generic;
using unit06_game.Game.Casting;
using unit06_game.Game.Scripting;
using unit06_game.Game.Services;



namespace unit06_game.Game.Directing
{
    class Director
    {
        private Cast cast;
        private Script script;
        private SceneManager sceneManager;
        private VideoService videoService;
        public Director()
        {
            this.videoService = videoService;
            this.cast = new Cast();
            this.script = new Script();
            this.sceneManager = new SceneManager();

        }
        public void StartGame()
        {
            
        }

    }
}
