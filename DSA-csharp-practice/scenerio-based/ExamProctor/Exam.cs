using System;
using System.Collections.Generic;
using System.Text;

namespace ExamProctor
{
    internal class QA
    {
        int ID;
        string Answer;
        internal QA(int iD, string answer)
        {
            ID = iD;
            Answer = answer;
        }
    }
    internal class Exam
    {

        static Dictionary<int,String> answers = new Dictionary<int ,String>();
        int NumberOfQuestions = 10;
        int score = 0;
        static Exam(){
            answers.Add(1, "A");
            answers.Add(2, "B");
            answers.Add(3, "C");
            answers.Add(4, "D");
            answers.Add(5, "A");
            answers.Add(6, "C");
            answers.Add(7, "B");
            answers.Add(8, "D");
            answers.Add(9, "A");
            answers.Add(10, "B");
        }
        Stack<QA> Answers = new Stack<QA>();
        internal void Starts()
        {
            Console.WriteLine("<-----Exam Window----->\n");
            Console.WriteLine("Once the Exam Is starts It won't be stop :");
            Console.WriteLine("To Start Please Enter :\n");
            string starts = Console.ReadLine();
            Console.WriteLine($"There {NumberOfQuestions} Questions Write A,B,C and D as Correct Answers");
            TestStarts();
        }

        internal void TestStarts()
        {
            int i = 1;
            while (i <= NumberOfQuestions)
            {
                Console.Write($"Answer for the Questions {i} : ");
                string answer = Console.ReadLine();
                if(answer.Equals(answers[i]))score++;
                Answers.Push(new QA(i, answer));
                Console.WriteLine("Press 1. For Next");
                Console.WriteLine("Press 2. For Back");
                int input = int.Parse(Console.ReadLine());
                if (input == 1) i++;
                else if (input == 2)
                {
                    if (answer.Equals(answers[i])) score--;
                    if(i!=1)i--;
                    Answers.Pop();
                }else
                {
                    Console.WriteLine("Invalid Input Exam Terminated");
                    break;
                }
            }
            Console.WriteLine($"\nYour Ranking : {score}");
        }
    }
}
