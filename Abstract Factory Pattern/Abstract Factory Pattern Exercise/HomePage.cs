using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Pattern_Exercise
{
    public class HomePage
    {
        private WorkoutPlan workoutPlan;
        private MealPlan mealPlan;

        public void setGoal(GoalFactory goal)
        {
            
            workoutPlan = goal.getWorkoutPlan();
            mealPlan = goal.GetMealPlan();
            Console.WriteLine(workoutPlan);
            Console.WriteLine(mealPlan);

        }
    }
}
