using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS4
{
    class Lab4
    {
        enum ETypeCalc
        {
            덧셈 = 0,
            뺄셈,
            곱셈
        }
        public static void Assignment()
        {
            { //Queue testQ = new Queue();
              //Stack testS = new Stack();

                //for(int n = 1; n <= 5; n++)
                //{
                //    testQ.Enqueue(n * 2);
                //}

                //while (testQ.Count > 0)
                //{
                //    object obj = testQ.Dequeue();
                //    Console.WriteLine("Value = " + obj);
                //    testS.Push(obj);
                //}
                //while (testS.Count > 0)
                //{

                //    Console.WriteLine("Value = " + testS.Pop());
                //}
            }

            {//bool isExit = false;
             //Hashtable foodTalbeKor = new Hashtable();
             //Hashtable foodTalbeChn = new Hashtable();
             //Hashtable foodTalbeWes = new Hashtable();
             //Hashtable foodTalbeLight = new Hashtable();

                //while (!isExit)
                //{
                //    Console.Write("음식이름을 입력하세요 : ");
                //    string nameOfFood = Console.ReadLine();
                //    Console.Write("1.한식\n2.중식\n3.양식\n4.분식\n5.나가기\n어느 계통입니까 ? : ");
                //    int num = int.Parse(Console.ReadLine());
                //    switch (num)
                //    {
                //        case 1:
                //            foodTalbeKor.Add($"한식{foodTalbeKor.Count+1}", nameOfFood);
                //            break;
                //        case 2:
                //            foodTalbeChn.Add($"중식{foodTalbeChn.Count+1}", nameOfFood);
                //            break;
                //        case 3:
                //            foodTalbeWes.Add($"양식{foodTalbeWes.Count+1}", nameOfFood);
                //            break;
                //        case 4:
                //            foodTalbeLight.Add($"분식{foodTalbeLight.Count+1}", nameOfFood);
                //            break;
                //        case 5:
                //            isExit = true;
                //            break;

                //    }

                //}
                //foreach(object item in foodTalbeKor.Keys)
                //{
                //    Console.WriteLine("음식[{0}] = {1}", item, foodTalbeKor[item]);
                //}
                //foreach (object item in foodTalbeChn.Keys)
                //{
                //    Console.WriteLine("음식[{0}] = {1}", item, foodTalbeChn[item]);
                //}
                //foreach (object item in foodTalbeWes.Keys)
                //{
                //    Console.WriteLine("음식[{0}] = {1}", item, foodTalbeWes[item]);
                //}
                //foreach (object item in foodTalbeLight.Keys)
                //{
                //    Console.WriteLine("음식[{0}] = {1}", item, foodTalbeLight[item]);
                //}
            }

            { //케이스마다 카운팅 변수 추가하기
              //bool isExit = false;
              //Hashtable foodTable = new Hashtable();

                //while (!isExit)
                //{
                //    Console.Write("음식 이름을 입력하세요 : ");
                //    string nameOfFood = Console.ReadLine();

                //    Console.Write("1.한식\n2.중식\n3.양식\n4.분식\n5.나가기\n어느 계통입니까 ? : ");
                //    int num = int.Parse(Console.ReadLine());

                //    switch (num)
                //    {
                //        case 1:
                //            foodTable.Add("한식", nameOfFood);
                //            break;
                //        case 2:
                //            foodTable.Add("중식", nameOfFood);
                //            break;
                //        case 3:
                //            foodTable.Add("양식", nameOfFood);
                //            break;
                //        case 4:
                //            foodTable.Add("분식", nameOfFood);
                //            break;
                //        case 5:
                //            isExit = true;
                //            break;
                //    }
                //}

                //int[] numbers = new int[(int)ETypeFood.full];
                //bool isExit = false;
                //Hashtable foodTable = new Hashtable();

                //while (!isExit)
                //{
                //    Console.Write("음식 이름을 입력하세요 : ");
                //    string nameOfFood = Console.ReadLine();

                //    Console.Write("1.한식\n2.중식\n3.양식\n4.분식\n5.나가기\n어느 계통입니까 ? : ");
                //    int num = int.Parse(Console.ReadLine());

                //   if(num == 5)
                //    {
                //        isExit = true;
                //    }
                //   else
                //    {
                //        if (num <= 4 && num >= 1)
                //        {
                //            foodTable.Add(((ETypeFood)(num - 1)).ToString() + ++numbers[num - 1], nameOfFood);
                //        }
                //        else
                //            Console.WriteLine("다시 입력하세요.");
                //    }
                //}
                //foreach(object item in foodTable.Keys)
                //{
                //    Console.WriteLine("음식[{0}] : {1}", item, foodTable[item]);
                //}
            }
            //int total = 0;

            //Console.Write("시작 숫자를 입력해주세요 : ");
            //int initNum = int.Parse(Console.ReadLine());
            //Console.Write("끝 숫자를 입력해주세요 : ");
            //int endNum = int.Parse(Console.ReadLine());
            //Console.Write("짝, 홀 어떤 수를 출력하시겠습니까? :");
            //string str = Console.ReadLine();
            //Console.WriteLine("평균은 {0:F2} 입니다", SumAvg(initNum, endNum, str, ref total));
            //Console.WriteLine("총합은 {0} 입니다", total);
            #region
            //int secondNum = 0;
            //int fisrtNum = 0;
            //int selectedNum = 0;
            //int result = 0;
            //char calcTool;
            //Console.Write("첫번째 수를 입력하세요 : ");
            //fisrtNum = int.Parse(Console.ReadLine());
            //Console.Write("두번째 수를 입력하세요 : ");
            //secondNum = int.Parse(Console.ReadLine());
            //Console.Write("1.덧셈\n2.뺄셈\n3.곱셈\n어떤 셈을 하시겠습니까? : ");
            //selectedNum = int.Parse(Console.ReadLine());

            //if(CalculateNumber(selectedNum, fisrtNum, secondNum, out calcTool, out result))
            //{
            //    Console.WriteLine("{0}{1}{2} = {3}", fisrtNum, calcTool, secondNum, result);
            //}
            //else
            //{
            //    Console.WriteLine("결과가 0 이하 입니다.");
            //}
            #endregion

            
        }
        /// <summary>
        /// 시작 수부터 끝 수까지의 총 합을 구해서 평균을 출력하는 함수
        /// 마지막 oddOrEven에 의해서 짝수 또는 홀수를 골라 출력한다.
        /// </summary>
        /// <param name="initNum">총합의 시작 수</param>
        /// <param name="endNum">총합의 마지막 수</param>
        /// <param name="oddOrEven">짝인지 홀인지 인자로 받는다</param>
        /// <returns></returns>

        #region
        //static float SumAvg(int initNum, int endNum, string oddOrEven, ref int temp)
        //{
        //    ArrayList list = new ArrayList();
        //    temp = 0;
        //    float average = 0f;
        //    int check = 0;
        //    if (oddOrEven == "짝")
        //        check = 0;
        //    if (oddOrEven == "홀")
        //        check = 1;
        //    for (int i = initNum; i <= endNum; i++)
        //    {
        //        if (i % 2 == check)
        //        {
        //            Console.WriteLine(i);
        //            list.Add(i);
        //        }
        //    }
        //    if (oddOrEven == "짝")
        //    {
        //        for (int i = initNum; i <= endNum; i++)
        //        {
        //            if (i % 2 == 0)
        //            {
        //                Console.WriteLine(i);
        //                list.Add(i);
        //            }
        //        }
        //        for (int j = 0; j < list.Count; j++)
        //        {
        //            temp += (int)list[j];
        //        }
        //        average = (float)temp / list.Count;
        //    }
        //    else if (oddOrEven == "홀")
        //    {
        //        for (int i = initNum; i <= endNum; i++)
        //        {
        //            if (i % 2 == 1)
        //            {
        //                Console.WriteLine(i);
        //                list.Add(i);
        //            }
        //        }
        //        for (int j = 0; j < list.Count; j++)
        //        {
        //            temp += (int)list[j];
        //        }
        //        average = (float)temp / list.Count;
        //    }
        //    return average;
        //}
        #endregion

        #region
        //private static void ChangeValue(ref int num1, ref int num2, ref float num3)
        //{
        //    int temp;
        //    temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    num3 = (float)(num1 + num2) / 2;
        //}
        #endregion
        #region
        //static bool CalculateNumber(int select, int num1, int num2, out char tool, out int result)
        //{
        //    tool = '0';
        //    result = 0;
        //    bool isTrue = true;

        //    if ((ETypeCalc)select-1 == ETypeCalc.덧셈)
        //    {
        //        tool = '+';
        //        result = num1 + num2;
        //        if(result < 0)
        //        {
        //            isTrue = false;
        //        }
        //    }
        //    else if((ETypeCalc)select - 1 == ETypeCalc.뺄셈)
        //    {
        //        tool = '-';
        //        result = num1 - num2;
        //        if (result < 0)
        //        {
        //            isTrue = false;
        //        }
        //    }
        //    else if((ETypeCalc)select - 1 == ETypeCalc.곱셈)
        //    {
        //        tool = 'X';
        //        result = num1 * num2;
        //        if (result < 0)
        //        {
        //            isTrue = false;
        //        }
        //    }

        //    return isTrue;
        //}
        #endregion

    }
}
