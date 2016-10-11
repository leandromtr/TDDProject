using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class Calculator
    {
        const int HoursInYear = 2080;

        //Lambda Method
        public int Add(int val1, int val2) => val1+val2;
        public int Substract(int val1, int val2) => val1 - val2;
        public int Multiply(int val1, int val2) => val1 * val2;
        public int Divide(int val1, int val2) => val1 / val2;
    }
}
