using System;
class MaxHeap
{
    int[] heap;
    int Length;
    int index=0;

    public static void Main()
    {
        MaxHeap q = new MaxHeap();
        q.Length = 5;
        q.heap = new int[q.Length];
        q.Add(5);
        q.Add(2);
        q.Add(4);
        q.Add(1);
        q.Add(7);
        q.Add(3);
        while (!q.isEmpty())
        {
            Console.WriteLine(q.Remove()+" ");
        }
    }

    void Add(int element)
    {
        if (index == Length)
        {
            Console.WriteLine("Queue is Full");
            return;
        }
        heap[index] = element;
        UpHeapify(index++);
    }

    int Remove(){
        if(isEmpty())return -1;
        int min = heap[0];
        heap[0] = heap[--index];
        DownHeapify(0);
        return min;
    }

    void UpHeapify(int idx)
    {
        while (idx > 0)
        {
            int parent = (idx-1)/2;
            if(heap[parent]>=heap[idx])break;
            swap(parent, idx);
            idx=parent;
        }
        
    }

    void DownHeapify(int idx)
    {
        while (idx < index)
        {
            int left = idx*2+1;
            int right = idx*2+2;
            int smallest = idx;
            if(left<Length && heap[smallest]<heap[left])smallest=left;
            if(right<Length && heap[smallest]<heap[right])smallest=right;
            if(smallest==idx)break;
            swap(smallest,idx);
            idx=smallest;
        }
    }
    void swap(int idx1,int idx2)
    {
        int temp = heap[idx1];
        heap[idx1] = heap[idx2];
        heap[idx2] = temp;
    }

    bool isEmpty()=>index==0;
}