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
//                Console.WriteLine(@"the string is 
//{0}, {1}", input1, input2);
//                Console.WriteLine($@"the string is 
//{input1}, {input2}");





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

                string input;

                input = Console.ReadLine();

                Console.WriteLine($"input Type: {input.GetType()}");
                int coninput = Convert.ToInt32(input);
                Console.WriteLine($"input Type: {coninput.GetType()}");
                float floatinput = float.Parse(input);
                Console.WriteLine($"input Type: {floatinput.GetType()}");
                string strinput = string.Format(input);
                Console.WriteLine($"input Type: {strinput.GetType()}");







            }
        }
    }
}
