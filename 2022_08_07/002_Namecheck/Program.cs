using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _002_Namecheck
{
    class Program
    {
        static void namesort(List<string> myList)
        {
            string temp = " ";
            for (int i = 0; i < myList.Count; i++)
            {
                char[] ArrayList = myList[i].ToCharArray();
                for (int j = 0; j < myList.Count; j++)
                {
                    char[] ArrayList2 = myList[j].ToCharArray();
                    if ((int)ArrayList[0] < (int)ArrayList2[0] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;
                    }
                }

            }
            
        }
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

            List<string> myList = new List<string>();
            myList.Add("조재광");
            myList.Add("김소원");
            myList.Add("유승호");
            myList.Add("유승민");

            string temp = " ";
            namesort(myList);
            for (int i = 0; i < myList.Count; i++)
            {
                char[] ArrayList = myList[i].ToCharArray();
                for (int j = 0; j < myList.Count; j++)
                {
                    char[] ArrayList2 = myList[j].ToCharArray();
                    if ((int)ArrayList[0] == (int)ArrayList2[0] && (int)ArrayList[1] < (int)ArrayList2[1] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;
                    }
                }

            }
            for (int i = 0; i < myList.Count; i++)
            {
                char[] ArrayList = myList[i].ToCharArray();
                for (int j = 0; j < myList.Count; j++)
                {
                    char[] ArrayList2 = myList[j].ToCharArray();
                    if ((int)ArrayList[0] == (int)ArrayList2[0] && (int)ArrayList[1] == (int)ArrayList2[1] && (int)ArrayList[2] < (int)ArrayList2[2] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;
                    }
                }

            }
            WriteLine($"{myList[0]}, {myList[1]}, {myList[2]}, {myList[3]}");

            List<string> myList2 = new List<string>();
            myList.Add("조재광");
            myList.Add("김소원");
            myList.Add("유승호");
            myList.Add("유승민");
            myList.Add("유승재");
            myList.Add("이승호");
            myList.Add("이호승");

            string temp2 = "";
            for (int i = 0; i < myList.Count; ++i)
            {
                char[] arr1 = myList[i].ToCharArray();

                for (int j = 0; j < myList.Count; ++j)
                {
                    char[] arr2 = myList[j].ToCharArray();

                    if ((int)arr1[0] < (int)arr2[0] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;

                        continue;
                    }
                }
            }

            temp = "";
            for (int i = 0; i < myList.Count; ++i)
            {
                char[] arr1 = myList[i].ToCharArray();

                for (int j = 0; j < myList.Count; ++j)
                {
                    char[] arr2 = myList[j].ToCharArray();

                    if ((int)arr1[0] == (int)arr2[0] && (int)arr1[1] < (int)arr2[1] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;

                        continue;
                    }
                }
            }

            temp = "";
            for (int i = 0; i < myList.Count; ++i)
            {
                char[] arr1 = myList[i].ToCharArray();

                for (int j = 0; j < myList.Count; ++j)
                {
                    char[] arr2 = myList[j].ToCharArray();

                    if ((int)arr1[0] == (int)arr2[0] && (int)arr1[1] == (int)arr2[1] && (int)arr1[2] < (int)arr2[2] && i != j)
                    {
                        temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;

                        continue;
                    }
                }
            }

            WriteLine(myList[0] + " " + myList[1] + " " + myList[2] + " " + myList[3] + " " + myList[4] + " " + myList[5] + " " + myList[6]);

            ReadKey();
        }
    }
}

        