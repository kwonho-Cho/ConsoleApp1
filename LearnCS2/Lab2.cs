using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS2
{
    class Lab2
    {
        public static void Assignment()
        {
            Console.Write("반복횟수를 입력하세요 : ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("출력 문자열을 입력하세요 : ");
            string str = Console.ReadLine();
            // (1) 반복횟수만큼 세로출력
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(str);
            }
            // (2) 반복횟수만큼 세로 + 가로출력
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(str);
                }
                Console.WriteLine();
            }
            // (3) (2)와 같이 출력하되 우측에서 하나씩
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if(j <= count - i)
                    {
                        for (int k = 0; k < str.Length; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(str);
                    }
                }
                Console.WriteLine();
            }
            // (4) 
            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    if (j <= count - i)
                    {
                        for (int k = 0; k < str.Length; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(str);
                    }
                }
                Console.WriteLine();
            }
            for(int i=1; i<= count-1; i++)
            {
                for (int j =1; j<= count; j++)
                {
                    if (j <= i)
                    {
                        for (int k = 0; k < str.Length; k++)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(str);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
