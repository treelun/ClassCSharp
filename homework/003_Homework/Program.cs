using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Homework
{
    class Starmake 
    
    {
        public Starmake()
        {
        }

        public string Star(string a)
        {
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < i ; j++)
                {
                    Console.Write("*");

                }
                Console.Write("*\n");
            }
            return a;
        }

        public string reversStar(string a)
        {
            for (int i = 0; i < 5; i++)
            {

                
                for (int k = 4; k > i ; k--)
                {
                    Console.Write(" ");
         
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");

                }

                Console.Write("*\n");

            }

            return a;
        }

        public string SumStar(string a)
        {
            for (int i = 0; i < 5; i++)
            {


                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("**");

                }

                Console.Write("*\n");

            }

            return a;
        }
        public string ReversSumStar(string a)
        {
            for (int i = 1; i < 5; i++)
            {


                for (int k =0; k < i; k++)
                {
                    Console.Write(" ");

                }
                for (int j = 4; j > i; j--)
                {
                    
                    Console.Write("**");

                }

                Console.Write("*\n");

            }
            Console.WriteLine();
            return a;
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            Starmake star = new Starmake();
            star.Star(star.reversStar("a"));

            Console.WriteLine();

            star.SumStar("a");
            Console.WriteLine();
            
            star.ReversSumStar(star.SumStar("a"));
        }
    }
}
