using System;
using System.Collections.Generic;
using System.IO;
using Unit06.Game.Casting;
using Unit06.Game.Scripting;
using Unit06.Game.Services;


namespace Unit06.Game.Directing
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
            else if (scene == Constants.NEXT_LEVEL)
            {
                PrepareNextLevel(cast, script);
            }
            else if (scene == Constants.TRY_AGAIN)
            {
                PrepareTryAgain(cast, script);
            }
            else if (scene == Constants.IN_PLAY)
            {
                PrepareInPlay(cast, script);
            }
            else if (scene == Constants.GAME_OVER)
            {
                PrepareGameOver(cast, script);
            }
        }

        private void PrepareNewGame(Cast cast, Script script)
        {
            AddRoom(cast);
            AddRocket(cast);
            AddPlayer(cast);
            AddDebree(cast);
            AddFood(cast);
            AddWater(cast);
            AddScrap(cast);


            AddScreen(cast);

            script.ClearAllActions();
            AddInitActions(script);
            AddLoadActions(script);

            ControlPlayerAction c = new ControlPlayerAction(KeyboardService);
            script.AddAction(Constants.INPUT, c);

            AddUpdateActions(script);
            AddOutputActions(script);
            AddUnloadActions(script);
            AddReleaseActions(script);
        }


        private void PrepareNextLevel(Cast cast, Script script)
        {
            // AddBall(cast);
            // AddBricks(cast);
            // AddRacket(cast);
            // AddDialog(cast, Constants.PREP_TO_LAUNCH);

            // script.ClearAllActions();

            // TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            // script.AddAction(Constants.INPUT, ta);

            // AddOutputActions(script);

            // PlaySoundAction sa = new PlaySoundAction(AudioService, Constants.WELCOME_SOUND);
            // script.AddAction(Constants.OUTPUT, sa);
        }

        private void PrepareTryAgain(Cast cast, Script script)
        {
            // AddBall(cast);
            // AddRacket(cast);
            // AddDialog(cast, Constants.PREP_TO_LAUNCH);

            // script.ClearAllActions();
            
            // TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            // script.AddAction(Constants.INPUT, ta);
            
            // AddUpdateActions(script);
            // AddOutputActions(script);
        }

        private void PrepareInPlay(Cast cast, Script script)
        {
            // ActivateBall(cast);
            // cast.ClearActors(Constants.DIALOG_GROUP);

            // script.ClearAllActions();

            // ControlRacketAction action = new ControlRacketAction(KeyboardService);
            // script.AddAction(Constants.INPUT, action);

            // AddUpdateActions(script);    
            // AddOutputActions(script);
        
        }

        private void PrepareGameOver(Cast cast, Script script)
        {
            // AddBall(cast);
            // AddRacket(cast);
            // AddDialog(cast, Constants.WAS_GOOD_GAME);

            // script.ClearAllActions();

            // TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.NEW_GAME, 5, DateTime.Now);
            // script.AddAction(Constants.INPUT, ta);

            // AddOutputActions(script);
        }

        // -----------------------------------------------------------------------------------------
        // casting methods
        // -----------------------------------------------------------------------------------------

        private void AddPlayer(Cast cast)
        {
            cast.ClearActors(Constants.PLAYER_GROUP);

            int x = Constants.CENTER_X - Constants.PLAYER_WIDTH / 2;
            int y = Constants.GROUND_Y - Constants.PLAYER_HEIGHT;
        
            Point position = new Point(x, y);
            Point size = new Point(Constants.PLAYER_WIDTH, Constants.PLAYER_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.PLAYER_IMAGE);
            Player player = new Player(body, image);

            cast.AddActor(Constants.PLAYER_GROUP, player);
        }

        private void AddRocket(Cast cast)
        {
            cast.ClearActors(Constants.ROCKET_GROUP);

            int x = Constants.ROOM_CENTER_X - Constants.ROCKET_WIDTH / 2;
            int y = Constants.GROUND_Y - (Constants.ROCKET_HEIGHT + Constants.ROCKET_DIST_FROM_GROUND);

            Point position = new Point(x, y);
            Point size = new Point(Constants.ROCKET_WIDTH, Constants.ROCKET_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.ROCKET_IMAGE);
            Rocket rocket = new Rocket(body, image);       

            cast.AddActor(Constants.ROCKET_GROUP, rocket);
        }
        private void AddRoom(Cast cast)
        {
            cast.ClearActors(Constants.ROOM_GROUP);

            Point position = new Point(0, 0);
            Point size = new Point(Constants.ROOM_HEIGHT, Constants.ROOM_WIDTH);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.ROOM_IMAGE);
            Room room = new Room(body, image);

            cast.AddActor(Constants.ROOM_GROUP, room);
        }
  
        private void AddScreen(Cast cast)
        {
            Actor actor = new Actor();
            
            Point position = new Point(0, 0);
            Point size = new Point(Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT);
            Point velocity = new Point(0, 0);

            actor.SetBody(new Body(position, size, velocity));
            cast.AddActor(Constants.SCREEN_GROUP, actor); 
        }

        private void AddDebree(Cast cast)
        {
            cast.ClearActors(Constants.DEBREE_GROUP);

            int x = Constants.ROOM_WIDTH - (Constants.DEBREE_WIDTH + 100);
            int y = Constants.GROUND_Y - Constants.DEBREE_HEIGHT;

            Point position = new Point(x, y);
            Point size = new Point(Constants.DEBREE_WIDTH, Constants.DEBREE_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.DEBREE_IMAGE);
            Item item = new Item(body, image, Constants.DEBREE_VALUE);       

            cast.AddActor(Constants.DEBREE_GROUP, item);
        }


        private void AddScrap(Cast cast)
        {
            cast.ClearActors(Constants.SCRAP_GROUP);

            int x = Constants.ROOM_WIDTH - (Constants.SCRAP_WIDTH + 200);
            int y = Constants.GROUND_Y - Constants.SCRAP_HEIGHT;

            Point position = new Point(x, y);
            Point size = new Point(Constants.SCRAP_WIDTH, Constants.SCRAP_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.SCRAP_IMAGE);
            Item item = new Item(body, image, Constants.SCRAP_VALUE);       

            cast.AddActor(Constants.SCRAP_GROUP, item);
        }

        private void AddFood(Cast cast)
        {
            cast.ClearActors(Constants.FOOD_GROUP);

            int x = Constants.ROOM_WIDTH - (Constants.FOOD_WIDTH + 300);
            int y = Constants.GROUND_Y - Constants.FOOD_HEIGHT;

            Point position = new Point(x, y);
            Point size = new Point(Constants.FOOD_WIDTH, Constants.FOOD_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.FOOD_IMAGE);
            Item item = new Item(body, image, Constants.FOOD_VALUE);       

            cast.AddActor(Constants.FOOD_GROUP, item);
        }


        private void AddWater(Cast cast)
        {
            cast.ClearActors(Constants.WATER_GROUP);

            int x = Constants.ROOM_WIDTH - (Constants.WATER_WIDTH + 400);
            int y = Constants.GROUND_Y - Constants.WATER_HEIGHT;

            Point position = new Point(x, y);
            Point size = new Point(Constants.WATER_WIDTH, Constants.WATER_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.WATER_IMAGE);
            Item item = new Item(body, image, Constants.WATER_VALUE);       

            cast.AddActor(Constants.WATER_GROUP, item);
        }



        // -----------------------------------------------------------------------------------------
        // scriptig methods
        // -----------------------------------------------------------------------------------------

        private void AddInitActions(Script script)
        {
            script.AddAction(Constants.INITIALIZE, new InitializeDevicesAction(AudioService, 
                VideoService));
        }

        private void AddLoadActions(Script script)
        {
            script.AddAction(Constants.LOAD, new LoadAssetsAction(AudioService, VideoService));
        }

        private void AddOutputActions(Script script)
        {
            script.AddAction(Constants.OUTPUT, new StartDrawingAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawRoomAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawRocketAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawPlayerAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawItemsAction(VideoService));
            script.AddAction(Constants.OUTPUT, new EndDrawingAction(VideoService));
        }

        private void AddUnloadActions(Script script)
        {
            script.AddAction(Constants.UNLOAD, new UnloadAssetsAction(AudioService, VideoService));
        }

        private void AddReleaseActions(Script script)
        {
            script.AddAction(Constants.RELEASE, new ReleaseDevicesAction(AudioService, 
                VideoService));
        }

        private void AddUpdateActions(Script script)
        {
            script.AddAction(Constants.UPDATE, new MovePlayerAction());
            script.AddAction(Constants.UPDATE, new MoveScreenAction());
            script.AddAction(Constants.UPDATE, new ApplyGravityAction());
            // script.AddAction(Constants.UPDATE, new CollideBordersAction(PhysicsService, AudioService));
        }
    }
}