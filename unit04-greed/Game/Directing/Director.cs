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
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> fallingObjects = cast.GetActors("fallingObject");

            banner.SetText("");
            int maxX = videoService.GetWidth();
            int maxY = videoService.GetHeight();
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

            }


            //Add Falling Object to cast
            if (counter % frequency == 0)
            {
                //Add Falling Object to cast
                Random r = new Random();
                
                int choice = r.Next(0, 2);
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
                fallingObject.SetPosition(new Point(0, 0));
                fallingObject.SetVelocity(new Point(0, 3));

                cast.AddActor("fallingObject", fallingObject);
                counter = 0;
            }
            counter++;
            
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