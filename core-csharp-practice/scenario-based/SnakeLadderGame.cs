using System;
using System.Collections.Generic;

class SnakeLadderGame{
    static int[] players;
    static Random r = new Random();
    static Dictionary<int,int> snake_Ladder = new Dictionary<int, int>();
    SnakeLadderGame()
    {
        snake_Ladder.Add(35,4);
        snake_Ladder.Add(48,26);
        snake_Ladder.Add(53,21);
        snake_Ladder.Add(88,60);
        snake_Ladder.Add(93,65);
        snake_Ladder.Add(3,32);
        snake_Ladder.Add(19,28);
        snake_Ladder.Add(34,52);
        snake_Ladder.Add(39,79);
        snake_Ladder.Add(46,67);
        snake_Ladder.Add(61,82);
        snake_Ladder.Add(65,87);
        
    }
    public static void Main()
    {
        new SnakeLadderGame();
        Console.WriteLine("Enter number of players in this game minimum of 2 and maximum of 4 players can play at a time");
        int n = Convert.ToInt16(Console.ReadLine());
        if(n<2 || n > 4)
        {
            Console.WriteLine("Invalid number : ");
            return;
        }
        players = new int[n];
        bool wins = false;
        while (!wins)
        {
            // Console.WriteLine($"Its your turn to continue press any Key and to End Press \"N\" and Enter-->");
            // string check = (Console.ReadLine());
            // if(check.Equals("N"))return;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Its player {i+1} turn to continue press any Key and to End Press \"N\" and Enter-->");
                string check = (Console.ReadLine());
                if(check.Equals("N"))return;
                int oldPosition = players[i];
                int point = rollDice();
                int s=0,e=0;
                movePlayer(i,point,ref s,ref e);
                Console.WriteLine($"Player - {i+1}\nDice Value - {point}\nOldPosition - {oldPosition}\nNewPosition - {players[i]}");
                if(e<s)Console.WriteLine($"Snake bite 😂 {s} 🐍 {e}\n");
                else if(s<e)Console.WriteLine($"Ladder 👌 {s} 🪜 {e}\n");
                if (checkWins(i))
                {
                    Console.WriteLine($"Congratulations !! Player {i+1} Wins the match");
                    wins=true;
                    break;
                }
                Console.WriteLine("\n");
            }
        }
        static int rollDice()=> r.Next(1,7);
        static void movePlayer(int Player,int points,ref int st,ref int ed)
        {
            int score = players[Player]+points;
            if(score>100)return;
            if (snake_Ladder.ContainsKey(score)){
                st = score;
                score = snake_Ladder[score];
                ed = score;
            }
            players[Player] = score;
        }
        static bool checkWins(int i)=> players[i]==100;
    }
}