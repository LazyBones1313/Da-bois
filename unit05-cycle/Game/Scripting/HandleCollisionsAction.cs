using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                // HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            //Variables
            List<Actor> snakes = cast.GetActors("snake");
            List<Actor> bodies = new List<Actor>();

            //Add snake bodies to "bodies" list
            foreach (Snake snake in snakes)
            {
                bodies.AddRange(snake.GetBody());
            }

            //Check if Segments match head
            foreach (Actor segment in bodies)
            {
                foreach(Snake snake in snakes)
                {
                    if (segment.GetPosition().Equals(snake.GetHead().GetPosition()))
                    {
                        snake.SetHeadColor(Constants.LIGHT_GRAY);
                        snake.SetColor(Constants.GRAY);
                        isGameOver = true;
                    }
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                 // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetFontSize(45);
                message.SetPosition(position);
                cast.AddActor("messages", message);
            }
        }

    }
}