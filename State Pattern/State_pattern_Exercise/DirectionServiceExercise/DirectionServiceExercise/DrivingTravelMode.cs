using System;
using System.Collections.Generic;
using System.Text;

namespace DirectionServiceExercise
{
    public class DrivingTravelMode : TravelMode
    {
        public override void getDirection()
        {
            Console.WriteLine("Calculating Direction Driving");
        }

        public override void getETA()
        {
            Console.WriteLine("Calculating ETA Sriving");
        }
    }
}
