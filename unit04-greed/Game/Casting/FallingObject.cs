using System;
using System.Collections.Generic;


namespace Unit04_greed.Game.Casting
{
    public class FallingObject:Actor
    {  


        int _points;
        public FallingObject(int points, string text, Point position, Point velocity)
        {
            _points = points;
            this.text = text;
            this.position = position;
            this.velocity = velocity;
        }
    }
}