using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS5
{
    //enum을 클래스밖에서 구현시 한정된 네임스페이스 안에서는 어디든 사용가능하다는것
    public enum eTypeJob
    {
        Student = 0,
        OfficeWorkers
    }

    //public static class Question
    //{
    //    public static int select = 0;
    //    public static int[] typeofTime = new int[2];
    //    public static void AskUsersJop()
    //    {

    //        InputNumberToString("1.학생\n2.직장인\n당신은 어느 직종이십니까 ? : ", out select );
    //    }
    //    public static void AskUsersDoing()
    //    {

    //        if (select == 1 || select ==2)
    //        {
    //            InputNumberToString("어느 시간에 무슨 일을 하고있는지 알고 싶으신가요 : ", out typeofTime[select - 1]);
    //        }
    //        else
    //        {
    //            Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
    //        }
            
            
    //    }
    //    static void InputNumberToString(string explain, out int result)
    //    {
    //        while (true)
    //        {
    //            Console.Write(explain);
    //            if (!int.TryParse(Console.ReadLine(), out result))
    //                Console.WriteLine("숫자형 문자열을 입력하지 않았습니다.");
    //            else
    //                break;
    //        }

    //    }
    //}
    class Question
    {
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
        public static eTypeJob AskJob()
        {
            int select;

            while (true)
            {
                InputNumberToString("1.학생\n2.직장인\n당신은 어느 직종이십니까 ? : ", out select);
                if (select == 1 || select == 2)
                {
                    break;
                }
                else
                    Console.WriteLine("범위내의 숫자를 입력하세요.");
            }
            return (eTypeJob)(select - 1);
        }

        //BasicNeeds를 매개변수로 했기 때문에, BasicNeeds를 상속하는 객체들은 모두 이 함수에서
        //BasicNeeds 형식으로 들어온다. 이 덕분에 BasicNeeds를 상속하는 객체들은 모두 이 함수로 이용해먹을 수 있다.
        public static void WhatTime(eTypeJob type, BasicNeeds basic)
        {
            int curTime = 0;

            //객체가 할당된 것이 아니고, 참조변수를 저장할 메모리만 만들어 놓는것
            WorkMan off;
            Student stu;

            
            while (true)
            {
                InputNumberToString("어느 시간에 무슨 일을 하고있는지 알고 싶으신가요(999입력시 종료) : ",
                    out curTime);
                if(curTime == 999)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }
                else if(curTime >= 0 && curTime <= 24)
                {
                    if(type == eTypeJob.Student)
                    {
                        stu = basic as Student;
                        stu.WhatTime(curTime);
                    }
                    else
                    {
                        off = (WorkMan)basic;
                        off.WhatTime(curTime);
                    }
                }
                else
                {
                    Console.WriteLine("범위 안의 시간이 아닙니다. 다시 입력해주세요 ... ");
                }
            }
        }
    }
}
