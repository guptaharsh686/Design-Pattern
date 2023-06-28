using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var homePage = new HomePage();
            homePage.setGoal(new BuildMuscleGoalFactory());
            homePage.setGoal(new WeightLossGoalFactory());

        }
    }
}
