namespace LexicalTwistProblem
{
    class Ex2
    {
        public static void Perform()
        {
            string s = (Program.input1+Program.input2).ToUpper();
            int cnt=0;
            foreach(char c in s)
            {
                if(c=='A' ||c=='E' ||c=='I' ||c=='O' ||c=='U')cnt++;
                else cnt--;
            }
            if (cnt==0)Console.WriteLine("Vowels and consonants are equal");
            else if (cnt > 0)
            {
                cnt=0;
                foreach(char c in s)
                {
                    if((c=='A' ||c=='E' ||c=='I' ||c=='O' || c == 'U'))
                    {
                        Console.Write($"{c} ");
                        cnt++;
                    }if(cnt>=2) break;
                    
                }
            }else
            {
                cnt=0;
                foreach(char c in s)
                {
                    if((c!='A' &&c!='E' &&c!='I' &&c!='O' && c != 'U'))
                    {
                        Console.Write($"{c} ");
                        cnt++;
                    }if(cnt>=2) break;
                    
                }
            }
        }
    }
}