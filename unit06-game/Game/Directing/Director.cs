using System;
using System.Collections.Generic;
using unit06_game.Game.Casting;
using unit06_game.Game.Scripting;
using unit06_game.Game.Services;



namespace unit06_game.Game.Directing
{
    class Director : ActionCallback
    {
        private Cast cast;
        private Script script;
        private SceneManager sceneManager;
        private VideoService videoService;
        public Director(VideoService videoService)
        {
            this.videoService = videoService;
            this.cast = new Cast();
            this.script = new Script();
            this.sceneManager = new SceneManager();

        }

         /// </inheritdoc>

        public void OnNext(string scene)
        {
            sceneManager.PrepareScene(scene, cast, script);
        }
        public void StartGame()
        {

        }

    }
}
