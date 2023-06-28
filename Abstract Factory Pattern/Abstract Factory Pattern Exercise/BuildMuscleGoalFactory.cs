using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern_Exercise
{
    public class BuildMuscleGoalFactory : GoalFactory
    {
        public MealPlan GetMealPlan()
        {
            return new BuildMuscleMealPlan();
        }

        public WorkoutPlan getWorkoutPlan()
        {
            return new BuildMuscleWorkout();
        }
    }
}
