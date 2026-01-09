using System;

namespace FitTrack_FitnessTracker
{
    internal class StrengthWorkout : WorkOut, ITrackable
    {
        public int Sets;
        public int Reps;

        public void Track(double weight)
        {
            Console.WriteLine("Tracking Strength Workout...");
            ShowWorkout();
            Console.WriteLine($"Sets: {Sets}, Reps: {Reps}");
            Console.WriteLine($"Estimated Calories Burned: {CalculateCaloriesBurned(weight)} kcal");
        }
        public double CalculateCaloriesBurned(double weight)
        {
            return Sets * Reps * weight * 0.1;
        }
    }
}
