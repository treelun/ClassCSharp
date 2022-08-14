using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_08_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"..............................
   ..  
  ....  
  ....  
  ....  
  ....  
  ....  ......................................
..................................................................");
            Console.WriteLine("\a \\");
            int n1 = 3;
            int n2 = 4;

            Console.WriteLine("n1 : " + n1);
            Console.WriteLine("n2 : " + n2);
            Swap(ref n1, ref n2);
            Console.WriteLine("n1 : " + n1);
            Console.WriteLine("n2 : " + n2);

            Add(n1, n2, out int result);
            Console.WriteLine($"{result}");
        }
        static void Swap(ref int n1,ref int n2)
        {

            int temp = 0;

            
            temp = n1;
            n1 = n2;
            n2 = temp;
            

        }
        static void Add(int n1,int n2 , out int result)
        {

            result = n1 + n2;

        }
    }

}
