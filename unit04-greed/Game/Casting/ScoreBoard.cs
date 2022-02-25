using System;
using System.Collections.Generic;


namespace Unit04_greed.Game.Casting
{
    public class ScoreBoard:Actor
    {
//Variables
        private int _score;
        private int _defaultScore;

        //Constructor
        public ScoreBoard()
        {
            SetDefaultScore(0);
        }
        


        //Setters

        //"SetDefault" sets a new default score and resets the current score
        public void SetDefaultScore(int score)
        {
            _defaultScore = score;
            Reset();
        }


        //Returns Default Score
        public void GetScore()
        {

        }
        

        public int GetDefaultScore()
        {
            return _defaultScore;
        }

        // Methods
        public void Reset()
        {
            _score = _defaultScore;
        }

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