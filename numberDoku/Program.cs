using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Burak Önce @burakonce9.gmail.com

namespace numberDoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] randomNumber = new int[5, 5];    //array

            randomNumberF(randomNumber);   //array of random numbers

            Console.WriteLine("Welcome to Create Prime Number Game");
            Console.WriteLine("When you click on 1, you are in the middle of the 5x5 number table.");
            Console.WriteLine("The goal is to create a prime number from the sum of the three numbers you pass by moving up, down, right and left.");

            Boolean loopgame1;  //clean value every repeat for game (2th while)
            Boolean loop = true;    //first while's variable

            while (loop)
            {
                loopgame1 = true;
                
                Console.WriteLine("\n1-Create Prime Number , 2-Quit");

                int i = Convert.ToInt32(Console.ReadLine()); //for option
                    if (i == 1)
                    {
                    while(loopgame1){
                    doku(randomNumber); //number table 5x5

                        //variable for middle of table 
                        int meridian = 2; 
                        int parallel = 2;

                        int count;

                    Console.WriteLine("\nYou are on the number "+ randomNumber[meridian, parallel] + "  ->  D(2,2)");
                    Console.WriteLine("\nYou have the right 3 move");
                    Console.WriteLine("1-up , 2-down , 3-rigth , 4-left\n");

                    int move1 = Convert.ToInt32(Console.ReadLine());
                    int move2 = Convert.ToInt32(Console.ReadLine());
                    int move3 = Convert.ToInt32(Console.ReadLine());

                        if (move1 == 1){meridian--;}
                        else if (move1 == 2) { meridian++; }
                        else if (move1 == 3) { parallel++; }
                        else if (move1 == 4) { parallel--; }

                        count = randomNumber[meridian, parallel];

                        if (move2 == 1) { meridian--; }
                        else if (move2 == 2) { meridian++; }
                        else if (move2 == 3) { parallel++; }
                        else if (move2 == 4) { parallel--; }

                        count += randomNumber[meridian, parallel];

                        if (move3 == 1) { meridian--; }
                        else if (move3 == 2) { meridian++; }
                        else if (move3 == 3) { parallel++; }
                        else if (move3 == 4) { parallel--; }

                        if (parallel < 0 || meridian < 0 || parallel > 4 || meridian > 4)
                        {
                            Console.WriteLine("Your choices kicks you off the table!!!\nTry again");           
                            break;
                        }

                        count += randomNumber[meridian, parallel];
                        
                        

                        int control = 0;
                        
                        int prime = 2;
                        while (prime < count)
                        {
                        if (count % prime == 0)
                            control++;
                        
                        prime++;
                        }
                        if (control != 0)
                        Console.WriteLine("\nYou Defeat!!\n" + prime + " is not prime");
                        else
                        Console.WriteLine("\nYou Won!!\n" + prime + " is prime");
                        loopgame1 = false;

                        }
                        
                        }
                else if (i == 2)
                    {
                        loop = false;
                    }

            }

        }

        static int[,] randomNumberF(int[,] randomNumber)
        {
            Random rnd = new Random();
            for(int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    randomNumber[i,j] = rnd.Next(0, 10);
                }
            }
            return randomNumber;
        }
        static void doku(int[,] randomNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(randomNumber[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
