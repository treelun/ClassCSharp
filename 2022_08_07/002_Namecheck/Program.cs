using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Namecheck
{
    class Program
    {
        static void Main(string[] args)
        {

            //조재광
            //김소원
            //유승호
            //최유민
            //조 = 51312
            //김 = 44608
            //유 = 50976
            //최 = 52572
            string inputname = "조재광 김소원 유승호 유승민";
            char[] name = inputname.ToCharArray();
            int[] arrayint = new int[4];
            int[] arraysecond = new int[4];
            //name[0];
            /*            int intname = Convert.ToInt32(name[0]);

                        int intname1 = Convert.ToInt32(name[4]);

                        int intname2 = Convert.ToInt32(name[8]);
                        int intname3 = Convert.ToInt32(name[12]);*/

            for (int i = 0; i < name.Length; i++)
            {
                if (i % 4 == 0)
                {
                    /*Console.Write(name[i]);
                    Console.Write(name[i+4]);*/
                    arrayint[i/4] = name[i];
                    arraysecond[(i + 1) / 4] = name[i];
                }
                

               

            }
            Console.WriteLine();
            int k = 0;
            for (int i = 0; i < arrayint.Length; i++)
            {
                for (int j = 0; j < arrayint.Length; j++)
                {
                    if (arrayint[i] < arrayint[j])
                    {
                        k = arrayint[i];
                        arrayint[i] = arrayint[j];
                        arrayint[j] = k;

                       // arrayint[j] = arrayint[i];

                    }
                    
                }

               
            }
            for (int i = 0; i < arraysecond.Length; i++)
            {
                for (int j = 0; j < arraysecond.Length; j++)
                {
                    if (arraysecond[i] < arraysecond[j])
                    {
                        k = arraysecond[i];
                        arraysecond[i] = arraysecond[j];
                        arraysecond[j] = k;

                        // arrayint[j] = arrayint[i];

                    }

                }


            }
            for (int i = 0; i < arrayint.Length; i++)
            {
                for (int p = 0; p < inputname.Length; p++)
                {
                    if (arrayint[i] == Convert.ToInt32(inputname[p]) && p%4 ==0)
                    {
                        
                        Console.Write($"{inputname[p]}");
                        Console.Write($"{inputname[p+1]}");
                        Console.WriteLine($"{inputname[p+2]}");
                        continue;
                    }
                       

                }
            }
            Console.WriteLine($"{arrayint[0]},{arrayint[1]},{arrayint[2]},{arrayint[3]}");
            // TODO: 여기에 응용 프로그램을 시작하는 코드를 추가합니다.       
            /*            string str = "ㄱㄴㄷ";        
                        char[] charArray = str.ToCharArray();   
                        Console.WriteLine("Char Array");
                                for(int i=0;i<charArray.Length;i++)
                        {
                            Console.WriteLine((int)charArray[i]);
                        }
                               
                        foreach( char a in charArray )   
                            Console.WriteLine("{0}", (int)a);

                        Console.WriteLine(); 
                        byte[] byteArray = System.Text.ASCIIEncoding.Default.GetBytes(str);  
                        Console.WriteLine("Byte Array"); 
                        for(int i=0;i<byteArray.Length;i++) 
                              Console.WriteLine(byteArray[i]);  
                        foreach( char a in byteArray )
                        { 
                            Console.WriteLine("{0}", (int)a);}*/

        }
    }
}
