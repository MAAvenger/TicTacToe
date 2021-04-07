using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace TicTacToe

{

    class Program

    {

        //making array and   

        //by default I am providing 0-9 where no use of zero  

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; //By default player 1 is set  

        static int choice; //This holds the choice at which position user want to mark   

        static int round = 1;

        public static List<int> movelist = new List<int>();







        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  

        static int flag = 0;



        static void Main(string[] args)

        {
            Random rand = new Random();

            do

            {

                Console.Clear();// whenever loop will be again start then screen will be clear  

                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("Round " + round);

                Console.WriteLine("\n");

                if (player % 2 == 0)//checking the chance of the player  

                {

                    Console.WriteLine("Player 2 Chance");

                }

                else

                {

                    Console.WriteLine("Player 1 Chance");

                }

                Console.WriteLine("\n");

                Board();// calling the board Function  

                if (player % 2 == 0)
                {
                    if (round == 1)
                    {
                        if (arr[1] == 'X' || arr[3] == 'X' || arr[7] == 'X' || arr[9] == 'X')
                        {
                            choice = 5;
                        }
                        if (arr[5] == 'X')
                        {
                            //choice = RandomMove(movelist);
                            int[] movelist = { 1, 3, 7, 9 };
                            choice = movelist[rand.Next(movelist.Length)];
                        }
                        if (arr[2] == 'X')
                        {
                            int[] movelist = { 5, 8, 1, 3 };
                            choice = movelist[rand.Next(movelist.Length)];
                        }
                        if (arr[4] == 'X')
                        {
                            int[] movelist = { 1, 7, 5, 6 };
                            choice = movelist[rand.Next(movelist.Length)];
                        }
                        if (arr[8] == 'X')
                        {
                            int[] movelist = { 2, 5, 7, 9 };
                            choice = movelist[rand.Next(movelist.Length)];
                        }
                        if (arr[6] == 'X')
                        {
                            int[] movelist = { 4, 5, 3, 9 };
                            choice = movelist[rand.Next(movelist.Length)];
                        }
                    }if (round > 1)
                    {
                        choice = 0;
                        if (arr[5] != 'X' && arr[5] != 'O')
                        {
                            choice = 5;
                        }
                        //////////////////////////SCORE/BLOCK///////////////////////////////
                        ///BLOCK
                        ///Horizontal
                        ///
                        if ((arr[1] == 'X' && arr[2] == 'X') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 3;
                        } 
                        else if ((arr[4] == 'X' && arr[5] == 'X') && (arr[6] != 'X' && arr[6] != 'O'))
                        {
                            choice = 6;
                        }
                        else if ((arr[7] == 'X' && arr[8] == 'X') && (arr[9] != 'X' && arr[9] != 'O'))
                        {
                            choice = 9;
                        }
                        else if ((arr[2] == 'X' && arr[3] == 'X') && (arr[1] != 'X' && arr[1] != 'O'))
                        {
                            choice = 1;
                        }
                        else if ((arr[5] == 'X' && arr[6] == 'X') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 4;
                        }
                        else if ((arr[8] == 'X' && arr[9] == 'X') && (arr[7] != 'X' && arr[7] != 'O'))
                        {
                            choice = 7;
                        }
                        else if ((arr[1] == 'X' && arr[3] == 'X') && (arr[2] != 'X' && arr[2] != 'O'))
                        {
                            choice = 2;
                        }
                        else if ((arr[4] == 'X' && arr[6] == 'X') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[7] == 'X' && arr[9] == 'X') && (arr[8] != 'X' && arr[8] != 'O'))
                        {
                            choice = 8;
                        }
                        ///Vertical
                        else if ((arr[1] == 'X' && arr[4] == 'X') && (arr[7] != 'X' && arr[7] != 'O'))
                        {
                            choice = 7;
                        }
                        else if ((arr[2] == 'X' && arr[5] == 'X') && (arr[8] != 'X' && arr[8] != 'O'))
                        {
                            choice = 8;
                        }
                        else if ((arr[3] == 'X' && arr[6] == 'X') && (arr[9] != 'X' && arr[9] != 'O'))
                        {
                            choice = 9;
                        }
                        else if ((arr[4] == 'X' && arr[7] == 'X') && (arr[1] != 'X' && arr[1] != 'O'))
                        {
                            choice = 1;
                        }
                        else if ((arr[5] == 'X' && arr[8] == 'X') && (arr[2] != 'X' && arr[2] != 'O'))
                        {
                            choice = 2;
                        }
                        else if ((arr[6] == 'X' && arr[9] == 'X') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 3;
                        }
                        else if ((arr[1] == 'X' && arr[7] == 'X') && (arr[4] != 'X' && arr[4] != 'O'))
                        {
                            choice = 4;
                        }
                        else if ((arr[2] == 'X' && arr[8] == 'X') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[3] == 'X' && arr[9] == 'X') && (arr[6] != 'X' && arr[6] != 'O'))
                        {
                            choice = 6;
                        }
                        ///Diagonal
                        else if ((arr[1] == 'X' && arr[9] == 'X') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[3] == 'X' && arr[7] == 'X') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[5] == 'X' && arr[9] == 'X') && (arr[1] != 'X' && arr[1] != 'O'))
                        {
                            choice = 1;
                        }
                        else if ((arr[5] == 'X' && arr[7] == 'X') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 3;
                        }
                        else if ((arr[3] == 'X' && arr[5] == 'X') && (arr[7] != 'X' && arr[7] != 'O'))
                        {
                            choice = 7;
                        }
                        else if ((arr[1] == 'X' && arr[5] == 'X') && (arr[9] != 'X' && arr[9] != 'O'))
                        {
                            choice = 9;
                        }
                        ///SCORE
                        if ((arr[1] == 'O' && arr[2] == 'O') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 3;
                        }
                        else if ((arr[4] == 'O' && arr[5] == 'O') && (arr[6] != 'X' && arr[6] != 'O'))
                        {
                            choice = 6;
                        }
                        else if ((arr[7] == 'O' && arr[8] == 'O') && (arr[9] != 'X' && arr[9] != 'O'))
                        {
                            choice = 9;
                        }
                        else if ((arr[2] == 'O' && arr[3] == 'O') && (arr[1] != 'X' && arr[1] != 'O'))
                        {
                            choice = 1;
                        }
                        else if ((arr[5] == 'O' && arr[6] == 'O') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 4;
                        }
                        else if ((arr[8] == 'O' && arr[9] == 'O') && (arr[7] != 'X' && arr[7] != 'O'))
                        {
                            choice = 7;
                        }
                        else if ((arr[1] == 'O' && arr[3] == 'O') && (arr[2] != 'X' && arr[2] != 'O'))
                        {
                            choice = 2;
                        }
                        else if ((arr[4] == 'O' && arr[6] == 'O') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[7] == 'O' && arr[9] == 'O') && (arr[8] != 'X' && arr[8] != 'O'))
                        {
                            choice = 8;
                        }
                        ///Vertical
                        else if ((arr[1] == 'O' && arr[4] == 'O') && (arr[7] != 'X' && arr[7] != 'O'))
                        {
                            choice = 7;
                        }
                        else if ((arr[2] == 'O' && arr[5] == 'O') && (arr[8] != 'X' && arr[8] != 'O'))
                        {
                            choice = 8;
                        }
                        else if ((arr[3] == 'O' && arr[6] == 'O') && (arr[9] != 'X' && arr[9] != 'O'))
                        {
                            choice = 9;
                        }
                        else if ((arr[4] == 'O' && arr[7] == 'O') && (arr[1] != 'X' && arr[1] != 'O'))
                        {
                            choice = 1;
                        }
                        else if ((arr[5] == 'O' && arr[8] == 'O') && (arr[2] != 'X' && arr[2] != 'O'))
                        {
                            choice = 2;
                        }
                        else if ((arr[6] == 'O' && arr[9] == 'O') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 3;
                        }
                        else if ((arr[1] == 'O' && arr[7] == 'O') && (arr[4] != 'X' && arr[4] != 'O'))
                        {
                            choice = 4;
                        }
                        else if ((arr[2] == 'O' && arr[8] == 'O') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[3] == 'O' && arr[9] == 'O') && (arr[6] != 'X' && arr[6] != 'O'))
                        {
                            choice = 6;
                        }
                        ///Diagonal
                        else if ((arr[1] == 'O' && arr[9] == 'O') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[3] == 'O' && arr[7] == 'O') && (arr[5] != 'X' && arr[5] != 'O'))
                        {
                            choice = 5;
                        }
                        else if ((arr[5] == 'O' && arr[9] == 'O') && (arr[1] != 'X' && arr[1] != 'O'))
                        {
                            choice = 1;
                        }
                        else if ((arr[5] == 'O' && arr[7] == 'O') && (arr[3] != 'X' && arr[3] != 'O'))
                        {
                            choice = 3;
                        }
                        else if ((arr[3] == 'O' && arr[5] == 'O') && (arr[7] != 'X' && arr[7] != 'O'))
                        {
                            choice = 7;
                        }
                        else if ((arr[1] == 'O' && arr[5] == 'O') && (arr[9] != 'X' && arr[9] != 'O'))
                        {
                            choice = 9;
                        }
                        /////////////////////////SCORE/BLOCK///////////////////////////////
                        
                        if (choice == 0)
                        {
                            /////////////////////////////RAND/////////////////////////////

                            int movelistindex = 0;
                            for (int i = 1; i < 10; i++)
                            {

                                if (arr[i] != 'X' && arr[i] != 'O')
                                {
                                    movelist.Add(i);
                                    movelistindex += 1;
                                }
                                /////////////////////////////RAND/////////////////////////////
                                

                            }
                            choice = movelist[rand.Next(movelist.Count)];
                            movelist.Clear();
                        }
                    }
                        
                    
                        
                    


                }
                else
                {
                    choice = int.Parse(Console.ReadLine());//Taking users choice   
                }



                // checking that position where user want to run is marked (with X or O) or not  

                if (arr[choice] != 'X' && arr[choice] != 'O')

                {

                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  

                    {

                        arr[choice] = 'O';

                        player++;

                    }

                    else

                    {

                        arr[choice] = 'X';

                        player++;

                    }

                }

                else //If there is any possition where user want to run and that is already marked then show message and load board again  

                {

                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

                    Console.WriteLine("\n");

                    Console.WriteLine("Please wait 2 second board is loading again.....");

                    Thread.Sleep(2000);

                }

                flag = CheckWin();// calling of check win  
                if (player % 2 != 0)
                {
                    round += 1;
                }

            } while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  



            Console.Clear();// clearing the console  

            Board();// getting filled board again  



            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  

            {

                Console.WriteLine("Player {0} has won", (player % 2) + 1);

            }

            else// if flag value is -1 the match will be draw and no one is winner  

            {

                Console.WriteLine("Draw");

            }

            //ai vs player choice implementation
            //Console.ReadLine();
        }

        // Board method which creats board  

        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }



        //Checking that any player has won or not  

        private static int CheckWin()

        {

            #region Horzontal Winning Condtion

            //Winning Condition For First Row   

            if (arr[1] == arr[2] && arr[2] == arr[3])

            {

                return 1;

            }

            //Winning Condition For Second Row   

            else if (arr[4] == arr[5] && arr[5] == arr[6])

            {

                return 1;

            }

            //Winning Condition For Third Row   

            else if (arr[6] == arr[7] && arr[7] == arr[8])

            {

                return 1;

            }

            #endregion



            #region vertical Winning Condtion

            //Winning Condition For First Column       

            else if (arr[1] == arr[4] && arr[4] == arr[7])

            {

                return 1;

            }

            //Winning Condition For Second Column  

            else if (arr[2] == arr[5] && arr[5] == arr[8])

            {

                return 1;

            }

            //Winning Condition For Third Column  

            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {

                return 1;

            }

            #endregion



            #region Diagonal Winning Condition

            else if (arr[1] == arr[5] && arr[5] == arr[9])

            {

                return 1;

            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {

                return 1;

            }

            #endregion



            #region Checking For Draw

            // If all the cells or values filled with X or O then any player has won the match  

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

            {

                return -1;

            }

            #endregion



            else

            {

                return 0;

            }

        }

      /*private static int RandomMove(int[] movelist);
        {
            private Random rand = new Random();
            return movelist[rand.Next(movelist.Length)];
        } */

    }

}
