using System;
using System.Collections.Generic;
using Unit04_greed.Game.Casting;
using Unit04_greed.Game.Services;


namespace Unit04_greed.Game.Directing
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;

        private int counter = 0;

        private int frequency = 25;

        
        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection();
            robot.SetVelocity(velocity);

            // ScoreBoard scoreBoard = (ScoreBoard) cast.GetFirstActor("scoreboard");
            // keyboardService.GetUpKey();
            // scoreBoard.Add(keyboardService.test);
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            ScoreBoard scoreBoard = (ScoreBoard) cast.GetFirstActor("scoreboard");
            List<Actor> fallingObjects = cast.GetActors("fallingObject");

            banner.SetText("");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
            int midX = maxX / 2;
            int midY = maxY / 2;
            robot.MoveNext(maxX, maxY);
            foreach (FallingObject fallingObject in fallingObjects)
            {
                if (fallingObject.isFallen(maxY))
                {
                    cast.RemoveActor("fallingObject", fallingObject);
                }
                else
                {
                    fallingObject.MoveNext(maxX, maxY);
                }
                // if object is coliding with player
                int min_x = robot.GetPosition().GetX();
                int min_y = robot.GetPosition().GetY();
                int max_X = 40 + robot.GetPosition().GetX();
                int max_Y = 5 + robot.GetPosition().GetY();
                int min_obj_X = fallingObject.GetPosition().GetX();
                int max_obj_X = fallingObject.GetPosition().GetX() + 1;
                int min_obj_Y = fallingObject.GetPosition().GetY();
                int max_obj_Y = fallingObject.GetPosition().GetY() + 1;


                if (min_obj_X <= max_X && min_obj_X >= min_x && min_obj_Y <= max_Y && min_obj_Y >= min_y)
                {
                    Random random = new Random();
                    int newPos = random.Next(0, maxX);
                    if(fallingObject.GetText() == "*")
                    {
                        scoreBoard.Add(200);
                    }
                    if(fallingObject.GetText() == "O")
                    {
                        scoreBoard.Add(-200);
                    }
                    fallingObject.SetPosition(new Point(newPos, 0));
                }

            }


            //Add Falling Object to cast
            if (counter % frequency == 0)
            {
                //Add Falling Object to cast
                Random random = new Random();
                
                int choice = random.Next(0, 2);
                string text;
                int pointValue;
                if(choice == 0)
                {
                    text = "*";
                    pointValue = 10;
                }
                else
                {
                    text = "O";
                    pointValue = -10;
                }
                FallingObject fallingObject = new FallingObject(text, pointValue);
                int pos = random.Next(0, maxX);
                fallingObject.SetPosition(new Point(pos, 0));
                fallingObject.SetVelocity(new Point(0, 3));
                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);
                Color color = new Color(r, g, b);
                fallingObject.SetColor(color);
                cast.AddActor("fallingObject", fallingObject);
                counter = 0;
            }
            counter++;

            if (scoreBoard.GetScore() <= 0)
            {
                Actor gameOver = cast.GetFirstActor("gameOver");
                gameOver.SetPosition(new Point(midX - 100, midY - 15));
                foreach (FallingObject f in fallingObjects)
                {
                    f.SetVelocity(new Point(0, 0));
                }

            }
            
            // foreach (Actor actor in artifacts)
            // {
            //     if (robot.GetPosition().Equals(actor.GetPosition()))
            //     {
            //         Artifact artifact = (Artifact) actor;
            //         string message = artifact.GetMessage();
            //         banner.SetText(message);
            //     }
            // } 
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }

    }
}