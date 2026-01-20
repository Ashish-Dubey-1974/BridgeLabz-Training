
using System;
using System.Collections.Generic;

class AadharSorting
{
    static void Main()
    {
        long[] aadhar =
        {
            234567891234,
            123456789012,
            234567890111,
            123456780999,
            234567891200
        };

        Console.WriteLine("Before Sorting:");
        Print(aadhar);

        RadixSort(aadhar);

        Console.WriteLine("\nAfter Sorting:");
        Print(aadhar);

        Console.Write("\nEnter Aadhar to Search: ");
        long key = long.Parse(Console.ReadLine());

        int index = BinarySearch(aadhar, key);
        Console.WriteLine(index != -1 ? $"Found at index {index}" : "Not Found");
    }

    static void RadixSort(long[] arr)
    {
        long max = 0;
        foreach (var n in arr) if (n > max) max = n;

        for (long exp = 1; max / exp > 0; exp *= 10)
            CountSort(arr, exp);
    }

    static void CountSort(long[] arr, long exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        for (int i = 0; i < n; i++)
            count[(arr[i] / exp) % 10]++;

        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int idx = (int)((arr[i] / exp) % 10);
            output[count[idx] - 1] = arr[i];
            count[idx]--;
        }

        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    static int BinarySearch(long[] arr, long key)
    {
        int l = 0, r = arr.Length - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (arr[mid] == key) return mid;
            if (arr[mid] < key) l = mid + 1;
            else r = mid - 1;
        }
        return -1;
    }

    static void Print(long[] arr)
    {
        foreach (var n in arr)
            Console.WriteLine(n);
    }
}
