using System;
class SelectionSort
{
    static void Main(){
        int[] arr = {5,6,8,7,1,2,6,9,4};
        Sort(arr);
        Console.WriteLine(string.Join(",",arr));
    }

    static void Sort(int[] arr){
        for(int i = 0; i < arr.Length; i++){
            int min = i;
            for(int j = i+1; j < arr.Length; j++){
                if (arr[j] < arr[min]){
                    min=j;
                }
            }int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }
}