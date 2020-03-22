using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 개미수열3
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = Convert.ToInt32(ReadLine());        //반복횟수 입력
            WriteLine(1);
            for (int i = 0; i < repeat; i++)        //정해진 만큼 반복
            {
                AntNumber();        //개미수열
            }
        }
        public static ulong condition = 1;    //개미수열 할 값 , 1은 1회용
        public static int count = 0;        //같은 수 반복횟수
        public static string result = "";   //개미수열 된 값
        static void AntNumber()
        {
            for (int i = 0; i < condition.ToString().Length; i++)
            {
                if (i > 0 && condition.ToString().Substring(i, 1) != condition.ToString().Substring(i - 1, 1))
                {
                    result += condition.ToString().Substring(i - 1,1) + count.ToString();
                    count = 0;
                }

                count++;
                if (i + 1 == condition.ToString().Length)
                {
                    result += condition.ToString().Substring(i, 1) + count.ToString();
                    count = 0;
                }
            }
            WriteLine(result);
            condition = Convert.ToUInt64(result);
            result = "";
        }

    }
}
