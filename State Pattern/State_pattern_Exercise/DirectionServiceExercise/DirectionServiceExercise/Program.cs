using System;

namespace DirectionServiceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dirsev = new DirectionService();

            dirsev.CurrTravelMode = new DrivingTravelMode();
            dirsev.getDirection();
            dirsev.getETA();


            dirsev.CurrTravelMode = new BicyclingTravelMode();
            dirsev.getDirection();
            dirsev.getETA();
        }
    }
}
