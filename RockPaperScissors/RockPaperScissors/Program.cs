using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        Random rdm = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Time to Play Rock, Paper, Scissors!");
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Rock, 2 for Paper, or 3 for Scissors.");
            Console.WriteLine();
            int guess = Convert.ToInt32(Console.ReadLine());


        }

        

        public void GenerateRandomNumber()
        {
            int opponent = rdm.Next(0, 4);
        }

        public void Play()
        {
            
        }
    }
}
