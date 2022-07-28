using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _445
{
    class Program
    {
        static void Main(string[] args)

        {
            /* 
             string s1 = "";
             string s2 = "";

             s1 = Console.ReadLine();

             WriteThisName(s1);
             int kk = WriteThisNameint();
             int kk2 = 1;

             useSwitch(s1);

             */
            //int result = calculator(0, 0, "");
            //Console.WriteLine(result);
            //tree name = new tree();
            //name.name = "소나무";
            //hambuger bugerking = new hambuger();
            //bugerking.price = 3;

            food Food = new food();
            Food.Howmuch();


            Food.came();
            //Food.ThisFoodName();
            hansick myhansick = new hansick();
            myhansick.Guest();
            myhansick.Howmuch();


            Console.ReadKey();
          
        }
        /*
        static void WriteThisName(string ss)
        {
            if (ss == "Hello")
            {
                Console.WriteLine("this is hello");

            }
            else
            {
                Console.WriteLine("what is this");
            }
        }
        static int WriteThisNameint()
        {
            return 1;
        }

        static void useSwitch(string s1)
        {
            switch (s1)
            {
                case "1":
                    Console.WriteLine("Hello");
                    break;
                case "2":
                    Console.WriteLine("Hi");
                    break;
                case "3":
                    Console.WriteLine("bye");
                    break;
                case "4":
                    Console.WriteLine("sir");
                    break;
                case "5":
                    Console.WriteLine("my");
                    break;

                default:

                    Console.WriteLine(
                    "\nERROR:  Enter a value from 1-9. "
                    + "Push ENTER to quit");
                    break;
            }
            

        
    
        }
        

        */

        //계산기
        //calculator
        //        1. 두숫자를 입력받는다.
        //        2. input : 1
        //3. input : 3
        //4. input : (곱, 뺼, 나눗, 덧셈)

        //5. 메소드로 빼서 진행
        //6. 결과 출력
        static int calculator(int num1, int num2, string type)
        {
            int input1 = 0;
            Console.Write("input1 : ");
            input1 = int.Parse(Console.ReadLine());
            int input2 = 0;
            Console.Write("input2 : ");
            input2 = int.Parse(Console.ReadLine());
            Console.Write("input3(+.-.*./) : ");
            string input3 = Console.ReadLine();
            int result = 0;


            switch (input3)
            {
                case "+":
                    result = input1 + input2;
                    break;
                case "-":
                    result = input1 - input2;
                    break;
                case "*":
                    result = input1 * input2;
                    break;
                case "/":
                    result = input1 / input2;
                    break;


                default:

                    Console.WriteLine("값을 잘못 입력하셨습니다."
                    );
                    break;
            }

            return result;



        }

        //클래스 정의

        //class Employee
        //{

        //}

        //class zobie
        //{
        //    string name;
        //    int power;

        //    public void attackFunc()
        //    { //attack
              
        //    }

        //    public void DefenseFunc()
        //    {
        //        //defense
        //    }

        //}

        //class tree
        //{
        //    public string name;

        //}

        //class food
        //{
        //    public int price;
        //    private int barcode;
        //    protected int my;
        //}
        //class hambuger : food
        //{
           
        //}

        class food
        {
            public string name = "";
            protected int price = 0;
            private string cameFrom = "food";
            public void Howmuch()
            {
                Console.WriteLine(price);
            }
            public void came()
            {
                Console.WriteLine(cameFrom);
            }
            protected void ThisFoodName()
            {
                Console.WriteLine(name);
            }
                
        }
        class hansick : food
        {
            public void Guest()
            {
                Console.WriteLine(name);
                Console.WriteLine(price);
                //Console.WriteLine(cameFrom);

                Howmuch();

                name = "Kimchi";
                price = 3000;

                ThisFoodName();
            }
        }
        
    }
}
