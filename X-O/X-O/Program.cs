using System;

namespace X_O
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] x_0 = new string[3, 3];

            x_0[0, 0] = "_";
            x_0[0, 1] = "_";
            x_0[0, 2] = "_";
            x_0[1, 0] = "_";
            x_0[1, 1] = "_";
            x_0[1, 2] = "_";
            x_0[2, 0] = "_";
            x_0[2, 1] = "_";
            x_0[2, 2] = "_";

            char choice = ' ';
            int count = 1;
            do
            {
                DisplayArray(x_0);
                Console.Write("Row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Column: ");
                int column = Convert.ToInt32(Console.ReadLine());
                if (count % 2 != 0)
                {
                    x_0[row, column] = "X";
                }
                else
                {
                    x_0[row, column] = "O";
                }

                DisplayArray(x_0);

                count++;
                if (CheckWin(x_0, ref count) == true)
                {
                    break;
                }

                Console.Write("\nContinue: ");

                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice =='Y');



        }

        static void DisplayArray(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 1 && j == 1)
                    {

                        Console.Write(" " + arr[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arr[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }
        static bool CheckWin(string[,] x_0, ref int count)
        {
            if ((x_0[0, 0] == "X" && x_0[0, 1] == "X" && x_0[0, 2] == "X") || (x_0[0, 0] == "O" && x_0[0, 1] == "O" && x_0[0, 2] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }




            }
            else if ((x_0[1, 0] == "X" && x_0[1, 1] == "X" && x_0[1, 2] == "X") || (x_0[1, 0] == "O" && x_0[1, 1] == "O" && x_0[1, 2] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }


            }
            else if ((x_0[2, 0] == "X" && x_0[2, 1] == "X" && x_0[2, 2] == "X") || (x_0[2, 0] == "O" && x_0[2, 1] == "O" && x_0[2, 2] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }


            }
            else if ((x_0[0, 0] == "X" && x_0[1, 1] == "X" && x_0[2, 2] == "X") || (x_0[0, 0] == "O" && x_0[1, 1] == "O" && x_0[2, 2] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }


            }
            else if ((x_0[0, 2] == "X" && x_0[1, 1] == "X" && x_0[2, 0] == "X") || (x_0[0, 2] == "O" && x_0[1, 1] == "O" && x_0[2, 0] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }


            }
            else if ((x_0[0, 0] == "X" && x_0[1, 0] == "X" && x_0[2, 0] == "X") || (x_0[0, 0] == "O" && x_0[1, 0] == "O" && x_0[2, 0] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }


            }
            else if ((x_0[0, 1] == "X" && x_0[1, 1] == "X" && x_0[2, 1] == "X") || (x_0[0, 1] == "O" && x_0[1, 1] == "O" && x_0[2, 1] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }


            }
            else if ((x_0[0, 2] == "X" && x_0[1, 2] == "X" && x_0[2, 2] == "X") || (x_0[0, 2] == "O" && x_0[1, 2] == "O" && x_0[2, 2] == "O"))
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine("O WON!!!");
                    return true;
                }
                else
                {
                    Console.WriteLine("X WON!!!");
                    return true;
                }
            }
            else
            {
                return false;
            }


        }
    }
}
