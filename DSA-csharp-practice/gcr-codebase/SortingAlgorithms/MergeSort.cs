using System;
class MergeSort{
    static void Main(){
        int[] arr = {5,6,8,7,1,2,6,9,4};
        Sort(arr,0,arr.Length-1);
        Console.WriteLine(string.Join(",",arr));
    }
    static void Sort(int[] arr,int st,int ed){
        if(st>=ed)return;
        int mid = (st+ed)/2;
        Sort(arr,st,mid);
        Sort(arr,mid+1,ed);
        Merge(arr,st,ed,mid);
    }
    static void Merge(int[] arr,int st,int ed,int mid){
        int len1 = mid-st+1;
        int len2 = ed-mid;
        int[] left = new int[len1];
        int[] right = new int[len2];
        for(int i=0;i<len1;i++)left[i] = arr[st+i];
        for(int i=0;i<len2;i++)right[i] = arr[mid+1+i];
        int idx1=0,idx2=0,k=st;
        while(idx1<len1 && idx2<len2){
            if(left[idx1]<=right[idx2])arr[k++] = left[idx1++];
            else arr[k++] = right[idx2++];
        }
        while(idx1<len1)arr[k++] = left[idx1++];
        while(idx2<len2)arr[k++] = right[idx2++];
    }
}