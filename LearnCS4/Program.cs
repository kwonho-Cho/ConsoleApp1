using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS4
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------ArrayList--------------------------------------------
            {
                //Add(object value);
                //Remove(int index);
                //Insert(int index, object value);

                //ArrayList list = new ArrayList();
                //list.Add(10);
                //list.Add(30);
                //list.Add("xyz");
                //list.Add("asdf");

                //for (int i = 0; i < list.Count; i++) // 배열은 length, 컬렉션은 count. 또한 Count와 Capacity 구분 중요
                //{
                //    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                //}

                //list.Insert(2, 3.14f);

                //for (int i = 0; i < list.Count; i++)
                //{
                //    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                //}

                //list.RemoveAt(0); // Remove와 RemoveAt구분

                //for (int i = 0; i < list.Count; i++)
                //{
                //    Console.WriteLine("list[{0}] = {1}", i, list[i]);
                //}
            }
            //----------------------------------------------------Queue-----------------------------------------------
            {//Queue q = new Queue();
             //q.Enqueue(1);
             //q.Enqueue(2);
             //q.Enqueue("three");
             //q.Enqueue("four");
             //while(q.Count > 0)
             //{
             //    Console.WriteLine(q.Dequeue());
             //}
            }
            //----------------------------------------------------Stack----------------------------------------------
            {
                //Stack s = new Stack();
                //s.Push(1);
                //s.Push(2);
                //s.Push("three");
                //s.Push("four");

                //while (s.Count > 0)
                //{
                //    Console.WriteLine(s.Pop());
                //}
            }
            //---------------------------------------------------HashTable-------------------------------------------
            {//식트리 구조이기 때문에 탐색속도가 빠르다. 
             //Hashtable h = new Hashtable();
             //h["book"] = "책";
             //h["cook"] = "요리사";
             //h.Add("tweet", "지저귀다");
             // 해쉬테이블은 '값'을 사전 순으로 저장한다

                //Console.WriteLine(h["book"]);
                //Console.WriteLine(h["cook"]);
                //Console.WriteLine(h["tweet"]);

                //foreach (object item in h.Keys) // Hashtable의 값에 접근할 떄는 Values를 꼭 이용해야한다 
                //{
                //    Console.WriteLine(item);
                //}
                //int n = 0;
                //object[] keys = new object[h.Count];
                //foreach(object name in h.Keys)
                //{
                //    keys[n++] = name;
                //}
                //for(int m = 0; m < keys.Length; m++)
                //{
                //    Console.WriteLine("h[{0}] = {1}", keys[m], h[keys[m]]);
                //}
            }

            {
                //int result = ShowNumbers(1,10);
                //Console.WriteLine(result);
                //result = ShowNumbers(5, 11);
                //Console.WriteLine(result);
                //Lab4.Assignment();
                //int number = 0;
                //InputNumberToString("정수를 입력하세요 : ", out number);
            }
            //---------------------------------------------------Recursive--------------------------------------------
            {//int temp = 0;

                //Console.Write("몇 번 반복하시겠습니까 : ");
                //int count = int.Parse(Console.ReadLine());


                //RecursiveFunc(count); // 무엇을 제어문으로 반복시키고 재귀문으로 재귀시킬지 구분 => 별을 반복시키고 구간을 재귀로 만드는게 용이해보임
            }
            //--------------------------------------------------Overloading-------------------------------------------
            {//float inputF;
             //InputNumberToString("실수를 입력하세요 : ", out inputF);
             //Console.WriteLine("입력하신 실수는 {0:F}입니다", inputF);
            }
            //--------------------------------------------------매개변수 초기화-----------------------------------------
            #region
            //int count = 0, select;
            //int[] sortArry;
            //Random rd = new Random();

            //InputNumberToString("몇개의 정수를 가지는 배열을 만들겠습니까 : ", out count);
            //InputNumberToString("1.오름차순\n2.내림차순\n어떤 순으로 정렬을 할까요 : ", out select);
            //sortArry = new int[count];
            //for (int n = 0; n < sortArry.Length; n++)
            //    sortArry[n] = rd.Next(20, 101);

            //Console.WriteLine("[변경전]");
            //for (int n = 0; n < sortArry.Length; n++)
            //    Console.WriteLine("{0} : {1}", n + 1, sortArry[n]);

            //if (select == 1)
            //{
            //    SortingInteger(sortArry);
            //}
            //else if (select == 2)
            //{
            //    SortingInteger(sortArry, false); //매개변수 초기화를 통해 함수 내에서 분기시킬 수 있다.
            //}
            //else
            //{
            //    Console.WriteLine("종료합니다.");
            //    return;
            //}
            //Console.WriteLine("[변경후]");
            //for(int n = 0; n<sortArry.Length; n++)
            //{
            //    Console.WriteLine("{0} : {1}", n + 1, sortArry[n]);
            //}
            #endregion
            Console.WriteLine("Sum = {0}", Sum(1, 4, 6, 8, 3, 14, 35));
            Console.WriteLine("Sum = {0}", Sum(5,3,3,7,89,0,5,10));
        }
        //static void RecursiveFunc(int count)                
        //{
        //    if(count < 0)
        //    {
        //        Console.WriteLine("탈출!");
        //        return;
        //    }

        //    Console.WriteLine("탈출까지 {0}회 남았습니다.", count);

        //    RecursiveFunc(count - 1);
        //}
        // out 과 ref의 차이점 1.out은 외부에의해 값이 오염되지 않는다. 2.out은 꼭 값이 할당되야한다.
        //static void InputNumberToString(string explain, out int result)
        //{

        //    while (true)
        //    {
        //        Console.Write(explain);
        //        if (int.TryParse(Console.ReadLine(), out result))
        //        {
        //            Console.WriteLine("숫자형 문자열을 입력하지 않았습니다.");
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }

        //}


        //private static int ShowNumbers(int initNum, int endNum)
        //{
        //    int t = 0;
        //    for(int n = initNum; n <= endNum; n++)
        //    {
        //        t += n;
        //        Console.WriteLine("Number" + n);
        //    }
        //    return t;
        //}
        //static int Plus(int su1, int su2)
        //{
        //    int result = su1 + su2;

        //    return result;
        //}
        //static int Calculate(int num1, int num2, int num3)
        //{
        //    int result = num1 * num2 + num3;

        //    return result;
        //}

        //static void RecursiveFunc(int count ,int max)
        //{

        //    if (count <= 0)
        //    {
        //        return;
        //    }

        //    for(int i = count; i<=max ; i++ )
        //    {
        //        Console.Write("*");
        //    }

        //    Console.Write("  ");

        //    RecursiveFunc(count - 1, max);
        //}
        //static void RecursiveFunc(int count)
        //{
        //    if (count < 1)
        //        return;
        //    RecursiveFunc(count - 1);               // count가 5일때 재귀를 호출하면 count가 4인 재귀를 또 호출하고... 이후 재귀가 역으로 풀리는 것을 이용
        //    for(int n = 0; n<count; n++)            //EX) count가 5인 상태로 뒤의 구현이 보류 ... 4인 상태로 보류 ... 3인 상태로 보류 ...한계점 이후 역으로 풀리는것
        //    {
        //        Console.Write("*");
        //    }
        //    Console.Write("  ");
        //}
        static void InputNumberToString(string explain, out int result)
        {
            while (true)
            {
                Console.Write(explain);
                if (!int.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("숫자형 문자열을 입력하지 않았습니다.");
                else
                    break;
            }
            
        }
        static void InputNumberToString(string explain, out float result)
        {
            while (true)
            {
                Console.Write(explain);
                if (!float.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine("숫자형 문자열을 입력하지 않았습니다.");
                else
                    break;
            }
           
        }

        static void SortingInteger(int[] arr, bool isAscending = true) 
        {
            for(int n = 0; n<arr.Length-1; n++)
            {
                for(int m = n+1; m < arr.Length; m++)
                {
                    if (isAscending)
                    {
                        if (arr[n] > arr[m]) //최솟값이 될 기준점을 잡아서 비교를 반복한다
                            SwapInteger(ref arr[n], ref arr[m]);
                    }
                    else
                    {
                        if (arr[n] < arr[m])
                            SwapInteger(ref arr[n], ref arr[m]);
                    }
                }
            }
        }
        static void SwapInteger(ref int num1, ref int num2)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = num1;
        }

        static int Sum(params int[] nums)
        {
            int t = 0;
            for(int n = 0; n<nums.Length; n++)
            {
                t += nums[n];
            }
            return t;
        } // 가변길이 매개변수 params를 넣었을시 int[] aa같이 안쓰이는 인자를 만드는 일이 없도록 하자.
    }
    
}
