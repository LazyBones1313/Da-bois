using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point s1_direction = new Point(Constants.CELL_SIZE, 0);
        private Point s2_direction2 = new Point(-Constants.CELL_SIZE, 0);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            //Get Snakes
            List<Actor> snakes = cast.GetActors("snake");

            //Set Snake head direction for each snake
            SetDirectionFromKey(snakes[0], "a", "d", "w", "s");
            SetDirectionFromKey(snakes[1], "j", "l", "i", "k");
        }

        // Sets Snake direction from key
        private void SetDirectionFromKey(Actor actor, string leftKey, string rightKey, string upKey, string downKey)
        {
            // left
            if (keyboardService.IsKeyDown(leftKey))
            {
                actor.SetVelocity(new Point(-Constants.CELL_SIZE, 0));
            }

            // right
            if (keyboardService.IsKeyDown(rightKey))
            {
                actor.SetVelocity(new Point(Constants.CELL_SIZE, 0));
            }

            // up
            if (keyboardService.IsKeyDown(upKey))
            {
                actor.SetVelocity(new Point(0, -Constants.CELL_SIZE));
            }

            // down
            if (keyboardService.IsKeyDown(downKey))
            {
                actor.SetVelocity(new Point(0, Constants.CELL_SIZE));
            }
        }
    }
}