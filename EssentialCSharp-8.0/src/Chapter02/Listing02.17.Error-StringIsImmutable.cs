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

//string �� �ɷ�?
//�빮�ڷ� ǥ���ϱ�
//    string ���ڿ� Ŭ������ �پ��� Ȱ���
//    .compare ��
//    .format �ʱ�ȭ
//    .concat ��ġ��
//.Tolower, ToUppder, Trim, Replace ���....
