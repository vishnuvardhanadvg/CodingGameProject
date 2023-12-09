using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameProject.Calculators
{
    internal class Addition
    {
        private int num1 { get; set; }
        private int num2 { get; set; }
        public Addition(int a,int b)
        {
            num1 = a;
            num2 = b;
        }

        private int Add()
        {
            return num1 + num2;
        }
    }
}
