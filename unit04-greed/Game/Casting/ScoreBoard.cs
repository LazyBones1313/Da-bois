using System;
using System.Collections.Generic;


namespace Unit04_greed.Game.Casting
{
    public class ScoreBoard:Actor
    {
    //Variables
        private int _score;

        //Constructor
        public ScoreBoard()
        {
            SetScore(1000);
        }
        


        //Setters

        //"SetDefault" sets a new default score and resets the current score
        public void SetScore(int score)
        {
            _score = score;
        }


        //Returns Default Score
        public int GetScore()
        {
            return _score;
        }
        



        // Methods


        //"Add" adds to the current score. Value can be positive or negative.
        //This method will not allow the score to go below zero.
        public void Add(int points)
        {
            if (_score + points <= 0)
            {
                _score = 0;
            }
            else
            {
                _score += points;
            }
            text = $"Scoore: {_score}";
        }

        //"IsZero" checks if the current score is zero.
        public bool IsZero()
        {
            if (_score == 0)
            {
                return true;
            }
            else
            {
                return false;
            }        
        }
    }
}