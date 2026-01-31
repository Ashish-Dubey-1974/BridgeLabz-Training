using System.Text;

namespace LexicalTwistProblem
{
    class Ex1
    {
        public static void Perform()
        {
            string s = Program.input2;
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {
                if(c=='a' ||c=='e' ||c=='i' ||c=='o' ||c=='u')sb.Append('@');
                else sb.Append(c);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}