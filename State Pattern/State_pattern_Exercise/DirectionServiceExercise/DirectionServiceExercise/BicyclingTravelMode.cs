using System;
using System.Collections.Generic;
using System.Text;

namespace DirectionServiceExercise
{
    public class BicyclingTravelMode : TravelMode
    {
        public override void getDirection()
        {
            Console.WriteLine("Calculating Direction Bycicling");
        }

        public override void getETA()
        {
            Console.WriteLine("Calculating Direction Bicycling");
        }
    }
}
