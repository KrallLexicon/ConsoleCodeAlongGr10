using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeAlongGr10
{
    internal class ScopeShow
    {
        int a;
        int b;
        void MyMethod()
        {
            a = 1;
            b = 2;

            Class2 class2 = new Class2();
            class2.c = 3;
            //class2.e
            Class3.d = 4; 
        }
    }

    class Class2
    {
        public int c;
        //public int e;
        
        void MyMethod2()
        {           
           int e = 10;
        }

    }
    class Class3
    {
        public static int d;
    }
}
