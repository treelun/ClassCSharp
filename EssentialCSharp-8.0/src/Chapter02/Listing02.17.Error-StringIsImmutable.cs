namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17
{
    public class Uppercase
    {
        public static void Main()
        {
            string text;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper();

            string s1 = "Hellow";
            string s2 = "world";
            string s3 = s1 + s2;


            System.Console.WriteLine(text);
            System.Console.WriteLine(s3);
        }
    }
}

//string

//string 의 능력?
//대문자로 표현하기
//    string 문자열 클래스에 다양한 활용법
//    .compare 비교
//    .format 초기화
//    .concat 합치기
//.Tolower, ToUppder, Trim, Replace 등등....
