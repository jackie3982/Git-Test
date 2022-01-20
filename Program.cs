using System; 

namespace CW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ans = 0, turn = 1;
            bool e = false;

            Console.WriteLine("Pick the lowwer and upper limits to this game of Number Guesser.\nLower:");
            string i = Console.ReadLine();
            int low = Convert.ToInt32(i);

            Console.WriteLine("Upper:");
            string a = Console.ReadLine();
            int high = Convert.ToInt32(a);

            Random rnd = new Random();
            int num = rnd.Next(low, high);

            while (e == false)
            {
                Console.WriteLine("I am thinking of a number between " + low + " and " + high + ".");
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
