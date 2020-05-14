using System;

namespace LearnCS5
{
   

    public class Student : BasicNeeds
    {
        string nameOfSchool;

        public void WhatTime(int nowTime)
        {
            TimeSchedule = nowTime;

            if (TimeSchedule < 7 || TimeSchedule >= 23)
            {
                Sleep();
            }
            else if (TimeSchedule == 7)
            {
                WakeUp();
                Wash();
            }
            else if( TimeSchedule>7 && TimeSchedule < 8)
            {
                Blackfirst();
            }
            else if( TimeSchedule >=8 && TimeSchedule <9)
            {
                GotoSchool();
            }
            else if( TimeSchedule >=9 && TimeSchedule < 17)
            {
                if(TimeSchedule >= 12 && TimeSchedule < 13)
                {
                    Lunch();
                }
                else
                {
                    Study();
                }
            }
            else if( TimeSchedule >= 17 && TimeSchedule < 18)
            {
                Dinner();
            }
            else if (TimeSchedule >=18 && TimeSchedule < 20)
            {
                GotoAcademy();
            }
            else if (TimeSchedule >=20 && TimeSchedule < 22)
            {
                DoLeisure1();
            }
            else if (TimeSchedule >= 22 && TimeSchedule < 23)
            {
                DoLeisure2();
            }
            else if( TimeSchedule >=23 && TimeSchedule < 24)
            {
                Sleep();
            }
            else if (TimeSchedule > 24)
            {
                Console.WriteLine("잘못입력하셨습니다. 다시 입력해주세요.");
            }
        }

        void GotoSchool()
        {
            Console.WriteLine("학교에 간다");
        }
        void GotoAcademy()
        {
            Console.WriteLine("학원에 간다");
        }
        void Study()
        {
            Console.WriteLine("공부를 한다");
        }
        void DoLeisure1()
        {
            Console.WriteLine("(1차)여가활동을 즐긴다");
        }
        void DoLeisure2()
        {
            Console.WriteLine("(2차)여가활동을 즐긴다");
        }
    }
}
