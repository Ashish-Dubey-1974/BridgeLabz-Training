using System;
class InsertionSort
{
    static void Main(){
        int[] arr = {5,6,8,7,1,2,6,9,4};
        Sort(arr);
        Console.WriteLine(string.Join(",",arr));
    }

    static void Sort(int[] arr){
        for(int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i-1;
            while(j>=0 && arr[j] > key)arr[j+1] = arr[j--];
            arr[j+1]=key;
        }
    }
}

// Best Case: O(n) (already sorted)
// Average Case: O(n²)
// Worst Case: O(n²)
// Space: O(1)
// Stable Sort: Yes