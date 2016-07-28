using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanDemoOne
{
    class Primary : Student
    {
        public override void say()
        {
            Console.WriteLine("primary school");
            //throw new NotImplementedException();
        }

        public void print()
        {
            Console.WriteLine("gender is {0}",Gender.male);
        }
    }
}
