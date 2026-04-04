using System;
using System.Collections.Generic;

namespace CinemaTime
{
    public class MovieManager
    {
        private List<string> titles = new List<string>();
        private List<string> times = new List<string>();

        public void AddMovie(string title, string time)
        {
            if (!IsValidTime(time))
                throw new InvalidTimeFormatException("Invalid time format: " + time);

            titles.Add(title);
            times.Add(time);
        }

        public void SearchMovie(string keyword)
        {
            try
            {
                bool found = false;
                for (int i = 0; i < titles.Count; i++)
                {
                    if (titles[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{i + 1}. {titles[i]} at {times[i]}");
                        found = true;
                    }
                }
                if (!found)
                    Console.WriteLine("No movie found.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Search index error.");
            }
        }

        public void DisplayAllMovies()
        {
            if (titles.Count == 0)
            {
                Console.WriteLine("No movies scheduled.");
                return;
            }

            for (int i = 0; i < titles.Count; i++)
            {
                Console.WriteLine(string.Format("{0}. {1} - {2}", i + 1, titles[i], times[i]));
            }
        }

        public string[] GenerateReport()
        {
            string[] report = new string[titles.Count];
            for (int i = 0; i < titles.Count; i++)
            {
                report[i] = titles[i] + " @ " + times[i];
            }
            return report;
        }

        private bool IsValidTime(string time)
        {
            if (!TimeSpan.TryParse(time, out TimeSpan t))
                return false;

            return t.Hours < 24 && t.Minutes < 60;
        }
    }
}