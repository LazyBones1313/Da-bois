namespace Unit06.Game.Casting
{
    /// <summary>
    /// Stores stats info for the game.
    /// </summary>
    public class Stats : Actor
    {
        private int lives;
        private int scrap;

        /// <summary>
        /// Constructs a new instance stats.
        /// </summary>
        public Stats(int lives = 6, int scrap = 0, bool debug = false) : base(debug)
        {
            this.lives = lives;
            this.scrap = scrap;
        }


        /// <summary>
        /// Adds an extra life.
        /// </summary>
        public void AddLives(int lives)
        {
            this.lives += lives;
        }

        /// <summary>
        /// Adds a scrap piece.
        /// </summary>
        public void AddScrap()
        {
            scrap++;
        }

        /// <summary>
        /// Gets the lives.
        /// </summary>
        /// <returns>The lives.</returns>
        public int GetLives()
        {
            return lives;
        }

        /// <summary>
        /// Gets the scrap count.
        /// </summary>
        /// <returns>The scrap.</returns>
        public int GetScrapCount()
        {
            return scrap;
        }

        /// <summary>
        /// Removes a life.
        /// </summary>
        public void RemoveLives(int lives)
        {
            this.lives -= lives;
            if (this.lives <= 0)
            {
                this.lives = 0;
            }
        }
        
    }
}