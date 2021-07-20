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

            for(int i = 0; i < secret_Num.Length; i++)
            {

                secret_Num[i] = rand.Next(0, 9);
                for (int j = 0; j < i; j++)
                {
                    while (secret_Num[i] == secret_Num[j]) 
                    {
                        secret_Num[i] = rand.Next(0, 9);

                    }
                }
            }

            if(user_Diff == 1)
            {
                Easy();
            }else if(user_Diff == 2)
            {
                Normal();
            }else if(user_Diff == 3)
            {
                Hard();
            }



            Console.WriteLine();
            Console.ReadLine();
        }

        static void Easy() 
        {
            int[,] user_Guess = new int[9, 3];
            int[,] Bull_Cow = new int[9, 2];

            int first_Num, second_Num, third_Num;

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
            Console.Clear();


            for (int i = 0; i < 9; i++)
            {

                do
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

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt 1:");
                    Console.WriteLine();
                    Console.WriteLine("Guess the first number(0-9)");

                    if (!int.TryParse(Console.ReadLine(), out first_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else if (first_Num < 0 || first_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        user_Guess[i, 0] = first_Num;
                        break;
                    }

                } while (true);

                do
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

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt 1:");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Second number(0-9)");

                    if (!int.TryParse(Console.ReadLine(), out second_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else if (second_Num < 0 || second_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        user_Guess[i, 1] = second_Num;
                        break;
                    }

                } while (true);

                do
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

                    Console.WriteLine("Guess the Secret Number");
                    Console.WriteLine("Attempt 1:");
                    Console.WriteLine();
                    Console.WriteLine("Guess the Third number(0-9)");

                    if (!int.TryParse(Console.ReadLine(), out third_Num))
                    {
                        Console.WriteLine("Please Enter A Valid Number");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else if (third_Num < 0 || third_Num > 9)
                    {
                        Console.WriteLine("Enter a Number between 0-9");
                        System.Threading.Thread.Sleep(700);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        user_Guess[i, 2] = third_Num;
                        break;
                    }

                } while (true);
            
            
            }

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

        static void Normal() 
        {
            int[,] user_Guess = new int[9, 4];

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
            int[,] user_Guess = new int[9, 5];

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
