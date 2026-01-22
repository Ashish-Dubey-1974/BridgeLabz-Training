class DuplicateUsingHashing
{
    public static void Main()
    {
        int initialDataSize = 10;
        int[] arr = new int[10];
        int idx=0;
        while (idx < initialDataSize)
        {
            Console.Write("Enter The Number : ");
            int input = int.Parse(Console.ReadLine());
            int Hash = input.GetHashCode();
            for(int i = 0; i <= idx; i++) if (arr[i].Equals(Hash))
            {
                Console.WriteLine("Number Is Already Present ...");
                return;
            }
            arr[idx++] = Hash;
        }
    }
    // static override string GetHashCode(int input)
    // {
    //     return base.GetHashCode(input);
    // }
}