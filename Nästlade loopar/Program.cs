using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nästlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning1

            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            //övning2

            Console.WriteLine(" ");

            for (int a = 0; a < 11; a++)
            {
                for (int b = 0; b < 11; b++)
                {
                    if ((b + a) % 2 == 0)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();
            }


            //övning3
            Console.WriteLine(" ");

            for (int a = 0; a < 11; a++)
            {
                for (int b = a; b < 11; b++)


                {
                    Console.Write("#");
                }
                   Console.WriteLine();
            }

            //övning4
            Console.WriteLine(" ");

            for (int a = 0; a < 7; a++)
            {
                for (int b = 0; b < 7; b++)
                {
                    if ( a - b < 0)
                        Console.Write("*");
                    else
                        Console.Write(".");              

                }
                Console.WriteLine();
            }

        }
    }
}
    
    

