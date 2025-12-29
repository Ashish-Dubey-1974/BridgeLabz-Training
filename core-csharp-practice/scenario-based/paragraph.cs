using System;
class paragraph
{
    // =================Count Words================>
    static int CountWords(string s)
    {
        int ans=0;
        for(int i=1;i<s.Length;i++)if(s[i]==' '&&s[i-1]!=' ')ans++;
        return ans+1;
    }


    // =============================Longest Word in Array==============>
    static int LongestWord(string s)
    {
        int len = 0;
        int word =0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]==' ')
            {
                len = len>word?len:word;
                word=0;
            }else word++;
        }
        return len>word?len:word;
    }
    // ==================================== Checks String is Valid or not============>
    static bool isValid(string s) =>!(s.Length==0 || s.Trim().Length==0);
    
    // =================================== Replace All the Occurances of the Given Word==========>
    static string replaceAll(string word,string str,string replace)
    {
        string s = "";
        string[] SArray = SplitArray(str);
        for(int i=0;i<SArray.Length;i++){
            if(Equalstr(word,SArray[i]))s+=replace;
            else s+=SArray[i];
            if(i!=SArray.Length-1)s+=" ";
        }
        return s;
    }

    // ====================================== Compare Two Strings equals or not (Case-insensitive)==============>
    static bool Equalstr(string s1,string s2)
    {
        if(s1.Length==0 || s2.Length==0 || s1.Length!=s2.Length)return false;
        for(int i = 0; i < s1.Length; i++)if (s1[i] != s2[i] && (s1[i]-32)!=s2[i] && (s2[i]-32)!=s1[i])return false;
        return true;
    }

    // =================================Split the String in Array==============>
    static string[] SplitArray(string s)
    {
        string word="";
        int spaces = Cspaces(s);
        string[] arr = new string[spaces+1];
        int idx=0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]==' ')
            {
                if(word.Length>0){
                    arr[idx++] = word;
                    word="";
                }
            }else word+=s[i];
        }if(word.Length>0)arr[idx] = word;     
        return arr;
    }
    static int Cspaces(string s)
    {
        int c=0;
        for(int i=0;i<s.Length;i++)if(s[i]==' ')c++;
        return c;
    }

    static void Main()
    {
        Console.WriteLine("Enter the String to-do following Operations");
        string str = Console.ReadLine();
        Console.WriteLine("Menu---->\nPress 1 to count the number of words in para.\nPress 2 to find and display the longest word\nPress 3 for Replace all occurrences of a specific word with another word (case-insensitive).\nPress 4 to know input string is Valid or not.");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("Word Count: " + CountWords(str));
                break;
            case 2:
                Console.WriteLine("Longest Word Length: " + LongestWord(str));
                break;
            case 3:
                Console.WriteLine("enter the word want to replace ");
                string word = Console.ReadLine();
                Console.WriteLine("enter the word want to replace with ");
                string replace = Console.ReadLine();
                Console.WriteLine("Result: " + replaceAll(word, str, replace));
                break;
            case 4:
                if(isValid(str))Console.WriteLine("String is valid");
                else Console.WriteLine("String is not Valid");
                break;

            
            default:
                Console.WriteLine("In Valid Input");
                break;
        }
    }
}