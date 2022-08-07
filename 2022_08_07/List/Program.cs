using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> ();
            //{ "사과 배 수박 복숭아 포도" }
            myList.Add("사과");
            
            myList.Add("배");
            myList.Add("수박");
            myList.Add("복숭아");
            myList.Add("포도");
            myList.RemoveAt(3);
            Console.WriteLine($"{myList[0]},{myList[1]}, {myList[2]}, {myList[3]}");

            Dictionary<string, int> myDic = new Dictionary<string, int> ();
            myDic["수박"] = 1;
            myDic["배"] = 0;
            myDic["포도"] = 2;
            myDic["복숭아"] = 3;
            Console.WriteLine($"{ myDic["수박"]}");

        }
    }
}
