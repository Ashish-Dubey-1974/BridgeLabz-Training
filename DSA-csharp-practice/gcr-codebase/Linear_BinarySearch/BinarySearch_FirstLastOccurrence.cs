
using System;

class FirstLastOccurrence
{
    static int FindFirst(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, res = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                res = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return res;
    }

    static int FindLast(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, res = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                res = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return res;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4 };
        int target = 2;
        Console.WriteLine("First: " + FindFirst(arr, target));
        Console.WriteLine("Last: " + FindLast(arr, target));
    }
}
