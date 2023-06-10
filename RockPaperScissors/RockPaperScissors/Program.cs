using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //User
            Console.Write("Enter your name: ");
            string ConsoleName = Console.ReadLine();
            string UserName = ConsoleName;


            Console.WriteLine($"Hello {UserName}, You are playing Rock Paper Scissors  with Computer.");
            Console.WriteLine(" You must enter a number from 1 to 3 inclusive");
            Console.WriteLine();
            Console.WriteLine("Rules: ");
            Console.WriteLine("1 = Scissors  ,  2 = Rock  ,  3 = Paper");

            Console.WriteLine();

            Console.WriteLine("Who gets 3 points will be the winner.");
            Console.WriteLine("Good luck <3");

            int UserPoint = 0;



            //Computer
            Random random = new Random();


            int ComputerPoint = 0;

            for (int i = 0; i < 15; i++)
            {
                int CPU = random.Next(1, 4);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Enter Number: ");
                int USerNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (USerNumber == CPU)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your symbols have matched, try again");
                }
                else if (USerNumber == 1 && CPU == 2)
                {
                    Console.WriteLine();
                    ComputerPoint++;
                    Console.WriteLine($"{UserName}: Scissors");
                    Console.WriteLine($"Computer: Rock");

                    Console.WriteLine($"Winner: Computer");

                    Console.WriteLine();

                    Console.WriteLine($"Computer Point: {ComputerPoint}");
                    Console.WriteLine($"{UserName}'s Point: {UserPoint}");

                }
                else if (USerNumber == 2 && CPU == 3)
                {
                    Console.WriteLine();
                    ComputerPoint++;
                    Console.WriteLine($"{UserName}: Rock");
                    Console.WriteLine($"Computer: Paper");

                    Console.WriteLine($"Winner: Computer");

                    Console.WriteLine();

                    Console.WriteLine($"Computer Point: {ComputerPoint}");
                    Console.WriteLine($"{UserName}'s Point: {UserPoint}");

                }

                else if (USerNumber == 3 && CPU == 2)
                {
                    Console.WriteLine();
                    UserPoint++;
                    Console.WriteLine($"{UserName}: Paper");
                    Console.WriteLine($"Computer: Rock");

                    Console.WriteLine($"Winner: {UserName}");

                    Console.WriteLine();

                    Console.WriteLine($"{UserName}'s Point: {UserPoint}");
                    Console.WriteLine($"Computer Point: {ComputerPoint}");

                }
                else if (USerNumber == 3 && CPU == 1)
                {
                    Console.WriteLine();
                    ComputerPoint++;
                    Console.WriteLine($"{UserName}: Paper");
                    Console.WriteLine($"Computer: Scissors");

                    Console.WriteLine($"Winner: Computer");

                    Console.WriteLine();

                    Console.WriteLine($"Computer Point: {ComputerPoint}");
                    Console.WriteLine($"{UserName}'s Point: {UserPoint}");
                }
                else if (USerNumber == 1 && CPU == 3)
                {
                    Console.WriteLine();
                    UserPoint++;
                    Console.WriteLine($"{UserName}: Scissors");
                    Console.WriteLine($"Computer: Paper");

                    Console.WriteLine($"Winner: {UserName}");
                    Console.WriteLine();

                    Console.WriteLine($"{UserName}'s Point: {UserPoint}");
                    Console.WriteLine($"Computer Point: {ComputerPoint}");
                }
                else if (USerNumber == 2 && CPU == 1)
                {
                    Console.WriteLine();
                    UserPoint++;
                    Console.WriteLine($"{UserName}: Rock");
                    Console.WriteLine($"Computer: Scissors");

                    Console.WriteLine($"Winner: {UserName}");
                    Console.WriteLine();

                    Console.WriteLine($"{UserName}'s Point: {UserPoint}");
                    Console.WriteLine($"Computer Point: {ComputerPoint}");

                }


                if (UserPoint == 3)
                {
                    Console.WriteLine($"The final winner is: {UserName}");
                    Console.WriteLine();
                    Console.WriteLine($"Gilocav {UserName} Shen kargad itamashe");
                    break;
                }



                else if (ComputerPoint == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("The final winner is: Computer");
                    Console.WriteLine(" I'm sorry you lose, Try again");
                    break;
                }


            }





        }
    }
}
