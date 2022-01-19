using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {   

            int Ans = 0, turn = 1;
            bool e = false;
            Random rnd = new Random();
            int num = rnd.Next(0, 100);

            while (e == false)
            {
                Console.WriteLine("I am thinking of a number between 0 and 100.");
                string v = Console.ReadLine();
                Ans = Convert.ToInt32(v);

                if (num == Ans)
                {
                    Console.WriteLine("YAY!\nYou are right!");
                    Console.WriteLine("You took " + turn + " turns..");
                    e = true;

                }
                else if (num > Ans)
                {
                    Console.WriteLine("Oh No...\n Too low!");
                    e = false;
                    turn++;
                }
                else if (num < Ans)
                {
                    Console.WriteLine("Oh No...\n Too high!");
                    e = false;
                    turn++;
                }
            }

        }
        
    }
}
