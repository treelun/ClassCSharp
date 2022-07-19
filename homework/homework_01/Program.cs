using System;


namespace homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 과제1
            {
                Console.WriteLine("Hello World");

                Console.ReadLine();
            }

            // 과제2
            {
                Console.Write("input s1: ");
                var input1 = Console.ReadLine();
                Console.Write("input s2: ");
                var input2 = Console.ReadLine();

                var input3 = "the string is \n" + input1 + ", " + input2;
                

                Console.WriteLine($"the string is \n{input1}, {input2}");
                Console.WriteLine("the string is \n{0}, {1}", input1, input2);
                Console.WriteLine(input3);
                Console.WriteLine("the string is \nHellow, My name is Seungho Yu");


            }
        }
    }
}
