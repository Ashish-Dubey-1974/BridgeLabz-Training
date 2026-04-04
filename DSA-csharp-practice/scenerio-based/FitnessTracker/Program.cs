
using System;
using System.Collections.Generic;

namespace FitnessStepTracker
{
    class User
    {
        public string Name { get; set; }
        public int Steps { get; set; }

        public User(string name, int steps)
        {
            Name = name;
            Steps = steps;
        }

        public override string ToString()
        {
            return $"{Name} - {Steps} steps";
        }
    }

    class Leaderboard
    {
        private List<User> users = new List<User>();

        public void AddUser(string name, int steps)
        {
            users.Add(new User(name, steps));
            SortLeaderboard();
        }

        public void UpdateSteps(string name, int steps)
        {
            foreach (var u in users)
            {
                if (u.Name == name)
                {
                    u.Steps += steps;
                    break;
                }
            }
            SortLeaderboard();
        }

        private void SortLeaderboard()
        {
            for (int i = 0; i < users.Count - 1; i++)
            {
                for (int j = 0; j < users.Count - i - 1; j++)
                {
                    if (users[j].Steps < users[j + 1].Steps)
                    {
                        var temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("\n--- Daily Fitness Leaderboard ---");
            int rank = 1;
            foreach (var u in users)
            {
                Console.WriteLine($"{rank++}. {u}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Leaderboard lb = new Leaderboard();
            int choice;

            do
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. Update Steps");
                Console.WriteLine("3. Display Leaderboard");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Steps: ");
                        int steps = int.Parse(Console.ReadLine());
                        lb.AddUser(name, steps);
                        break;

                    case 2:
                        Console.Write("Name: ");
                        string uname = Console.ReadLine();
                        Console.Write("Additional Steps: ");
                        int add = int.Parse(Console.ReadLine());
                        lb.UpdateSteps(uname, add);
                        break;

                    case 3:
                        lb.Display();
                        break;
                }
            } while (choice != 0);
        }
    }
}
