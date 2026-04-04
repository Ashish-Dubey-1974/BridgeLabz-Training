using System.Text;

class StringBuilderOperation
{
    public static void Perform()
    {
        StringBuilder sb = new StringBuilder();
        Console.Write("Enter Word1 : ");
        string word1 = Console.ReadLine();
        sb.Append(word1);
        Console.Write("Enter The Character : ");
        char c = char.Parse(Console.ReadLine());
        Console.Write("Enter The Second Word : ");
        string word2 = Console.ReadLine();
        int idx = -1;
        for(int i=0;i<sb.Length;i++)if(sb[i]==c){
            idx=i;
            break;
        }
        if(idx==-1)Console.WriteLine("Character Is Not Present :");
        else
        {
            sb.Insert(idx,word2);
            Console.WriteLine(sb.ToString());
        }
    }
}