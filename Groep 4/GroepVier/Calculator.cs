using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GroepVier
{
    public class Calculator
    {
        public int Divide(int pNumber1, int pNumber2) => pNumber1 / pNumber2;

        public int Add(int pNumber1, int pNumber2) => pNumber1 + pNumber2;

        public int Subtract(int pNumber1, int pNumber2) => pNumber1 - pNumber2;

        public int Multiply(int pNumber1, int pNumber2) => pNumber1 * pNumber2;
    }
}
