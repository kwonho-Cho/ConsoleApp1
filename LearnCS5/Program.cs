using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person();
            man._Name = "김철수";
            man._IsSex = true;
            man.Laugh();

            Person girl = new Person();
            girl._Name = "이영희";
            girl._IsSex = false;
            girl.Laugh();
        }
    }
    class Person
    {
        public string _Name;
        public bool _IsSex;

        public void Laugh()
        {
            if (_IsSex)
            {
                Console.WriteLine("하하하");
            }
            else
            {
                Console.WriteLine("호호호");
            }
        }
    }
}
