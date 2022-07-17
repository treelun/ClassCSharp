namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19
{
    public class Program
    {
        public static void Main()
        {
            int? age;

            //...

            // Clear the value of age
            age = null;

            //...

            System.Console.WriteLine($"The age is: {age}");  
        }
    }
}

//null
//아무것도 없음을 뜻함 (0이아님)
//말그대로 Nothing을 뜻함

//변수앞에 ?를 붙임으로써 해당 변수가 null을 가질수 있도록 지정함.
//(null 허용 한정자)