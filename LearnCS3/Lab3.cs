using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS3
{
    class Lab3
    {
        public static void Asssignment()
        {
            //#1
            {
                //int[] arr;
                //int storage = 0, order = 0;
                //Random rd = new Random();

                //Console.Write("최솟값을 정해주세요 : ");
                //int minNum = Convert.ToInt32(Console.ReadLine());
                //Console.Write("최댓값을 정해주세요 : ");
                //int maxNum = Convert.ToInt32(Console.ReadLine());
                //Console.Write("몇 개의 값을 저장하시겠습니까? : ");
                //int arrCnt = Convert.ToInt32(Console.ReadLine());
                //arr = new int[arrCnt];

                //for문만 구현 - 출력문은 따로 빼는게 좋다(?)
                //for(int i = 0; i<arr.Length; i++)
                //{
                //    arr[i] = rd.Next(minNum, maxNum + 1);
                //    Console.WriteLine("{0}번째 값 : {1} ", i + 1, arr[i]);
                //    if (arr[i] >= storage)
                //    {
                //        storage = arr[i];
                //        order = i;
                //    }
                //}

                //foreach문 구현. foreach문은 임의변수에 할당이 안되기 때문에 할당될 변수를 외부에서 끌어와야된다.
                //int f_order = 1;

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    arr[i] = rd.Next(minNum, maxNum + 1);
                //}
                //foreach (int i in arr)
                //{
                //    if (i >= storage)
                //    {
                //        storage = i;
                //        order = f_order;
                //    }
                //    Console.WriteLine("{0}번째 값 : {1} ", f_order++, i);

                //}

                //Console.WriteLine("제일 큰 값은 {0}번째 입니다.", order);
            }

            //#2
            {
                //int count = 0, minNum = int.MaxValue, maxNum = 0,
                //    minOrder = 0, maxOrder = 0, temCount = 0; ;
                //int[] arr;
                //bool isExit = false;
                //Random rd = new Random();

                //Console.Write("몇 개의 수를 저장하는 배열을 만드시겠습니까? : ");
                //count = Convert.ToInt32(Console.ReadLine());
                //arr = new int[count];

                //for (int i = 0; i < count; i++)
                //{
                //    temCount++;
                //    arr[i] = rd.Next(100, 1000);
                //    Console.Write("{0}  ", arr[i]);
                //    //if (((i + 1) != 0) && ((i + 1) % 5 == 0))
                //    //{
                //    //    Console.WriteLine();
                //    //}
                //    if(temCount % 5 == 0)
                //    {
                //        temCount = 0;
                //        Console.WriteLine();
                //    }

                //    if (arr[i] > maxNum)
                //    {
                //        maxNum = arr[i];
                //        maxOrder = i + 1;
                //    }
                //    if (arr[i] < minNum)
                //    {
                //        minNum = arr[i];
                //        minOrder = i + 1;
                //    }
                //}
                //Console.WriteLine();
                //while (!isExit)
                //{
                //    Console.Write("1.최솟값\n2.최댓값\n3.나가기\n무엇을 하시겠습니까 : ");
                //    int tempNum = int.Parse(Console.ReadLine());
                //    if (tempNum == 1)
                //    {
                //        Console.WriteLine("최솟값은 {0}이고, {1}번째 입니다.", minNum, minOrder);
                //    }
                //    else if (tempNum == 2)
                //    {
                //        Console.WriteLine("최댓값은 {0}이고, {1}번째 입니다.", maxNum, maxOrder);
                //    }
                //    else if (tempNum == 3)
                //    {
                //        isExit = true;
                //        Console.WriteLine("안녕히 계세요.");
                //    }
                //    else
                //    {
                //        Console.WriteLine("잘못 입력하셨습니다.");
                //        //for (int i = 0; i < count; i++)
                //        //{
                //        //    Console.Write("{0}  ", arr[i]);
                //        //    if (((i + 1) != 0) && ((i + 1) % 5 == 0))
                //        //    {
                //        //        Console.WriteLine();
                //        //    }
                //        //}
                //        int tempOrder = 0;
                //        foreach(int i in arr)
                //        {
                //            Console.Write("{0}  ", i);

                //            tempOrder++;
                //            if(tempOrder % 5 == 0)
                //            {
                //                Console.WriteLine();
                //            }
                //        }
                //        Console.WriteLine();
                //    }

                //}
            }

            //#3
            {
                bool isOver = false;
                int count = 0, totalSum = 0;
                Console.Write("최솟값을 입력하세요 : ");
                int minNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("최댓값을 입력하세요 : ");
                int maxNumber = Convert.ToInt32(Console.ReadLine());
                while (!isOver)
                {
                    Console.Write($"({minNumber})~({maxNumber})사이의 값을 입력하세요 ." +
                        $"(최소,최대 포함) ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number < minNumber || number > maxNumber)
                    {
                        isOver = true;
                    }
                    else
                    {
                        totalSum += number;
                        count++;
                    }
                }
                Console.WriteLine("{0}개의 수를 입력하셨습니다\n" +
                    "{0}개의 수 총합은 {1}이고, 평균은 {2:F2}입니다.", count, totalSum, (float)totalSum / count);

                //int dan = 0;
                //bool isOver = false;
                //while (!isOver)
                //{
                //    Console.Write("구구단중 출력 단 수를 입력하세요(999입력시 종료) : ");
                //    dan = Convert.ToInt32(Console.ReadLine());
                //    if(dan == 999)
                //    {
                //        isOver = true;
                //    }
                //    for(int i = 0; i<=9; i++)
                //    {
                //        Console.Write("{0}X{1} = {2}   ", dan, i, i * dan);
                //        if (i % 3 == 0)
                //        {
                //            Console.WriteLine();
                //        }
                //    }
                //}
            }


        }
    }
}
