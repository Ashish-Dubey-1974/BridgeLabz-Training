using System;

namespace FitTrack_FitnessTracker
{
    internal class CardioWorkout : WorkOut, ITrackable
    {
        public int Distance;

        public void Track(double weight)
        {
            Console.WriteLine("Tracking Cardio Workout...");
            ShowWorkout();
            Console.WriteLine($"Distance: {Distance} km");
            Console.WriteLine($"Estimated Calories Burned: {CalculateCaloriesBurned(weight)} kcal");
        }
        private double CalculateCaloriesBurned(double weight)
        {
            return Distance * weight * 1.036;
        }
    }
}
