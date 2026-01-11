using System;
class QuickSort
{
    static void Main(){
        QuickSort obj = new QuickSort();
        int[] arr = {5,6,8,7,1,2,6,9,4};
        obj.Sort(arr,0,arr.Length-1);
        Console.WriteLine(string.Join(",",arr));
    }
    void Sort(int[] arr,int low,int high)
    {
        if (low < high)
        {
            int pivotIdx = Partition(arr,low,high);
            Sort(arr,low,pivotIdx-1);
            Sort(arr,pivotIdx+1,high);
        }
    }
    int Partition(int[] arr,int low,int high)
    {
        int pivot = arr[high];
        int i=low;
        for(int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
                i++;
            }
        }int temp = arr[i];
        arr[i] = arr[high];
        arr[high] = temp;
        return i;
    }
    
}