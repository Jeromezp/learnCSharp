using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeanDemoOne
{
    delegate void Handler();
    class Incrementer
    {
        public event Handler CountedADozen;
        public void DoCount()
        {
            for(int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    CountedADozen();
                }
            }
        }
    }

    class Dozens
    {
        public int DozenCount { get; private set; }

        public Dozens(Incrementer increment)
        {
            DozenCount = 0;
            increment.CountedADozen += IncrementDozensCount;

        }

        public void IncrementDozensCount()
        {
            DozenCount++;
        }
    }


    delegate void myDelegate();
    class Program
    {

        static void Main(string[] args)
        {
            //Student s = new Primary();
            Primary p = new Primary();
            //p.print();
            //s.say();
            //Console.WriteLine(typeof(Primary));
            myDelegate del = new myDelegate(p.print);
            int[] arr = new int[3] {1,2,3};
            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
            char[,] name = new char[2, 3] { { 'a','b','c'}, {'e','f','e'} };
            foreach (char ch in name)
            {
                Console.WriteLine(ch);
            }
            Console.ReadKey();
        }
    }
}
