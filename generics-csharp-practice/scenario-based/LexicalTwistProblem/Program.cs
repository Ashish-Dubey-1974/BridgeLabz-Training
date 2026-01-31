using System;
namespace LexicalTwistProblem
{
    class Program
    {
        public static string input2;
        public static string input1;
        public static void Main()
        {
            Console.Write("Enter Word 1 : ");
            input1 = Console.ReadLine().ToLower();
            Console.Write("Enter Word 2 : ");
            input2 = Console.ReadLine().ToLower();
            if(input1.Contains(' ') && input2.Contains(' '))
            {
                Console.Write("Invalid Input...");
                return;
            }
            if(Reverse(input1).Equals(input2))Ex1.Perform();
            else Ex2.Perform();
        }
        static string Reverse(string s)
        {
            string st = "";
            foreach(char c in s)st = c+st;
            return st;
        }
    }
}