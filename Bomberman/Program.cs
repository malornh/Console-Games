using System;

namespace Bomberman
{
    class Program
    {
        //----------------------------------MOVEMENT--------------------------
        public static void move(string[,] arr)
        {
            ConsoleKeyInfo D = Console.ReadKey(true);
            Console.Clear();
            if (D.Key == ConsoleKey.D)
            {
                bool flag = false;
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < 40; j++)
                    {
                        if (arr[i,j]=="B")
                        {
                            if (j == 38)
                            {
                                flag = true;
                            }
                            else
                            {
                                arr[i, j] = "-";
                                arr[i, j + 1] = "B";
                                j++;
                            }
                        }
                    }
                    if (flag==true)
                    {
                        break;
                    }
                }
            }
            if (D.Key == ConsoleKey.A)
            {
                bool flag = false;
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < 40; j++)
                    {
                        if (arr[i, j] == "B")
                        {
                            if (j==2)
                            {
                                flag = true;
                            }
                            else
                            {
                                arr[i, j] = "-";
                                arr[i, j - 1] = "B";
                                j++;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
            }
            if (D.Key == ConsoleKey.S)
            {
                bool flag = false;
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < 40; j++)
                    {
                        if (arr[i, j] == "B")
                        {
                            if (i == 8)
                            {
                                flag = true;
                            }
                            else
                            {
                                arr[i, j] = "-";
                                arr[i+1, j] = "B";
                                i++;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
            }
            if (D.Key == ConsoleKey.W)
            {
                bool flag = false;
                for (int i = 0; i < 10; i++)
                {

                    for (int j = 0; j < 40; j++)
                    {
                        if (arr[i, j] == "B")
                        {
                            if (i == 1)
                            {
                                flag = true;
                            }
                            else
                            {
                                arr[i, j] = "-";
                                arr[i - 1, j] = "B";
                                i++;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
            }
        }
        //---------------------------------------PRINT-------------------------------------------------
        public static void print(string[,]arr)
        {
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 40; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        //==================================================================================================
        static void Main(string[] args)
        {
            string[,] arr = new string[10,40];
            //------------------------------------------------------SET-MAP------------------------------------- 
            for (int i = 0; i < 10; i++)
            {              
                for (int j = 1; j <40; j++)
                {
                    if (i == 0 || i == 9)
                    {
                        arr[i, j] = "X";
                    }
                    else
                    {
                        if (j == 1 || j==39)
                        {
                            arr[i, j] = "X";
                        }
                        else
                        {
                            arr[i, j] = "-";
                        }
                    }
                    
                }
            }
            arr[3, 3] = "B"; //Set Character
            Console.WriteLine("Press any key to play!");
            Console.WriteLine();
            bool game = true;
            while (game)
            {
                move(arr);
                print(arr);
            }
        } 
    }
}
