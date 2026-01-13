using System;

namespace CinemaTime
{
    class Program
    {
        static void Main()
        {
            MovieManager manager = new MovieManager();

            while (true)
            {
                Console.WriteLine("\n--- CinemaTime Menu ---");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. View All Movies");
                Console.WriteLine("3. Search Movie");
                Console.WriteLine("4. Print Report");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    if (choice == 1)
                    {
                        Console.Write("Enter movie title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter show time (HH:MM): ");
                        string time = Console.ReadLine();

                        manager.AddMovie(title, time);
                        Console.WriteLine("Movie added successfully.");
                    }
                    else if (choice == 2)
                    {
                        manager.DisplayAllMovies();
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Enter keyword: ");
                        string key = Console.ReadLine();
                        manager.SearchMovie(key);
                    }
                    else if (choice == 4)
                    {
                        string[] report = manager.GenerateReport();
                        Console.WriteLine("---- Printable Report ----");
                        foreach (string r in report)
                            Console.WriteLine(r);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (InvalidTimeFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}