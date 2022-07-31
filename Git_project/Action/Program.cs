using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace action
{
/*    public class ClassA
    {
        public event Action<string> OnAdd;

        private void SomethingHappened()
        {
            OnAdd?.Invoke("It Happened");
        }
    }

    public class ClassB
    {
        public ClassB()
            {
            var myClass = new ClassA();
            myClass.OnAdd += Add;
            myClass.OnAdd += Add;
            myClass.OnAdd += Add;
            myClass.OnAdd += Add;

        }
        private void Add(string Input)
        {
            //do SomeThing
        }

    }*/

    


    




    class Program
    {
        public static event Action Hi;
        static void Main(string[] args)
        {
            //n이라고 입력 받을때 까지 계속 입력을 받는다.
            //액션을 하나 만든다.
            //1 을 입력하면 액션에 Hi world라는 메소드가 호출되도록 한다.
            //2를 입력하면 액션에 hello world라는 메소드가 호출되도록 한다.
            //3.을 입력하면 액션에 안녕이라는 메소드가 호출 되도록 한다.
            //4.를 입력하면 지금까지 액션에 포함되어 있는 애들을 호출한다.
            //그외 무시
            while (true)
            {
                string input = Console.ReadLine(); ;
                switch (input)
                {
                    case "1":
                        Hi += one;
                        break;
                    case "2":
                        Hi += two;
                        break;
                    case "3":
                        Hi += tree;
                        break;
                    case "4":
                        Hi?.Invoke();
                            break;
                    default:
                        break;
                }
                if (input == "n")
                {
                    break;
                }
            }


        }
       static public void one()
        {
            Console.WriteLine("Hi world");
            
        }
        static public void two()
        {
            Console.WriteLine("Hello World");

        }
        static public void tree()
        {
            Console.WriteLine("안녕");

        }



    }
}
