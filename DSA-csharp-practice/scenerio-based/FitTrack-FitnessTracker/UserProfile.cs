using System;
using System.Collections.Generic;

namespace FitTrack_FitnessTracker
{
    internal class UserProfile
    {
        public string Name;
        public double Weight;
        public ITrackable[] Workouts = new ITrackable[10];

        public int idx = 0;

        public void AddWorkout(ITrackable workout)
        {
            Workouts[idx++]=workout;
        }

        public void ShowAllWorkouts(double weight)
        {
            Console.WriteLine($"User: {Name}");
            foreach (ITrackable w in Workouts)
            {
                if (w == null) continue;
                w.Track(weight);
                Console.WriteLine($"Calory Burns :");
                //Console.WriteLine("-------------------\n");
            }
        }
    }
}
