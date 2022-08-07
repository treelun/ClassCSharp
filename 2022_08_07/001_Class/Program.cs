using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _001_Class
{
    class Program
    {
        static void Main(string[] args)
        {
/*            //1번
            WriteLine("1번");

            for (int i = 0; i < 5; i++)
            {
               
                for (int k = 0; k < i+1; k++)
                {
                    Write("*");                    
                }
                WriteLine();
            }
            //2번
            WriteLine("2번");
            for (int i = 0; i < 5; i++)
            {

                for (int k = 5; k > i; k--)
                {
                    Write("*");
                }
                WriteLine();
            }
            //3번
            WriteLine("3번");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Write("*");
                }
                WriteLine();
            }
            //4번
            WriteLine("4번");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(" ");
                }
                for (int k = 5; k > i; k--)
                {
                    Write("*");
                }
                WriteLine();
            }
            //5번
            WriteLine("5번");
            for (int i = 0; i < 4; i++)
            {
               
                for (int j = 3; j > i; j--)
                {
                    Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Write("*");

                }
                for (int p = 0; p < i; p++)
                {
                    Write("*");
                }
                WriteLine();
            }
            //6번
            WriteLine("6번");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Write(" ");
                }
                for (int k = 4; k > i; k--)
                {
                    Write("*");

                }
                for (int p = 2; p > i - 1; p--)
                {
                    Write("*");
                }

                WriteLine();

            }
            
            for (int i = 0; i < 4; i++)
            {

                
                for (int j = 3; j > i; j--)
                {
                    Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Write("*");

                }
                for (int p = 0; p < i ; p++)
                {
                    Write("*");
                }
                WriteLine();
            }


            WriteLine(byte.MaxValue);
            WriteLine(byte.MinValue);
            WriteLine(short.MaxValue);
            WriteLine(short.MinValue);
            WriteLine(int.MaxValue);
            WriteLine(int.MinValue);
            WriteLine(long.MaxValue);
            WriteLine(long.MinValue);

*/
            bool b;
            b = false;
            WriteLine(b);

            int a = 3;
            WriteLine(++a);
            WriteLine(a++);
            WriteLine(a);

            WriteLine(11%2 == 1? "홀수" : "짝수");
        }
    }
}
