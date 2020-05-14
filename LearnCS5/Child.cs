using System;

namespace LearnCS5
{
    class Child : Parents
    {
        float height;
        float weight;

        public Child(string name, int age, float height, float weight) : base(name,age) //외부 이니셜라이저. 이 순간에는 호출만하고 아직 객체가 생성되지 않아서 호출로 할당가능
        {
            //base로 호출하여도 이미 부모클래스가 (생성)되어있는 상태이기 때문에 에러
            //base(name, age);
            this.height = height;
            this.weight = weight;
        }

        public void Initialize(string name, int age, float height, float weight)
        {
            InitData(name, age);
            this.height = height;
            this.weight = weight;
        }
        public void ShowInfo()
        {
            ShowBase();
            Console.WriteLine("키는 {0:F}cm이고, 몸무게는 {1:F}kg입니다.", height, weight);
        }
    }
}
