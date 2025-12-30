class HarryAge
{
    public static void Main(string[] birthYear)
    {
        int a = 0;
        if (birthYear.Length != 1)
        {
            Console.WriteLine("Enter Harry's Birth year...");
            a = int.Parse(Console.ReadLine());
        }
        else a=int.Parse(birthYear[0]);
        Console.WriteLine($"Harry's age in 2024 is {2024-a}");
    }
}