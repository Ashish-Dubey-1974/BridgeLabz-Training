using System;
class SentenceFormat
{
    public static void Main()
    {
        Console.WriteLine("Enter a Sentence then I'll return you a formatted Sentences...😁");
        string s = Console.ReadLine();
        s = TrimStr(s);
        Console.WriteLine(Formatted(s));
    }

    // =======================================String Trim function ================================>
    static string TrimStr(string s)
    {
        string ans = "";
        int idx = 0;
        int ed = s.Length;
        for(int i = 0; i < s.Length; i++){if(s[i]!=' ')break;else idx++;}
        for(int i= s.Length-1; i >= 0; i--){if(s[i]!=' ')break;else ed--;}
        for(int i=idx;i<ed;i++)ans+=s[i];
        return ans;
    }
    //======================================check Punctuation=====================================>
    static bool isPunctuation(char c)=>c=='.'|| c==',' || c == '!' || c == '?';

    // ========================================function to formate string===========================>
    static string Formatted(string s)
    {
        string ans="";
        if (s.Length > 0 && s[0] >= 'a' && s[0] <= 'z')ans += (char)(s[0] - 32);
        else ans += s[0];
        for(int i = 1; i < s.Length; i++)
        {
            if(s[i]==' '){
                while(s[i]==' ')i++;
                if(!isPunctuation(s[i]))ans+=" ";
                i--;
            }
            else if(isPunctuation(s[i]))
            {
                ans+=s[i];
                ans+=" ";
                i++;
                if (i < s.Length)
                {
                    if(s[i]==' ')while(s[i]==' ')i++;
                    if(s[i]>='a')ans=ans+(char)(s[i]-32);
                    else ans+=s[i];
                }
            }
            else ans+=s[i];
        }
        return ans;
    }
}