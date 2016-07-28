using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanDemoOne
{
    abstract class Student
    {
        public enum Gender : int
        {
            male, famle
        }
        abstract public void say();

    }
}
