using System;
using FitTrack_FitnessTracker;

class Program
{
    static UserProfile[] users = new UserProfile[100];
    static int userCount = 0;
    static void Main()
    {
        Console.WriteLine("-------------Welcome To Fitness-Tracker---------");
        UserProfile user;
        CardioWorkout workout;
        StrengthWorkout strengthworkout;
        while (true)
        {
            Console.WriteLine("\n-----------------Home Page------------------------");
            Console.WriteLine("Menu ------");
            Console.WriteLine("press 1. To Add User ");
            Console.WriteLine("Press 2. To Track All Users");
            Console.WriteLine("Press 3. To Exit");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Enter User Name---->");
                string name = Console.ReadLine();
                Console.WriteLine("Enter User Weight in kgs---->");
                double weight = double.Parse(Console.ReadLine());
                user = new UserProfile();
                user.Name = name;
                user.Weight = weight;
                while (true)
                {
                    Console.WriteLine("\nPress 1. To Add Cardio Workout");
                    Console.WriteLine("Press 2. To Add Strength Workout");
                    Console.WriteLine("Press 3. To Go Back to Home Page");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        workout = new CardioWorkout();
                        Console.WriteLine("Enter Workout Name--->");
                        workout.WorkoutName = Console.ReadLine();
                        Console.WriteLine("Enter Duration in minutes--->");
                        workout.Duration = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Distance in km--->");
                        workout.Distance = int.Parse(Console.ReadLine());
                        user.AddWorkout(workout);
                    }
                    else if (choice == 2)
                    {
                        strengthworkout = new StrengthWorkout();
                        Console.WriteLine("Enter Workout Name--->");
                        strengthworkout.WorkoutName = Console.ReadLine();
                        Console.WriteLine("Enter Duration in minutes--->");
                        strengthworkout.Duration = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Sets--->");
                        strengthworkout.Sets = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Reps--->");
                        strengthworkout.Reps = int.Parse(Console.ReadLine());
                        user.AddWorkout(strengthworkout);
                    }
                    else
                    {
                        break;
                    }
                }
                users[userCount++] = user;
            }
            else if (input == 2)
            {
                if (userCount == 0)
                {
                    Console.WriteLine("No User Present");
                    break;
                }
                foreach (UserProfile u in users)
                {
                    if (u == null)break;
                    else u.ShowAllWorkouts(u.Weight);
                }
            }
            else
            {
                break;
            }
        }
    }
}
