using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern_Exercise
{
    public class WeightLossGoalFactory : GoalFactory
    {
        public MealPlan GetMealPlan()
        {
            return new WeightLossMealPlan();
        }

        public WorkoutPlan getWorkoutPlan()
        {
            return new WeightLossWorkout();
        }
    }
}
