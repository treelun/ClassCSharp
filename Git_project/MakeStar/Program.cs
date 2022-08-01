using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeStar
{

    class Program
    {
        
        static void MakeStar()
        {
            Console.WriteLine("별그리기~~~~");
            //5줄 만들기
            for (int i = 0; i <= 5; i++)
            {
                //별 아래층으로 보내기
                Console.WriteLine();
                //앞별 그리기(5부터 갯수를 줄여가며 그림)
                for (int j = 5; j > i; j--)
                {
                    Console.Write("1");

                }
                //별 사이 띄우기(K가 i만큼 증가하며 "  "를 추가 k에 1값이 들어오면 "  " 2값이 들어오면 "    ")
                for (int k = 0; k < i; k++)
                {
                    Console.Write("  ");

                }
                //반대편 별 그리기(앞별그리기와 마찬가지로 5부터 1씩 줄여가며 별을그림 > 띄어쓰기로 인해 모양이나옴)
                for (int p = 5; p > i; p--)
                {
                    Console.Write("*");

                }


            }
        }
        static void Main(string[] args)
        {
            MakeStar();

        }
    }
}
