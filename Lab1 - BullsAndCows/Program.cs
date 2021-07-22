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
            Console.SetWindowSize(80, 50);

            Random rand = new Random();

            //declares variables
            int user_Input;
            int user_Diff;
            int num_Size = 0;


            //Main Menu
            do
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

            //Difficulty Selection
            do
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

            //Sets the Secrete number using the difficulty selection to choose the length of the number
            for (int i = 0; i < secret_Num.Length; i++)
            {
                secret_Num[i] = rand.Next(0, 9);
                for (int j = 0; j < i; j++)
                {
                    //checks to see if any numbers are repeating and changes the number to be unique
                    while (secret_Num[i] == secret_Num[j])
                    {
                        secret_Num[i] = rand.Next(0, 9);

                    }
                }
            }

            //Difficulty selector
            if (user_Diff == 1)
            {
                //plays easy difficulty
                Easy(secret_Num);
            }
            else if (user_Diff == 2)
            {
                //plays normal difficulty
                Normal(secret_Num);
            }
            else if (user_Diff == 3)
            {
                //plays hard difficulty
                Hard(secret_Num);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        //Prints Easy difficulty grid with Secret Numbers hidden
        static void EasyGridHidden(int[,] user_Guess, int[,] Bull_Cow)
        {
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         ?     ?     ?         |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |         " + user_Guess[0, 0] + "     " + user_Guess[0, 1] + "     " + user_Guess[0, 2] + "         | B:" + Bull_Cow[0, 0] + "  C:" + Bull_Cow[0, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |         " + user_Guess[1, 0] + "     " + user_Guess[1, 1] + "     " + user_Guess[1, 2] + "         | B:" + Bull_Cow[1, 0] + "  C:" + Bull_Cow[1, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |         " + user_Guess[2, 0] + "     " + user_Guess[2, 1] + "     " + user_Guess[2, 2] + "         | B:" + Bull_Cow[2, 0] + "  C:" + Bull_Cow[2, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |         " + user_Guess[3, 0] + "     " + user_Guess[3, 1] + "     " + user_Guess[3, 2] + "         | B:" + Bull_Cow[3, 0] + "  C:" + Bull_Cow[3, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |         " + user_Guess[4, 0] + "     " + user_Guess[4, 1] + "     " + user_Guess[4, 2] + "         | B:" + Bull_Cow[4, 0] + "  C:" + Bull_Cow[4, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |         " + user_Guess[5, 0] + "     " + user_Guess[5, 1] + "     " + user_Guess[5, 2] + "         | B:" + Bull_Cow[5, 0] + "  C:" + Bull_Cow[5, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |         " + user_Guess[6, 0] + "     " + user_Guess[6, 1] + "     " + user_Guess[6, 2] + "         | B:" + Bull_Cow[6, 0] + "  C:" + Bull_Cow[6, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |         " + user_Guess[7, 0] + "     " + user_Guess[7, 1] + "     " + user_Guess[7, 2] + "         | B:" + Bull_Cow[7, 0] + "  C:" + Bull_Cow[7, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |         " + user_Guess[8, 0] + "     " + user_Guess[8, 1] + "     " + user_Guess[8, 2] + "         | B:" + Bull_Cow[8, 0] + "  C:" + Bull_Cow[8, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        //Prints Easy difficulty grid with Secret Numbers showen
        static void EasyGridReveal(int[] sec_Num, int[,] user_Guess, int[,] Bull_Cow)
        {
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         " + sec_Num[0] + "     " + sec_Num[1] + "     " + sec_Num[2] + "         |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |         " + user_Guess[0, 0] + "     " + user_Guess[0, 1] + "     " + user_Guess[0, 2] + "         | B:" + Bull_Cow[0, 0] + "  C:" + Bull_Cow[0, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |         " + user_Guess[1, 0] + "     " + user_Guess[1, 1] + "     " + user_Guess[1, 2] + "         | B:" + Bull_Cow[1, 0] + "  C:" + Bull_Cow[1, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |         " + user_Guess[2, 0] + "     " + user_Guess[2, 1] + "     " + user_Guess[2, 2] + "         | B:" + Bull_Cow[2, 0] + "  C:" + Bull_Cow[2, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |         " + user_Guess[3, 0] + "     " + user_Guess[3, 1] + "     " + user_Guess[3, 2] + "         | B:" + Bull_Cow[3, 0] + "  C:" + Bull_Cow[3, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |         " + user_Guess[4, 0] + "     " + user_Guess[4, 1] + "     " + user_Guess[4, 2] + "         | B:" + Bull_Cow[4, 0] + "  C:" + Bull_Cow[4, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |         " + user_Guess[5, 0] + "     " + user_Guess[5, 1] + "     " + user_Guess[5, 2] + "         | B:" + Bull_Cow[5, 0] + "  C:" + Bull_Cow[5, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |         " + user_Guess[6, 0] + "     " + user_Guess[6, 1] + "     " + user_Guess[6, 2] + "         | B:" + Bull_Cow[6, 0] + "  C:" + Bull_Cow[6, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |         " + user_Guess[7, 0] + "     " + user_Guess[7, 1] + "     " + user_Guess[7, 2] + "         | B:" + Bull_Cow[7, 0] + "  C:" + Bull_Cow[7, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |         " + user_Guess[8, 0] + "     " + user_Guess[8, 1] + "     " + user_Guess[8, 2] + "         | B:" + Bull_Cow[8, 0] + "  C:" + Bull_Cow[8, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        //Prints Normal difficulty grid with Secret Numbers hidden
        static void NormalGridHidden(int[,] user_Guess, int[,] Bull_Cow)
        {
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         ?   ?   ?   ?         |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |         " + user_Guess[0, 0] + "   " + user_Guess[0, 1] + "   " + user_Guess[0, 2] + "   " + user_Guess[0, 3] + "         | B:" + Bull_Cow[0, 0] + "  C:" + Bull_Cow[0, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |         " + user_Guess[1, 0] + "   " + user_Guess[1, 1] + "   " + user_Guess[1, 2] + "   " + user_Guess[1, 3] + "         | B:" + Bull_Cow[1, 0] + "  C:" + Bull_Cow[1, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |         " + user_Guess[2, 0] + "   " + user_Guess[2, 1] + "   " + user_Guess[2, 2] + "   " + user_Guess[2, 3] + "         | B:" + Bull_Cow[2, 0] + "  C:" + Bull_Cow[2, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |         " + user_Guess[3, 0] + "   " + user_Guess[3, 1] + "   " + user_Guess[3, 2] + "   " + user_Guess[3, 3] + "         | B:" + Bull_Cow[3, 0] + "  C:" + Bull_Cow[3, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |         " + user_Guess[4, 0] + "   " + user_Guess[4, 1] + "   " + user_Guess[4, 2] + "   " + user_Guess[4, 3] + "         | B:" + Bull_Cow[4, 0] + "  C:" + Bull_Cow[4, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |         " + user_Guess[5, 0] + "   " + user_Guess[5, 1] + "   " + user_Guess[5, 2] + "   " + user_Guess[5, 3] + "         | B:" + Bull_Cow[5, 0] + "  C:" + Bull_Cow[5, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |         " + user_Guess[6, 0] + "   " + user_Guess[6, 1] + "   " + user_Guess[6, 2] + "   " + user_Guess[6, 3] + "         | B:" + Bull_Cow[6, 0] + "  C:" + Bull_Cow[6, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |         " + user_Guess[7, 0] + "   " + user_Guess[7, 1] + "   " + user_Guess[7, 2] + "   " + user_Guess[7, 3] + "         | B:" + Bull_Cow[7, 0] + "  C:" + Bull_Cow[7, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |         " + user_Guess[8, 0] + "   " + user_Guess[8, 1] + "   " + user_Guess[8, 2] + "   " + user_Guess[8, 3] + "         | B:" + Bull_Cow[8, 0] + "  C:" + Bull_Cow[8, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        //Prints Normal difficulty grid with Secret Numbers showen
        static void NormalGridReveal(int[] sec_Num, int[,] user_Guess, int[,] Bull_Cow)
        {
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         " + sec_Num[0] + "   " + sec_Num[1] + "   " + sec_Num[2] + "   " + sec_Num[3] + "         |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |         " + user_Guess[0, 0] + "   " + user_Guess[0, 1] + "   " + user_Guess[0, 2] + "   " + user_Guess[0, 3] + "         | B:" + Bull_Cow[0, 0] + "  C:" + Bull_Cow[0, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |         " + user_Guess[1, 0] + "   " + user_Guess[1, 1] + "   " + user_Guess[1, 2] + "   " + user_Guess[1, 3] + "         | B:" + Bull_Cow[1, 0] + "  C:" + Bull_Cow[1, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |         " + user_Guess[2, 0] + "   " + user_Guess[2, 1] + "   " + user_Guess[2, 2] + "   " + user_Guess[2, 3] + "         | B:" + Bull_Cow[2, 0] + "  C:" + Bull_Cow[2, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |         " + user_Guess[3, 0] + "   " + user_Guess[3, 1] + "   " + user_Guess[3, 2] + "   " + user_Guess[3, 3] + "         | B:" + Bull_Cow[3, 0] + "  C:" + Bull_Cow[3, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |         " + user_Guess[4, 0] + "   " + user_Guess[4, 1] + "   " + user_Guess[4, 2] + "   " + user_Guess[4, 3] + "         | B:" + Bull_Cow[4, 0] + "  C:" + Bull_Cow[4, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |         " + user_Guess[5, 0] + "   " + user_Guess[5, 1] + "   " + user_Guess[5, 2] + "   " + user_Guess[5, 3] + "         | B:" + Bull_Cow[5, 0] + "  C:" + Bull_Cow[5, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |         " + user_Guess[6, 0] + "   " + user_Guess[6, 1] + "   " + user_Guess[6, 2] + "   " + user_Guess[6, 3] + "         | B:" + Bull_Cow[6, 0] + "  C:" + Bull_Cow[6, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |         " + user_Guess[7, 0] + "   " + user_Guess[7, 1] + "   " + user_Guess[7, 2] + "   " + user_Guess[7, 3] + "         | B:" + Bull_Cow[7, 0] + "  C:" + Bull_Cow[7, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |         " + user_Guess[8, 0] + "   " + user_Guess[8, 1] + "   " + user_Guess[8, 2] + "   " + user_Guess[8, 3] + "         | B:" + Bull_Cow[8, 0] + "  C:" + Bull_Cow[8, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        //Prints Hard difficulty grid with Secret Numbers hidden
        static void HardGridHidden(int[,] user_Guess, int[,] Bull_Cow)
        {
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |       ?   ?   ?   ?   ?       |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |       " + user_Guess[0, 0] + "   " + user_Guess[0, 1] + "   " + user_Guess[0, 2] + "   " + user_Guess[0, 3] + "   " + user_Guess[0, 4] + "       | B:" + Bull_Cow[0, 0] + "  C:" + Bull_Cow[0, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |       " + user_Guess[1, 0] + "   " + user_Guess[1, 1] + "   " + user_Guess[1, 2] + "   " + user_Guess[1, 3] + "   " + user_Guess[1, 4] + "       | B:" + Bull_Cow[1, 0] + "  C:" + Bull_Cow[1, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |       " + user_Guess[2, 0] + "   " + user_Guess[2, 1] + "   " + user_Guess[2, 2] + "   " + user_Guess[2, 3] + "   " + user_Guess[2, 4] + "       | B:" + Bull_Cow[2, 0] + "  C:" + Bull_Cow[2, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |       " + user_Guess[3, 0] + "   " + user_Guess[3, 1] + "   " + user_Guess[3, 2] + "   " + user_Guess[3, 3] + "   " + user_Guess[3, 4] + "       | B:" + Bull_Cow[3, 0] + "  C:" + Bull_Cow[3, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |       " + user_Guess[4, 0] + "   " + user_Guess[4, 1] + "   " + user_Guess[4, 2] + "   " + user_Guess[4, 3] + "   " + user_Guess[4, 4] + "       | B:" + Bull_Cow[4, 0] + "  C:" + Bull_Cow[4, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |       " + user_Guess[5, 0] + "   " + user_Guess[5, 1] + "   " + user_Guess[5, 2] + "   " + user_Guess[5, 3] + "   " + user_Guess[5, 4] + "       | B:" + Bull_Cow[5, 0] + "  C:" + Bull_Cow[5, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |       " + user_Guess[6, 0] + "   " + user_Guess[6, 1] + "   " + user_Guess[6, 2] + "   " + user_Guess[6, 3] + "   " + user_Guess[6, 4] + "       | B:" + Bull_Cow[6, 0] + "  C:" + Bull_Cow[6, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |       " + user_Guess[7, 0] + "   " + user_Guess[7, 1] + "   " + user_Guess[7, 2] + "   " + user_Guess[7, 3] + "   " + user_Guess[7, 4] + "       | B:" + Bull_Cow[7, 0] + "  C:" + Bull_Cow[7, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |       " + user_Guess[8, 0] + "   " + user_Guess[8, 1] + "   " + user_Guess[8, 2] + "   " + user_Guess[8, 3] + "   " + user_Guess[8, 4] + "       | B:" + Bull_Cow[8, 0] + "  C:" + Bull_Cow[8, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        //Prints Hard difficulty grid with Secret Numbers showen
        static void HardGridReveal(int[] sec_Num, int[,] user_Guess, int[,] Bull_Cow)
        {
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |         Bulls and Cows        |");
            Console.WriteLine("    +-------------------------------+");
            Console.WriteLine("    |       " + sec_Num[0] + "   " + sec_Num[1] + "   " + sec_Num[2] + "   " + sec_Num[3] + "   " + sec_Num[4] + "       |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("|   |             Guess             |  Result  |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 1 |       " + user_Guess[0, 0] + "   " + user_Guess[0, 1] + "   " + user_Guess[0, 2] + "   " + user_Guess[0, 3] + "   " + user_Guess[0, 4] + "       | B:" + Bull_Cow[0, 0] + "  C:" + Bull_Cow[0, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 2 |       " + user_Guess[1, 0] + "   " + user_Guess[1, 1] + "   " + user_Guess[1, 2] + "   " + user_Guess[1, 3] + "   " + user_Guess[1, 4] + "       | B:" + Bull_Cow[1, 0] + "  C:" + Bull_Cow[1, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 3 |       " + user_Guess[2, 0] + "   " + user_Guess[2, 1] + "   " + user_Guess[2, 2] + "   " + user_Guess[2, 3] + "   " + user_Guess[2, 4] + "       | B:" + Bull_Cow[2, 0] + "  C:" + Bull_Cow[2, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 4 |       " + user_Guess[3, 0] + "   " + user_Guess[3, 1] + "   " + user_Guess[3, 2] + "   " + user_Guess[3, 3] + "   " + user_Guess[3, 4] + "       | B:" + Bull_Cow[3, 0] + "  C:" + Bull_Cow[3, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 5 |       " + user_Guess[4, 0] + "   " + user_Guess[4, 1] + "   " + user_Guess[4, 2] + "   " + user_Guess[4, 3] + "   " + user_Guess[4, 4] + "       | B:" + Bull_Cow[4, 0] + "  C:" + Bull_Cow[4, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 6 |       " + user_Guess[5, 0] + "   " + user_Guess[5, 1] + "   " + user_Guess[5, 2] + "   " + user_Guess[5, 3] + "   " + user_Guess[5, 4] + "       | B:" + Bull_Cow[5, 0] + "  C:" + Bull_Cow[5, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 7 |       " + user_Guess[6, 0] + "   " + user_Guess[6, 1] + "   " + user_Guess[6, 2] + "   " + user_Guess[6, 3] + "   " + user_Guess[6, 4] + "       | B:" + Bull_Cow[6, 0] + "  C:" + Bull_Cow[6, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 8 |       " + user_Guess[7, 0] + "   " + user_Guess[7, 1] + "   " + user_Guess[7, 2] + "   " + user_Guess[7, 3] + "   " + user_Guess[7, 4] + "       | B:" + Bull_Cow[7, 0] + "  C:" + Bull_Cow[7, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
            Console.WriteLine("| 9 |       " + user_Guess[8, 0] + "   " + user_Guess[8, 1] + "   " + user_Guess[8, 2] + "   " + user_Guess[8, 3] + "   " + user_Guess[8, 4] + "       | B:" + Bull_Cow[8, 0] + "  C:" + Bull_Cow[8, 1] + " |");
            Console.WriteLine("+---+-------------------------------+----------+");
        }

        //Plays Game at Easy difficulty
        static void Easy(int[] sec_Num)
        {
            //declares the arrays for the game
            int[,] user_Guess = new int[9, 3];
            int[,] Bull_Cow = new int[9, 2];

            //temp variables
            int first_Num, second_Num, third_Num, count = 1;

            for (int i = 0; i < 9; i++)
            {

                //First Number Input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    EasyGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the First number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out first_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (first_Num < 0 || first_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Second Number Input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    EasyGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Second number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out second_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (second_Num < 0 || second_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Third Number Input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    EasyGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Third number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out third_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (third_Num < 0 || third_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Places user inputs into array
                user_Guess[i, 0] = first_Num;
                user_Guess[i, 1] = second_Num;
                user_Guess[i, 2] = third_Num;

                //Checks to see if user guesses matches the secret numbers
                for (int j = 0; j < user_Guess.GetLength(1); j++)
                {
                    //check if the number is the same value and in the same place
                    if (user_Guess[i, j] == sec_Num[j])
                    {
                        Bull_Cow[i, 0]++;
                    }
                    else
                    {
                        //check if the number matches any other numbers that is not in the same place
                        for (int k = 0; k < sec_Num.Length; k++)
                        {
                            if (user_Guess[i, j] == sec_Num[k])
                            {
                                Bull_Cow[i, 1]++;
                            }
                        }
                    }
                }

                //If bull equals 3 that means the user has guessed correctly
                if (Bull_Cow[i, 0] == 3)
                {
                    //Display Grid
                    EasyGridReveal(sec_Num, user_Guess, Bull_Cow);


                    Console.WriteLine("YOU WON!!!");
                    Console.WriteLine("You Guessed the Secret Number");
                    Console.WriteLine("Attempt " + count);
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();

                    //Returns to the main menu
                    Main(null);
                    break;
                }

                count++;
            }

            //Display Grid
            EasyGridReveal(sec_Num, user_Guess, Bull_Cow);

            Console.WriteLine("You Lose");
            Console.WriteLine("You Didn't Guess the Secret Number Correctly");
            Console.WriteLine();

            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            //Returns to the main menu
            Main(null);
        }

        //Plays Game at Normal difficulty
        static void Normal(int[] sec_Num)
        {
            //declares the arrays for the game
            int[,] user_Guess = new int[9, 4];
            int[,] Bull_Cow = new int[9, 2];

            //temp variables
            int first_Num, second_Num, third_Num, forth_Num, count = 1;

            for (int i = 0; i < 9; i++)
            {

                //First Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    NormalGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the First number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out first_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (first_Num < 0 || first_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Second Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    NormalGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Second number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out second_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (second_Num < 0 || second_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Third Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    NormalGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Third number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out third_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (third_Num < 0 || third_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Forth Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    NormalGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Forth number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out forth_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (forth_Num < 0 || forth_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Places user inputs into array
                user_Guess[i, 0] = first_Num;
                user_Guess[i, 1] = second_Num;
                user_Guess[i, 2] = third_Num;
                user_Guess[i, 3] = forth_Num;

                //Checks to see if user guesses matches the secret numbers
                for (int j = 0; j < user_Guess.GetLength(1); j++)
                {
                    //check if the number is the same value and in the same place
                    if (user_Guess[i, j] == sec_Num[j])
                    {
                        Bull_Cow[i, 0]++;
                    }
                    else
                    {
                        //check if the number matches any other numbers that is not in the same place
                        for (int k = 0; k < sec_Num.Length; k++)
                        {
                            if (user_Guess[i, j] == sec_Num[k])
                            {
                                Bull_Cow[i, 1]++;
                            }
                        }
                    }
                }

                //If bull equals 4 that means the user has guessed correctly
                if (Bull_Cow[i, 0] == 4)
                {
                    //Display Grid
                    NormalGridReveal(sec_Num, user_Guess, Bull_Cow);

                    Console.WriteLine("YOU WON!!!");
                    Console.WriteLine("You Guessed the Secret Number");
                    Console.WriteLine("Attempt " + count);
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();

                    //Returns to the main menu
                    Main(null);
                    break;
                }

                count++;
            }

            //Display Grid
            NormalGridReveal(sec_Num, user_Guess, Bull_Cow);

            Console.WriteLine("You Lose");
            Console.WriteLine("You Didn't Guess the Secret Number Correctly");
            Console.WriteLine();

            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            //Returns to the main menu
            Main(null);
        }

        //Plays Game at Hard difficulty
        static void Hard(int[] sec_Num)
        {
            int[,] user_Guess = new int[9, 5];
            int[,] Bull_Cow = new int[9, 2];

            int first_Num, second_Num, third_Num, forth_Num, fifth_Num, count = 1;

            for (int i = 0; i < 9; i++)
            {

                //First Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    HardGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the First number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out first_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (first_Num < 0 || first_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Second Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    HardGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Second number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out second_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (second_Num < 0 || second_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Third Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    HardGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Third number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out third_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (third_Num < 0 || third_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Forth Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    HardGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Forth number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out forth_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (forth_Num < 0 || forth_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Fifth Number input
                do
                {
                    //Debug Purpose
                    //for (int x = 0; x < sec_Num.Length; x++)
                    //{
                    //    Console.Write(sec_Num[x]);
                    //}
                    //Console.WriteLine();

                    //Display Grid
                    HardGridHidden(user_Guess, Bull_Cow);

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt " + count + ":");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Fifth number(0-9)");

                    //Check if input in number
                    if (!int.TryParse(Console.ReadLine(), out fifth_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    //Check if number is in range
                    else if (fifth_Num < 0 || fifth_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                } while (true);

                //Places user inputs into array
                user_Guess[i, 0] = first_Num;
                user_Guess[i, 1] = second_Num;
                user_Guess[i, 2] = third_Num;
                user_Guess[i, 3] = forth_Num;
                user_Guess[i, 4] = fifth_Num;

                //Checks to see if user guesses matches the secret numbers
                for (int j = 0; j < user_Guess.GetLength(1); j++)
                {
                    //check if the number is the same value and in the same place
                    if (user_Guess[i, j] == sec_Num[j])
                    {
                        Bull_Cow[i, 0]++;
                    }
                    //check if the number matches any other numbers that is not in the same place
                    else
                    {
                        for (int k = 0; k < sec_Num.Length; k++)
                        {
                            if (user_Guess[i, j] == sec_Num[k])
                            {
                                Bull_Cow[i, 1]++;
                            }
                        }
                    }
                }

                //If bull equals 5 that means the user has guessed correctly
                if (Bull_Cow[i, 0] == 5)
                {
                    //Display Grid
                    HardGridReveal(sec_Num, user_Guess, Bull_Cow);

                    Console.WriteLine("YOU WON!!!");
                    Console.WriteLine("You Guessed the Secret Number");
                    Console.WriteLine("Attempt " + count);
                    Console.WriteLine();

                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();

                    //Returns to the main menu
                    Main(null);
                    break;
                }

                count++;
            }

            //Display Grid
            HardGridReveal(sec_Num, user_Guess, Bull_Cow);

            Console.WriteLine("You Lose");
            Console.WriteLine("You Didn't Guess the Secret Number Correctly");
            Console.WriteLine();

            System.Threading.Thread.Sleep(2500);
            Console.Clear();

            //Returns to the main menu
            Main(null);

        }
    }
}
