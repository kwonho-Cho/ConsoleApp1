using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS5
{
    //-------------------------------------------------------상속-------------------------------------------------------

    //상속을 통해 코드의 재활용이 가능해진다 & 게임에서는 상속을 통해 일괄처리가 더 쉬워진다.

    //
   
    public class BasicNeeds
    {
        string _name;
        int timeSchedule;

        public int TimeSchedule
        {
            get { return timeSchedule; }
            set { timeSchedule = value; }
        }

        

        public void Blackfirst()
        {
            Console.WriteLine("아침 밥을 먹는다.");
        }
        public void Lunch()
        {
            Console.WriteLine("점심 밥을 먹는다.");
        }
        public void Dinner()
        {
            Console.WriteLine("저녁 밥을 먹는다.");
        }
        public void Sleep()
        {
            Console.WriteLine("잠을 잔다.");
        }
        public void WakeUp()
        {
            Console.WriteLine("잠에서 깨어난다.");
        }
        public void Wash()
        {
            Console.WriteLine("씻는다");
        }
        
    }
}
