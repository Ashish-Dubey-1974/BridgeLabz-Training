using System;

class StudentsData
{
    static float[] Scores;
    static int n;
    static Random r = new Random();
    static int MaxMarks = 100;
    static int MinMarks = 0;

    // STATIC CONSTRUCTOR
    static StudentsData()
    {
        Console.WriteLine("\n===========================Application is Started===============>");
        n = TakeInput();
        if (n <= 0)
        {
            Console.WriteLine("Program terminated.");
            Environment.Exit(0);
        }

        Scores = new float[n];
        Console.WriteLine("Enter the scores for students:");

        for (int i = 0; i < n; i++)
        {
            Scores[i] = TakeScore(i + 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("\n===========================Data Received ===============>");
        Student();
    }

    // ================= INPUT METHODS =================

    static int TakeInput()
    {
        int n;
        Console.Write("Enter number of students: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n > 0)
                    return n;
            }
            Console.WriteLine("Invalid input. Try again.");
        }
    }

    static float TakeScore(int index)
    {
        float score;
        while (true)
        {
            Console.Write("Enter score of student " + index + ": ");
            if (float.TryParse(Console.ReadLine(), out score))
            {
                if (score >= MinMarks && score <= MaxMarks)
                    return score;
            }
            Console.WriteLine("Invalid score. Try again.\nPlease Enter Score between 0-100");
        }
    }

    // ================= LOGIC METHODS =================

    static float CalculateAverage()
    {
        float sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += Scores[i];
        }
        return sum / n;
    }

    static void FindMinMax()
    {
        float min = Scores[0];
        float max = Scores[0];

        for (int i = 1; i < n; i++)
        {
            if (Scores[i] < min) min = Scores[i];
            if (Scores[i] > max) max = Scores[i];
        }

        Console.WriteLine("Lowest Score: " + min);
        Console.WriteLine("Highest Score: " + max);
    }

    static void Student()
    {
        while(true){
            Console.WriteLine("\n=============================================select form Menu=====================================>");
            Console.WriteLine("\n1 for Average Score\n2 for find Minimum and Miximum Marks of student\n3 for finding the scores above from AVG\n4 for exit");
            int input = int.Parse(Console.ReadLine());
            if(input==1)Console.WriteLine("Average Score: " + CalculateAverage());
            else if(input==2)FindMinMax();
            else if (input == 3)
            {
                float avg = CalculateAverage();
                Console.WriteLine("Scores above average:");
                for (int i = 0; i < n; i++)
                {
                    if (Scores[i] > avg)Console.WriteLine(Scores[i]);
                }
            }else return;
        }
    }
}
