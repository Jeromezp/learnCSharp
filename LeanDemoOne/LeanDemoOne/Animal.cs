using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanDemoOne
{
    class Animal
    {
        public string name;
        public string category;
        public int age;

        //overload
        public Animal()
        {

        }

        public Animal(string name,string category,int age)
        {
            this.name = name;
            this.category = category;
            this.age = age;
        }

        //override
        override public string  ToString()
        {
            string info = "name: " + this.name + ",age: " + this.age + ",category: " + this.category;
            return info;
        }

        virtual public void say()
        {
            Console.WriteLine("this is animal say");
        }
    }
}
