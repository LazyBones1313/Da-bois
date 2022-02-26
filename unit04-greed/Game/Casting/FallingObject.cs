using System;
using System.Collections.Generic;


namespace Unit04_greed.Game.Casting
{
    public class FallingObject:Actor
    {  


        int _points;
        public FallingObject(string text, int points)
        {
            _points = points;
            this.text = text;
        }

        public bool isFallen(int maxY)
        {
            int y = GetPosition().GetY();
            int dy = GetVelocity().GetY();
            return maxY <= y + dy ? true : false;
        }
    }
}