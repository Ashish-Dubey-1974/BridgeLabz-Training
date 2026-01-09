using System;

namespace FitTrack_FitnessTracker
{
    internal class WorkOut
    {
        public string WorkoutName;
        public int Duration;

        public void ShowWorkout()
        {
            Console.WriteLine($"Workout: {WorkoutName}");
            Console.WriteLine($"Duration: {Duration} minutes");
        }
    }
}
