using System;


namespace homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //            // 과제1
            //            {
            //                Console.WriteLine("Hello World");

            //                Console.ReadLine();
            //            }

            //            // 과제2
            //            {
            //                Console.Write("input s1: ");
            //                var input1 = Console.ReadLine();
            //                Console.Write("input s2: ");
            //                var input2 = Console.ReadLine();

            //                var input3 = "the string is \n" + input1 + ", " + input2;


            //                Console.WriteLine($"the string is \n{input1}, {input2}");
            //                Console.WriteLine("the string is \n{0}, {1}", input1, input2);
            //                Console.WriteLine(input3);
            //                Console.WriteLine("the string is \n{1}, {0}", input2, input1);

            /* 
            
            강사님 답안

            string s1;
            string s2;

            Write("input s1 : ");

            s1 = ReadLine();

            Write("input s2 : ");

            s2 = ReadLine();

            WriteLine("the string is \n{0}, {1}",s1,s2);
            WriteLine($"the string is \n{s1}, {s2}");
            WriteLine(@"the string is
            {0}, {1}",s1,s2);
            WriteLine($@"the string is
            {s1}, {s2}");
            ReadKey();
            */





//            }

            // 과제3

            {
                //두번째 숙제입니다!
                //입력을 받고
                //입력받은 값을
                //int로, int를 바꾼값을
                //float으로, float을 바꾼값을
                //string으로 변환해주시면됩니다!

                //여기서 입력은 ReadLine()으로 받으시면 되고,
                //받는 값은 string으로 받아집니다!잘 생각하세요
                //string -> int -> float -> string 이라고 보시면됩니다!

                //코드만 볼꺼니까 출력은 따로 안해주셔도 됩니다
                //작성하신 변환하기만 깃허브에 올려주시면됩니다!
/*
                string input;

                input = Console.ReadLine();

                Console.WriteLine($"input Type: {input.GetType()}");
                int coninput = Convert.ToInt32(input);
                Console.WriteLine($"input Type: {coninput.GetType()}");
                float floatinput = float.Parse(input);
                Console.WriteLine($"input Type: {floatinput.GetType()}");
                string strinput = string.Format(input);
                Console.WriteLine($"input Type: {strinput.GetType()}");


                //강사님 답안
                string s1;

                Write("input1 : ");
                s1 = ReadLine();

                int int1 = int.Parse(s1);

                float flo1 = (float)int1;

                string ss = flo1.ToString();





                */
        }

            //과제 4
            {
                /*숙제입니다!
                2개의 float값을 입력받고 사칙연산을 해주세요!
                결과값입니다! */

                float num1 = 0, num2 = 0, plus = 0, minus = 0, remai = 0, multi = 0, divide = 0;

                Console.Write("input float1 : ");
                num1 = float.Parse(Console.ReadLine());

                Console.Write("input float2 : ");
                num2 = float.Parse(Console.ReadLine());

                plus = num1 + num2;
                minus = num1 - num2;
                remai = num1 % num2;
                multi = num1 * num2;
                divide = num1 / num2;


                Console.WriteLine($"+ : {plus}");
                Console.WriteLine($"- : {minus}");
                Console.WriteLine($"% : {remai}");
                Console.WriteLine($"/ : {divide}");
                Console.WriteLine($"* : {multi}");


            }
        }
    }
}
