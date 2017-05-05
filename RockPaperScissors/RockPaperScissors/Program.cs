using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static Random rdm = new Random();
        static void Main(string[] args)
        {
            int gameCount = 0;
            
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("Time to Play Rock, Paper, Scissors!");
                Console.WriteLine();
                Console.WriteLine("Enter 1 for Rock, 2 for Paper, or 3 for Scissors.");
                Console.WriteLine();
                int user = Convert.ToInt16(Console.ReadLine());
                int oponent = rdm.Next(1, 3);
                if (user == 1)
                {
                    if (oponent == 1)
                    {
                        Console.WriteLine("You chose Rock");
                        Console.WriteLine();
                        Console.WriteLine("Opponet chose Rock");
                        Console.WriteLine();
                        Console.WriteLine("It's a tie.");
                        gameCount++;
                    }
                    else if (oponent == 2)
                    {
                        Console.WriteLine("You chose Rock");
                        Console.WriteLine();
                        Console.WriteLine("Opponet chose Paper");
                        Console.WriteLine();
                        Console.WriteLine("You lose.");
                        gameCount++;
                    }
                    else if (oponent == 3)
                    {
                        Console.WriteLine("You chose Rock");
                        Console.WriteLine();
                        Console.WriteLine("Opponet chose Scissors");
                        Console.WriteLine();
                        Console.WriteLine("You win!");
                        gameCount++;
                    }
                    else
                    {
                        Console.WriteLine("Something borked :/");
                    }
                }

                Console.WriteLine("Want to play again?");
            } while (Console.ReadLine() != "no");

            Console.WriteLine("You played " + gameCount + " games.");
            Console.ReadKey();
        }

        

   
    }
}
