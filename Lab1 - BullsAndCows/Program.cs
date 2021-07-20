using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1___BullsAndCows
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rand = new Random();

            int user_Input;
            int user_Diff;
            int num_Size = 0;

            do//Main Menu
            {
                Console.WriteLine("Bulls And Cows");
                Console.WriteLine("Guessing Game");

                Console.WriteLine("");

                Console.WriteLine("1) Play");
                Console.WriteLine("");

                Console.WriteLine("2) Quit");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter your Answer");

                if (!int.TryParse(Console.ReadLine(), out user_Input))
                {
                    Console.WriteLine("Please Enter A Valid Number");
                    System.Threading.Thread.Sleep(700);
                    Console.Clear();
                }
                else if (user_Input < 1 || user_Input > 2)
                {
                    Console.WriteLine("Please enter 1 or 2");
                    System.Threading.Thread.Sleep(700);
                    Console.Clear();
                }

                if (user_Input == 1)
                {
                    Console.Clear();
                    break;
                }
                else if (user_Input == 2)
                {
                    Environment.Exit(0);
                }

            } while (true);



            do //Difficulty Selection
            {
                Console.WriteLine("Bulls And Cows");
                Console.WriteLine("Guessing Game");

                Console.WriteLine("");

                Console.WriteLine("Select Difficulty:");
                Console.WriteLine("1) Easy(3 numbers)");
                Console.WriteLine("");

                Console.WriteLine("2) Normal(4 Numbers)");
                Console.WriteLine("");

                Console.WriteLine("3) Hard(5 Numbers)");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Enter your Answer");

                if (!int.TryParse(Console.ReadLine(), out user_Diff))
                {
                    Console.WriteLine("Please Enter A Valid Number");
                    System.Threading.Thread.Sleep(700);
                    Console.Clear();
                }
                else if (user_Diff < 1 || user_Diff > 3)
                {
                    Console.WriteLine("Please enter 1 , 2 or 3");
                    System.Threading.Thread.Sleep(700);
                    Console.Clear();
                }
                else
                {

                    if (user_Diff == 1)
                    {
                        num_Size = 3;
                    }
                    else if (user_Diff == 2)
                    {
                        num_Size = 4;
                    }
                    else if (user_Diff == 3)
                    {
                        num_Size = 5;
                    }


                    Console.Clear();
                    break;
                }

            } while (true);

            int[] secret_Num = new int[num_Size];
            int[,] user_Guess = new int[9, num_Size];

            foreach(int i in secret_Num)
            {
                secret_Num[i] = rand.Next(0, 9);
                Console.Write(secret_Num[i] + " ");
            }
            Console.WriteLine();



            Console.ReadLine();
        }

        static void Easy() 
        {

            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         ?     ?     ?         |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |         0     0     0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        static void Normal() 
        {

            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         ?   ?   ?   ?         |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |         0   0   0   0         | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        static void Hard() 
        {

            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |       ?   ?   ?   ?   ?       |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |       0   0   0   0   0       | B:0  C:0 |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }










    }
}
