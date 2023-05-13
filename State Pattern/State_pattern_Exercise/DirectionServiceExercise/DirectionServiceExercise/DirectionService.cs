using System;
using System.Collections.Generic;
using System.Text;

namespace DirectionServiceExercise
{
    class DirectionService
    {
        private TravelMode currTravelMode;

        internal TravelMode CurrTravelMode { get => currTravelMode; set => currTravelMode = value; }

        public void getETA()
        {
            currTravelMode.getETA();
        }

        public void getDirection()
        {
            currTravelMode.getDirection();
        }
    }
}
