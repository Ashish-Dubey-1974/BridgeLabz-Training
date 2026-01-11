using System;

class CountingSort
{
    static void Main()
    {
        int[] ages = { 12, 15, 10, 18, 14, 12, 16, 10 };

        Sort(ages, 10, 18);

        Console.WriteLine("Counting Sort:");
        Console.WriteLine(string.Join(", ", ages));
    }

    static void Sort(int[] arr, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];

        for (int i = 0; i < arr.Length; i++)
            count[arr[i] - min]++;

        int index = 0;
        for (int i = 0; i < range; i++)
        {
            while (count[i]-- > 0)
            {
                arr[index++] = i + min;
            }
        }
    }
}
