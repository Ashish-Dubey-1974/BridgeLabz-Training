using System;
class BubbleSort
{

    static void Main()
    {
        int[] arr = {3,5,2,4,5,1,5,5,1,21,6,5};
        Sort(arr);
        Console.WriteLine(string.Join(",",arr));
    }
    static void Sort(int[] arr)
    {
        for(int i = 0; i < arr.Length-1; i++)
        {
            for(int j = 0; j < arr.Length-i-1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }
}